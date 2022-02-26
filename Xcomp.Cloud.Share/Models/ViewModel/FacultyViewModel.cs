
using System.ComponentModel.DataAnnotations;


namespace Xcomp.Cloud.Share.Models.ViewModel
{
    public class FacultyViewModel: ViewModelBase
    {
        [Display(Name = "Tên khoa")]
        public string Name { get; set; }
        [Display(Name = "Điện thoại")]
        public string Phone { get; set; }
        [Display(Name = "Mã truy cập")]
        public string Code { get; set; }
        [Display(Name = "Người quản lý")]
        public string ManagerName { get; set; }
    }
}
