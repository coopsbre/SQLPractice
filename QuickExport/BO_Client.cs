using System;
using System.Linq;

namespace ClientProcesses
{
    public class BO_Client
    {
        public DataValidatorReturn DVR = new DataValidatorReturn(); 

        public DataValidatorReturn Find(string clientCode)
        {
            Client client;

            try
            {
                using (var context = new WorkOrderLogEntities())
                {
                    client = context.Clients.Where(x => x.ClientCode == clientCode).ToList().FirstOrDefault();
                }

                if (client != null)
                {
                    DVR.ReturnType = client;
                    DVR.IsValid = true;
                    DVR.ReturnText = "Client: " + client.ClientCode + " Found.";
                }
                else
                {
                    DVR.ReturnType = client;
                    DVR.IsValid = false;
                    DVR.ReturnText = "Client: " + clientCode + " Not Found.";
                }
            }
            catch (Exception exception)
            {
                DVR.IsValid = false;
                DVR.ReturnText = exception.Message;
            }
            
            return DVR;
        }
    }
}
