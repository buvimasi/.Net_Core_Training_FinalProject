namespace FinalProjectAPI.ViewModels
{
    public class SoftLockDto
    {
        public int LockId { get; set; }
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }
        public string Manager { get; set; }
        public string RequestMessage { get; set; }
        public string ManagerStatus { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
