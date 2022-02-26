using Xcomp.Cloud.Core.Extentions;
using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models.EditModel
{
    public class BedEditModel : EditBaseModel
    {
        public string Id { get; set; }
        [Display(Name = "Tên giường")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        public string Name { get; set; }
        public RoomModel RoomParent { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Ngày sửa")]
        public DateTime UpdatedAt { get; set; }
        [Display(Name = "Tạo bởi")]
        public string CreatedBy { get; set; }
        [Display(Name = "Chỉnh sửa bởi")]
        public string UpdatedBy { get; set; }

        public BedEditModel(bool isEdit = true)
        {
            InputFields.Add<BedEditModel>(c => c.Name);
            if (isEdit)
            {
                InputFields.Add<BedEditModel>(c => c.CreatedAt);
                InputFields.Add<BedEditModel>(c => c.UpdatedAt);
                InputFields.Add<BedEditModel>(c => c.CreatedBy);
                InputFields.Add<BedEditModel>(c => c.UpdatedBy);

                DisableInputFields.Add<BedEditModel>(c => c.CreatedAt);
                DisableInputFields.Add<BedEditModel>(c => c.UpdatedAt);
                DisableInputFields.Add<BedEditModel>(c => c.CreatedBy);
                DisableInputFields.Add<BedEditModel>(c => c.UpdatedBy);
            }
        }
    }
}
