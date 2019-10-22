using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProcesses
{
    public class PRC_Export_New : _ClientProcess
    {
        public override DataValidatorReturn RunProcess(string clientCode, string workOrderNumber)
        {
            return base.RunProcess(clientCode, workOrderNumber);
        }
    }
    
}
