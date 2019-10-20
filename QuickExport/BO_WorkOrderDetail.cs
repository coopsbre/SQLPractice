namespace ClientProcesses
{
    public class BO_WorkOrderDetail
    {
        public int ItemNumber { get; set; }
        public string ActivityName { get; set; }
        public WorkOrderDetail workOrderDetail { get; set; }
        public Enum_ActivityType enum_ActivityType; 
    }

    public enum Enum_ActivityType
    {
        Transaction = 1,
        Claim = 2,
        Expense = 3
    }
}