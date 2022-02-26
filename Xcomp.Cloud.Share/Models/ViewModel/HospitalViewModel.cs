using System.ComponentModel.DataAnnotations;


namespace Xcomp.Cloud.Share.Models.ViewModel
{
    public class HospitalViewModel: ViewModelBase
    {
        [Display(Name = "Tên cơ sở y tế")]
        public string Name { get; set; }
        [Display(Name = "Ảnh")]
        public string Logo { get; set; }
        [Display(Name = "Domain/Ip")]
        public string Domain { get; set; }
        [Display(Name = "Lan Domain/Ip")]
        public string LocalDomain { get; set; }
    }
}
