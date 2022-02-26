using Xcomp.Cloud.Core.Extentions;
using System.ComponentModel.DataAnnotations;
using Xcomp.Cloud.Core.Ultis;
using Xcomp.Cloud.Core.Attributes.Web;
using Xcomp.Cloud.Core.Enums;
using Xcomp.Cloud.Share.Common;
using Xcomp.Cloud.Core.Data;

namespace Xcomp.Cloud.Share.Models.EditModel
{
    public class RoomEditModel : EditBaseModel
    {
        public string Id { get; set; }
        [Display(Name = "Tên phòng")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        public string Name { get; set; }
        [Display(Name = "Khoa trực thuộc")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        public string FacultyParentId { get; set; }

        [Field(Type = FieldType.Combobox)]
        [Display(Name = "Loại phòng")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        public string Type { get; set; }

        [Display(Name = "Ghi chú")]
        public string Note { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Ngày sửa")]
        public DateTime UpdatedAt { get; set; }
        [Display(Name = "Tạo bởi")]
        public string CreatedBy { get; set; }
        [Display(Name = "Chỉnh sửa bởi")]
        public string UpdatedBy { get; set; }
        //[Display(Name = "Trạng thái")]
        //public string Status { get; set; }
        Property<RoomEditModel> Property { get; set; } = new Property<RoomEditModel>();

        public RoomEditModel(bool isEdit = true)
        {
            InputFields.Add<RoomEditModel>(c => c.Name);
            //InputFields.Add<RoomEditModel>(c => c.FacultyParentId);
            InputFields.Add<RoomEditModel>(c => c.Type);
            InputFields.Add<RoomEditModel>(c => c.Note);
            if (isEdit)
            {
                InputFields.Add<RoomEditModel>(c => c.CreatedAt);
                InputFields.Add<RoomEditModel>(c => c.UpdatedAt);
                InputFields.Add<RoomEditModel>(c => c.CreatedBy);
                InputFields.Add<RoomEditModel>(c => c.UpdatedBy);
                //InputFields.Add<RoomEditModel>(c => c.Status);

                DisableInputFields.Add<RoomEditModel>(c => c.CreatedAt);
                DisableInputFields.Add<RoomEditModel>(c => c.UpdatedAt);
                DisableInputFields.Add<RoomEditModel>(c => c.CreatedBy);
                DisableInputFields.Add<RoomEditModel>(c => c.UpdatedBy);
                //DisableInputFields.Add<RoomEditModel>(c => c.Status);
            }
            DataSource.Add(Property.Name(c => c.Type), new Dictionary<string, ISelectItem>
            {
                [RoomType.Normal] = new SelectItem(RoomType.Normal, "Phòng bệnh"),
                [RoomType.Operating] = new SelectItem(RoomType.Operating, "Phòng mổ"),

            });
        }
    }
}
