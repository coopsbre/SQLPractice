using System.Collections.Generic;

namespace ClientProcesses
{
    public class _ClientProcess
    {
        BO_WorkOrderHeader BO_WOH = new BO_WorkOrderHeader();
        

        DataValidatorReturn DVR = new DataValidatorReturn(); 

        public virtual DataValidatorReturn RunProcess(List<BO_FunctionalDescription> functionalDescription,string clientCode, string workOrderNumber)
        {
            BO_WOH.FunctionDescriptionList = functionalDescription;
            return BO_WOH.Create(clientCode, workOrderNumber);
        }
    }
}
