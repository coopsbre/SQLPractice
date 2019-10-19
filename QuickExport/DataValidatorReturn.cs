namespace ClientProcesses
{
    public class DataValidatorReturn
    {
        public string ErrorText { get; set; }
        public string ReturnText { get; set; }
        public object ReturnType { get; set; }
        public bool IsValid { get; set; }
    }
}