using Xcomp.Cloud.Core.Extentions;
using System.ComponentModel.DataAnnotations;
using Xcomp.Cloud.Core.Attributes.Web;
using Xcomp.Cloud.Core.Enums;
using Xcomp.Cloud.Core.Ultis;

namespace Xcomp.Cloud.Share.Models.EditModel
{
    public class FacultyEditModel : EditBaseModel
    {
        public string Id { get; set; }
        [Display(Name = "Tên khoa")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        public string Name { get; set; }
        //[Display(Name = "Cơ sở y tế trực thuộc")]
        //[Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        //public HospitalModel ParentId { get; set; }
        [Display(Name = "Quản trị viên")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        [Field(FieldType.Combobox)]
        public string ManagerId { get; set; }
        //[Display(Name = "Loại")]
        //public string Type { get; set; }
        [Display(Name = "Điện thoại")]
        public string Phone { get; set; }
        [Display(Name = "Mã hệ thống")]
        public string Code { get; set; }
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

        Property<FacultyEditModel> property = new Property<FacultyEditModel>();

        public FacultyEditModel(bool isEdit = true)
        {
            InputFields.Add<FacultyEditModel>(c => c.Name);
            //InputFields.Add<FacultyEditModel>(c => c.ParentId.Name);
            //InputFields.Add<FacultyEditModel>(c => c.Type);
            InputFields.Add<FacultyEditModel>(c => c.ManagerId);
            InputFields.Add<FacultyEditModel>(c => c.Phone);
            if (isEdit)
            {
                InputFields.Add<FacultyEditModel>(c => c.Code);
                InputFields.Add<FacultyEditModel>(c => c.CreatedAt);
                InputFields.Add<FacultyEditModel>(c => c.UpdatedAt);
                InputFields.Add<FacultyEditModel>(c => c.CreatedBy);
                InputFields.Add<FacultyEditModel>(c => c.UpdatedBy);

                DisableInputFields.Add<FacultyEditModel>(c => c.ManagerId);
                DisableInputFields.Add<FacultyEditModel>(c => c.Code);
                DisableInputFields.Add<FacultyEditModel>(c => c.CreatedAt);
                DisableInputFields.Add<FacultyEditModel>(c => c.UpdatedAt);
                DisableInputFields.Add<FacultyEditModel>(c => c.CreatedBy);
                DisableInputFields.Add<FacultyEditModel>(c => c.UpdatedBy);
            }
            DataSource.Add(property.Name(c => c.ManagerId), new Dictionary<string, Core.Data.ISelectItem>());
            //DisableInputFields.Add<FacultyEditModel>(c => c.ParentId.Name);
            //InputFields.Add<FacultyEditModel>(c => c.Status);
        }
    }
}
