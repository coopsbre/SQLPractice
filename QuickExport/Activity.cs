using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProcesses
{
    public class Activity
    {
        public int ActivityNumber { get; set; }
        public string ActivityName { get; set; }
        public ActivityType ActivityType { get; set; }   
    }

    public enum ActivityType
    {
        Transaction = 1,
        Claim = 2,
        Expense = 3
    }
}
