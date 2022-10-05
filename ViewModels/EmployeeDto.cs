namespace FinalProjectAPI.ViewModels
{
    public class EmployeeDto
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public string Manager { get; set; }

        public string Wfm_Manager { get; set; }
        public string Email { get; set; }
        public int Experience { get; set; }

        public List<string> Skills { get; set; }
    }
}
