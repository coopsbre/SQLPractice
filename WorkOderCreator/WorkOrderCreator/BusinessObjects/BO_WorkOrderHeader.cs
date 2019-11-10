using System;
using System.Collections.Generic;
using System.Linq;
using WorkOrderCreator.DataModels;
using WorkOrderCreator.HelperClasses;
using WorkOrderCreator.ReturnObject;

namespace WorkOrderCreator.BusinessObjects
{
    public class BO_WorkOrderHeader : _BO
    {
        public DataValidatorReturn Find(int workOrderID)
        {
            DVR = MethodHelper.IsGreaterThanZero("Work Order Number", workOrderID);

            if (DVR.IsValid == false)
                return DVR;

            try
            {
                List<WorkOrderHeader> workOrderHeaders = new List<WorkOrderHeader>();

                using (var context = new WorkOrderLogEntities())
                {
                    workOrderHeaders = context.WorkOrderHeaders.Where(x => x.WOHdrID == workOrderID).ToList();
                }

                DVR.ItemFound = workOrderHeaders.Any();
                DVR.IsValid = true;
                DVR.ReturnType = workOrderHeaders.FirstOrDefault();
                if (DVR.ItemFound)
                {
                    DVR.ReturnText = workOrderHeaders.Count().ToString() + " Work Order Found.";
                    DVR.ReturnType = workOrderHeaders.FirstOrDefault();
                }
                else
                {
                    DVR.ReturnText = "Work Order Not Found.";
                }
            }
            catch (Exception exception)
            {
                DVR.IsValid = false;
                DVR.ReturnText = exception.Message;
            }

            return DVR;
        }

        public DataValidatorReturn Create(int workOrderID, string clientCode)
        {

            DVR = MethodHelper.IsGreaterThanZero("Work Order Number", workOrderID);

            if (DVR.IsValid == false)
                return DVR;

            DVR = MethodHelper.IsParameterEmpty("Client Code", clientCode);

            if (DVR.IsValid == false)
                return DVR;

            if (Find(workOrderID).ItemFound)
            {
                DVR.IsValid = false;
                DVR.ReturnText = "Work Order # " + workOrderID.ToString() + " already exists.";
                DVR.ItemFound = true;
                return DVR;
            }

            using (var context = new WorkOrderLogEntities())
            {
                WorkOrderHeader workderOrderHeader = new WorkOrderHeader()
                {
                    WOHdrID = workOrderID,
                    ClientCode = clientCode,
                    CreatedDate = DateTime.Now.ToLocalTime(),
                    CreatedBy = "SYSTEM"

                };

                try
                {
                    context.WorkOrderHeaders.Add(workderOrderHeader);
                    context.SaveChanges();
                    DVR.IsValid = true;
                    DVR.ReturnText = "Work Order #" + workOrderID.ToString() + " Added to the Database.";
                    DVR.ReturnType = workderOrderHeader;
                }
                catch (Exception exception)
                {
                    DVR.IsValid = false;
                    DVR.ReturnText = exception.Message;
                }
            }

            return DVR;
        }
    }
}
