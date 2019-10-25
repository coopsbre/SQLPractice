using System;
using System.Linq;

namespace ClientProcesses
{
    public class BO_TestPlan
    {
        DataValidatorReturn DVR = new DataValidatorReturn();

        public DataValidatorReturn Create(string workOrderNumber)
        {
            try
            {
                using (var context = new WorkOrderLogEntities())
                {
                    TestPlanFile tpf = new TestPlanFile();
                    // tpf.WOHdrID = Convert.ToInt32(workOrderNumber);


                    context.SaveChanges();
                    DVR.IsValid = true;
                    DVR.ReturnType = tpf;
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
