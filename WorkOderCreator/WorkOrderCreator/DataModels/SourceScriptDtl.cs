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
    
    public partial class SourceScriptDtl
    {
        public int SourceScriptDtlID { get; set; }
        public int SourceScriptHdrID { get; set; }
        public string SourceFile { get; set; }
        public string ClientCode { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual SourceScriptHdr SourceScriptHdr { get; set; }
    }
}
