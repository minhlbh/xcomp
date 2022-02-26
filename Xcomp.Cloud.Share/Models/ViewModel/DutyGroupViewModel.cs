
using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models.ViewModel
{
    public class DutyGroupViewModel: ViewModelBase
    {
        [Display(Name = "Tên nhóm")]
        public string Name { get; set; }
        [Display(Name = "Trạng thái")]
        public string WorkStatus { get; set; }
        [Display(Name = "Quản trị viên")]
        public UserModel AdminUser { get; set; }
    }
}
