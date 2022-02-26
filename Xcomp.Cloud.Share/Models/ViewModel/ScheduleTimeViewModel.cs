
using System.ComponentModel.DataAnnotations;


namespace Xcomp.Cloud.Share.Models.ViewModel
{
    public class ScheduleTimeViewModel : ViewModelBase
    {
        [Display(Name = "Tên lịch trực")]
        public string Name { get; set; }
        [Display(Name = "Thời gian bắt đầu")]
        public DateTime? StartTime { get; set; }
        [Display(Name = "Thời gian kết thúc")]
        public DateTime? EndTime { get; set; }
        [Display(Name = "Trạng thái")]
        public string WorkStatus { get; set; }
    }
}
