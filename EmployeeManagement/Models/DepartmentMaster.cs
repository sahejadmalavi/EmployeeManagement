using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    [Table("DepartmentMaster")]
    public class DepartmentMaster
    {
        [Key]
        public Guid DPTId { get; set; } = Guid.NewGuid();
        public string DPTName { get; set; }
        public bool DPTIsActive { get; set; }
        public DateTime DPTCreatedDate { get; set; }
        public DateTime DPTUpdatedDate { get; set; }
    }
    public class DepartmentDeleteMaster
    {
        public Guid DPTId { get; set; } = Guid.NewGuid();
    }
}
