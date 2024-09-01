using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    [Table("EmployeeMaster")]
    public class EmployeeMaster
    {
        [Key]
        public Guid EMPId { get; set; } = Guid.NewGuid();
        public string EMPFirstName { get; set; }
        public string EMPLastName { get; set; }
        public string EMPImage { get; set; }
        public DateTime EMPDob { get; set; }
        public string EMPPhone { get; set; } 
        public string EMPGender { get; set; }
        public string EMPQualification { get; set; }
        public string EMPCity { get; set; }
        public string EMPState { get; set; }
        public string EMPPincode { get; set; }
        public string EMPAddress { get; set; }
        public string EMPEmail { get; set; }
        public Guid CMPId { get; set; }
        public Guid DPTId { get; set;}        
        public DateTime EMPJoiningDate { get; set; }
        public bool EMPIsActive { get; set; }
        public DateTime EMPCreatedDate { get; set; }
        public DateTime EMPUpdateDate { get; set; }
        [ForeignKey("DPTId")]
        public virtual DepartmentMaster ?department { get; set; }

        [ForeignKey("CMPId")]
        public virtual CompanyMaster ?company { get; set; }
    }

    public class EmployeeDeleteMaster
    {
        public Guid EMPId { get; set; }
    }
}
