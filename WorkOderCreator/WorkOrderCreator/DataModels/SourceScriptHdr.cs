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
    
    public partial class SourceScriptHdr
    {
        public SourceScriptHdr()
        {
            this.SourceScriptDtls = new HashSet<SourceScriptDtl>();
        }
    
        public int SourceScriptHdrID { get; set; }
        public int ActivityTypeID { get; set; }
    
        public virtual ActivityType ActivityType { get; set; }
        public virtual ICollection<SourceScriptDtl> SourceScriptDtls { get; set; }
    }
}
