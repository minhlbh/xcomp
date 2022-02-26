using Xcomp.Cloud.Share.Domain;
using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models
{
    public class RoleRequestModel: BaseModel
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public string CreatePhone { get; set; }
        public string CreateName { get; set; }
        public FacultyModel Faculty { get; set; }
    }

    public class CreateRoleRequestModel 
    {
        [Required]
        public CreateHopitalRoleModel HospitalRole { get; set; }
        [Required]
        public string UserId { get; set; }
    }

    public class UpdateRoleRequestModel
    {
        [Required]
        public string RoleRequestId { get; set; }
        [Required]
        [RegularExpression("Disabled|Allowed|Pending", ErrorMessage = "Chỉ được sử dụng 2 trạng thái 'Disabled' hoặc 'Allowed' hoặc 'Pending'")]
        public string FacultyActive { get; set; }
    }

    public class ActiveHospitalRoleModel
    {
        [Required]
        public string HospitalRoleId { get; set; }
        [Required]
        public string UserId { get; set; }
    }

    public class AcceptHospitalRoleModel
    {
        [Required]
        public string HospitalRoleId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        [RegularExpression("Disabled|Allowed|Pending", ErrorMessage = "Chỉ được sử dụng 2 trạng thái 'Disabled' hoặc 'Allowed' hoặc 'Pending'")]
        public string FacultyActive { get; set; }

    }

    public class UpdateHospitalRoleRequestModel
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string HospitalRoleId { get; set; }
        [Required]
        [RegularExpression("Disabled|Allowed|Pending", ErrorMessage = "Chỉ được sử dụng 2 trạng thái 'Disabled' hoặc 'Allowed' hoặc 'Pending'")]
        public string FacultyActive { get; set; }
        public string Note { get; set; }

    }

}
