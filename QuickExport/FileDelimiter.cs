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
    
    public partial class FileDelimiter
    {
        public FileDelimiter()
        {
            this.FileHdrs = new HashSet<FileHdr>();
        }
    
        public int UnqFileDelimiterID { get; set; }
        public string FileDelimiterID { get; set; }
        public string DelimiterChar { get; set; }
    
        public virtual ICollection<FileHdr> FileHdrs { get; set; }
    }
}
