namespace ClientProcesses
{
    public class _ClientProcess
    {
        BO_WorkOrderHeader BO_WOH = new BO_WorkOrderHeader();
        

        DataValidatorReturn DVR = new DataValidatorReturn(); 

        public virtual DataValidatorReturn RunProcess(string clientCode, string workOrderNumber)
        {
            // For every process we will create a work order entry.
            

            // For every process create a Test Plan In the Format "Test Plan - Work Order Number"
            
            return BO_WOH.Create(clientCode, workOrderNumber);


        }
    }
}
