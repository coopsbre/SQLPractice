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
    
    public partial class ActivityType
    {
        public ActivityType()
        {
            this.Activities = new HashSet<Activity>();
        }
    
        public int ActivityTypeID { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
