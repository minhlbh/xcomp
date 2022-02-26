using Xcomp.Cloud.Share.Domain;
using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models
{
    public class UserModel : BaseModel
    {
        public string Phone { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public DateTime? BirthOfDate { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public bool IsActive { get; set; }
        public string HospitalId { get; set; }
        public HospitalModel Hospital { get; set; }
        public HospitalRoleModel Role { get; set; }
        public List<HospitalRoleModel> HospitalRoles { get; set; }
    }

    public class InvitedUserByFacultyModel : BaseModel
    {
        public string Phone { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public bool IsActive { get; set; }
        public HospitalRoleModel HospitalRole { get; set; }
    }

    public class CreateUserModel
    {
        [Required]
        [RegularExpression("0[0-9]{9}", ErrorMessage = "Phone is invalid")]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string HospitalId { get; set; }
        public DateTime? BirthOfDate { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
    }

    public class CreateCloudUserModel
    {
        [Required]
        [RegularExpression("0[0-9]{9}", ErrorMessage = "Phone is invalid")]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FullName { get; set; }
        public DateTime? BirthOfDate { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
    }

    public class UpdateUserModel
    {
        [Required]
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime? BirthOfDate { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string RoleName { get; set; }
        public string FalculyId { get; set; }
    }

    public class LoginUserModel
    {
        [Required]
        [RegularExpression("0[0-9]{9}", ErrorMessage = "Phone is invalid")]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
    }

    public class ActiveUserModel
    {
        [Required]
        [RegularExpression("0[0-9]{9}", ErrorMessage = "Phone is invalid")]
        public string Phone { get; set; }
        [Required]
        public string ActiveCode { get; set; }
    }

    public class ChangePasswordUserModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string OldPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
    }

    public class ResetPasswordUserModel
    {
        [Required]
        [RegularExpression("0[0-9]{9}", ErrorMessage = "Phone is invalid")]
        public string Phone { get; set; }
        [Required]
        public string OtpCode { get; set; }
        [Required]
        public string NewPassword { get; set; }
    }

    public class SendSmsOtpModel
    {
        [Required]
        [RegularExpression("0[0-9]{9}", ErrorMessage = "Phone is invalid")]
        public string Phone { get; set; }
    }

    public class AssignUserToHospitalModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string HospitalId { get; set; }
    }

}
