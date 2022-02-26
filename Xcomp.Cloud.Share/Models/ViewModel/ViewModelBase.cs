
using System.ComponentModel.DataAnnotations;


namespace Xcomp.Cloud.Share.Models.ViewModel
{
    public class ViewModelBase
    {
        [Display(Name = "Stt")]
        public int Stt { get; set; }
        [Display(Name = "Mã")]
        public string Id { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Ngày sửa")]
        public DateTime UpdatedAt { get; set; }
        [Display(Name = "Tạo bởi")]
        public string CreatedBy { get; set; }
        [Display(Name = "Chỉnh sửa bởi")]
        public string UpdatedBy { get; set; }
        [Display(Name = "Trạng thái")]
        public string Status { get; set; }
    }
}
