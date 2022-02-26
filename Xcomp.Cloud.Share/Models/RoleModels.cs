using Xcomp.Cloud.Share.Domain;
using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models
{
    public class RoleModel : BaseModel
    {
        public string Name { get; set; }
        public string Note { get; set; }
    }

    public class HospitalRoleModel : RoleModel
    {
        public BasicFacultyModel Faculty { get; set; }
        public string FacultyActive { get; set; }
        public string Used { get; set; }
    }

    public class CreateHopitalRoleModel
    {
        [Required]
        public string FacultyId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Note { get; set; }
        [RegularExpression("Disabled|Allowed", ErrorMessage = "Chỉ được sử dụng 2 trạng thái 'Disabled' hoặc 'Allowed'")]
        public string Used { get; set; }
    }

    public class UpdateHospitalRoleModel
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string HospitalRoleId { get; set; }
        [Required]
        [RegularExpression("Disabled|Allowed|Pending", ErrorMessage = "Chỉ được sử dụng 2 trạng thái 'Disabled' hoặc 'Allowed' hoặc 'Pending'")]
        public string Used { get; set; }
        public string Note { get; set; }

    }

}
