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
    
    public partial class WorkOrderDetail
    {
        public int WODtlId { get; set; }
        public int WOHdrID { get; set; }
        public int FDNo { get; set; }
        public string FDDescription { get; set; }
    
        public virtual WorkOrderHeader WorkOrderHeader { get; set; }
    }
}
