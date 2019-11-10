using System;
using System.Linq;

namespace WorkOrderCreator.ReturnObject
{
    public class DataValidatorReturn
    {
        public string ErrorText { get; set; }
        public bool ItemFound { get; set; }
        public string ReturnText { get; set; }
        public object ReturnType { get; set; }
        public bool IsValid { get; set; }
    }
}
