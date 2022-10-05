using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProjectAPI.Entities
{
    public class Employees
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("employee_Id")]
        public int EmployeeID { get; set; }
        [Column("name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Column("status")]
        [Required]
        [MaxLength(50)]
        public string Status { get; set; }
        [Column("manager")]
        [MaxLength(30)]
        public string Manager { get; set; }
        [Column("wfm_manager")]
        [MaxLength(30)]
        public string Wfm_Manager { get; set; }
        [Column("email"), DataType("nvarchar")]
        public string Email { get; set; }
        [Column("lockstatus")]
        [MaxLength(30)]
        public string LockStatus { get; set; }
        public int Experience { get; set; }
        [Column("profile_Id")]
        public int ProfileId { get; set; }

        public ICollection<SkillMap> SkillMaps { get; set; }
        public ICollection<SoftLock> SoftLocks { get; set; }
    }
}
