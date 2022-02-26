using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models.ViewModel
{
    public class BedViewModel: ViewModelBase
    {
        [Display(Name = "Tên giường")]
        public string Name { get; set; }
        [Display(Name = "Loại")]
        public string Type { get; set; }
    }
}
