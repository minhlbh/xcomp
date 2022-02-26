
using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models.ViewModel
{
    public class RoomViewModel: ViewModelBase
    {
        [Display(Name = "Tên phòng")]
        public string Name { get; set; }
        [Display(Name = "Loại")]
        public string Type { get; set; }
    }
}
