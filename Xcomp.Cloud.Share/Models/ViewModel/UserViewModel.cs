
using System.ComponentModel.DataAnnotations;


namespace Xcomp.Cloud.Share.Models.ViewModel
{
    public class UserViewModel: ViewModelBase
    {
        [Display(Name = "Tài khoản/Số điện thoại")]
        public string Phone { get; set; }
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }
        [Display(Name = "Mã số y tế")]
        public string Code { get; set; }
        [Display(Name = "Vai trò")]
        public HospitalRoleModel Role { get; set; }
        [Display(Name = "Trạng thái")]
        public bool IsActive { get; set; }
        
    }
}
