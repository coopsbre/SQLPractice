//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkOrderCreator.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkOrderHeader
    {
        public WorkOrderHeader()
        {
            this.WorkOrderDetails = new HashSet<WorkOrderDetail>();
        }
    
        public int WOUniqueID { get; set; }
        public int WOHdrID { get; set; }
        public string ClientCode { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual ICollection<WorkOrderDetail> WorkOrderDetails { get; set; }
    }
}
