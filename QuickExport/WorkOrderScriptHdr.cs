//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientProcesses
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkOrderScriptHdr
    {
        public int WOScriptHdrID { get; set; }
        public int WODtlID { get; set; }
        public int ScriptFileID { get; set; }
        public int TestPlanFileID { get; set; }
    
        public virtual ScriptFile ScriptFile { get; set; }
        public virtual WorkOrderDetail WorkOrderDetail { get; set; }
        public virtual TestPlanFile TestPlanFile { get; set; }
    }
}
