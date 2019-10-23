using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProcesses
{
    public class PRC_Export_New : _ClientProcess
    {
        public override DataValidatorReturn RunProcess(List<BO_FunctionalDescription> functionalDescriptionList, string clientCode, string workOrderNumber)
        {
            return base.RunProcess(functionalDescriptionList, clientCode, workOrderNumber);
        }
    }
    
}
