using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    [Table("CompanyMaster")]
    public class CompanyMaster
    {
        [Key]
        public Guid CMPId { get; set; } = Guid.NewGuid();
        public string CMPName { get; set; }
        public bool CMPIsActive { get; set; }
        public DateTime CMPCreatedDate { get; set; }
        public DateTime CMPUpdatedDate { get; set; }
    }
    public class CompanyDeleteMaster
    {
        public Guid CMPId { get; set; }
    }

    public class CompanyMasterCreate
    {
        [Key]
        public Guid CMPId { get; set; }
        public string CMPName { get; set; }
        public bool CMPIsActive { get; set; }
        public string dptid { get; set; }
        public DateTime CMPCreatedDate { get; set; }
        public DateTime CMPUpdatedDate { get; set; }
    }

    [Table("DepartmentMappingMaster")]
    public class DepartmentMappingMaster {
        [Key]
        public Guid DMPId { get; set; } = Guid.NewGuid();
        public Guid CMPId { get; set; }
        public Guid DPTId { get; set; } 
    }

}
