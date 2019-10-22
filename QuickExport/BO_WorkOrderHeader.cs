using System;

namespace ClientProcesses
{
    public class BO_WorkOrderHeader
    {
        public DataValidatorReturn DVR = new DataValidatorReturn(); 

        public DataValidatorReturn Create(string clientCode, string workOrderNumber)
        {
            try
            {
                using (var context = new WorkOrderLogEntities())
                {
                    WorkOrderHeader woh = new WorkOrderHeader();
                    woh.ClientCode = clientCode;
                    woh.WOHdrID = Convert.ToInt32(workOrderNumber);
                    woh.CreatedDate = System.DateTime.Now;
                    
                    TestPlanFile tpf = new TestPlanFile();
                    tpf.FileName = "Fred";
                    context.TestPlanFiles.Add(tpf);

                    woh.TestPlanFile = tpf;

                    context.WorkOrderHeaders.Add(woh);

                    context.SaveChanges();
                    DVR.IsValid = true;
                    DVR.ReturnType = woh;
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
