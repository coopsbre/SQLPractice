using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WorkOrderCreator.DataModels;
using WorkOrderCreator.HelperClasses;
using WorkOrderCreator.ReturnObject;

namespace WorkOrderCreator.BusinessObjects
{
    public class BO_Client : _BO
    {
        // Purpose: Find a client given a client Code.
        public DataValidatorReturn Find(string clientCode)
        {

            DVR = MethodHelper.IsParameterEmpty("ClientCode", clientCode);

            if (DVR.IsValid == false)
                return DVR;

            try
            {
                List<Client> clients = new List<Client>();

                using (var context = new WorkOrderLogEntities())
                {
                    clients = context.Clients.Where(x => x.ClientCode == clientCode).ToList();
                }

                DVR.ItemFound = clients.Any();
                DVR.IsValid = true;
                DVR.ReturnType = clients.FirstOrDefault();
                if (DVR.ItemFound)
                {
                    DVR.ReturnText = clients.Count().ToString() + " Client Found.";
                    DVR.ReturnType = clients.FirstOrDefault();
                }
                else
                {
                    DVR.ReturnText = clientCode + " Not Found.";
                }
            }
            catch (Exception exception)
            {
                DVR.IsValid = false;
                DVR.ReturnText = exception.Message;
            }

            return DVR;
        }

        /// <summary>
        /// Purpose to check if a client Code is Empty/Not.
        /// </summary>
        /// <param name="clientCode"></param>
        /// <returns></returns>
        public bool IsParameterEmpty(string parameterString)
        {
            bool isEmpty = false;

            isEmpty = parameterString == string.Empty;

            return isEmpty;

        }

        /// <summary>
        /// Purpose is to create a client given a Client Code and Client Folder. 
        /// </summary>
        /// <param name="clientCode">Unique Client Code</param>
        /// <param name="clientFolder">Unique Client Folder</param>
        /// <returns></returns>
        public DataValidatorReturn Create(string clientCode, string clientFolder)
        {
            DVR = MethodHelper.IsParameterEmpty("ClientCode", clientCode);

            if (DVR.IsValid == false)
                return DVR;

            DVR = MethodHelper.IsParameterEmpty("ClientFolder", clientFolder);

            if (DVR.IsValid == false)
                return DVR;

            if (Find(clientCode).ItemFound)
            {
                DVR.IsValid = false;
                DVR.ReturnText = clientCode + " already exists.";
                DVR.ItemFound = true;
                return DVR;
            }

            if (FolderExists(clientFolder) == false)
            {
                DVR.IsValid = false;
                DVR.ReturnText = clientFolder + " does not exist.";
                DVR.ItemFound = true;
                return DVR;
            }

            using (var context = new WorkOrderLogEntities())
            {
                Client client = new Client()
                {
                    ClientCode = clientCode,
                    ClientFolder = clientFolder
                };

                try
                {
                    context.Clients.Add(client);
                    context.SaveChanges();
                    DVR.IsValid = true;
                    DVR.ReturnText = "Client: " + clientCode + " Added to the Database.";
                    DVR.ReturnType = client;
                }
                catch (Exception exception)
                {
                    DVR.IsValid = false;
                    DVR.ReturnText = exception.Message;
                }
            }

            return DVR;
        }

        private bool FolderExists(string clientFolder)
        {
            return Directory.Exists(clientFolder);
        }

        public DataValidatorReturn Delete(string clientCode)
        {
            DVR = MethodHelper.IsParameterEmpty("ClientCode", clientCode);

            if (DVR.IsValid == false)
                return DVR;

            DataValidatorReturn dvr = new DataValidatorReturn();
            dvr = Find(clientCode);

            if (dvr.ItemFound == false)
            {
                DVR.IsValid = false;
                DVR.ReturnText = clientCode + " not found.";
                DVR.ItemFound = false;
                return DVR;
            }

            using (var context = new WorkOrderLogEntities())
            {
                try
                {
                    int workOrderHeaderCount = 0;

                    //Delete foreign relationships etc.
                    var workOrderHeaders = context.WorkOrderHeaders.Where(x => x.ClientCode == clientCode).ToList();
                    workOrderHeaderCount = workOrderHeaders.Count();

                    for (int i = 0; i < workOrderHeaderCount; i++)
                    {
                        WorkOrderHeader workOrderHeader = workOrderHeaders[i];
                        context.WorkOrderHeaders.Remove(workOrderHeader);
                    }

                    Client client = context.Clients.Where(x => x.ClientCode == clientCode).FirstOrDefault();

                    context.Clients.Remove(client);

                    context.SaveChanges();

                    DVR.IsValid = true;
                    DVR.ReturnText = clientCode + " Removed Successfully." + Environment.NewLine + workOrderHeaderCount.ToString() +
                                     " Work Order Headers Removed successfully.";
                }
                catch (Exception exception)
                {
                    DVR.IsValid = false;
                    DVR.ErrorText = exception.Message;
                }
            }

            return DVR;
        }
    }
}
