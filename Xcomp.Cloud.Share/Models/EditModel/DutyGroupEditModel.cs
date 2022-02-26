using Xcomp.Cloud.Core.Extentions;
using System.ComponentModel.DataAnnotations;
using Xcomp.Cloud.Core.Ultis;
using Xcomp.Cloud.Core.Attributes.Web;
using Xcomp.Cloud.Core.Enums;
using Xcomp.Cloud.Share.Common;
using Xcomp.Cloud.Core.Data;

namespace Xcomp.Cloud.Share.Models.EditModel
{
    public class DutyGroupEditModel : EditBaseModel
    {
        public string Id { get; set; }
        [Display(Name = "Tên nhóm trực")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        public string Name { get; set; }
        [Display(Name = "Trạng thái")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        [Field(FieldType.Combobox)]
        public string WorkStatus { get; set; }
        [Display(Name = "Quản lý")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        [Field(FieldType.Combobox)]
        public string AdminId { get; set; }

        //[Display(Name = "Loại")]
        //public string Type { get; set; }
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
        public string FacultyId { get; set; }
        Property<DutyGroupEditModel> property = new();

        public DutyGroupEditModel(bool isEdit = true)
        {
            InputFields.Add<DutyGroupEditModel>(c => c.Name);
            InputFields.Add<DutyGroupEditModel>(c => c.WorkStatus);
            InputFields.Add<DutyGroupEditModel>(c => c.AdminId);

            InputFields.Add<DutyGroupEditModel>(c => c.Note);
            if (isEdit)
            {
                InputFields.Add<DutyGroupEditModel>(c => c.CreatedAt);
                InputFields.Add<DutyGroupEditModel>(c => c.UpdatedAt);
                InputFields.Add<DutyGroupEditModel>(c => c.CreatedBy);
                InputFields.Add<DutyGroupEditModel>(c => c.UpdatedBy);
                //InputFields.Add<DutyGroupEditModel>(c => c.Status);

                DisableInputFields.Add<DutyGroupEditModel>(c => c.AdminId);
                DisableInputFields.Add<DutyGroupEditModel>(c => c.CreatedAt);
                DisableInputFields.Add<DutyGroupEditModel>(c => c.UpdatedAt);
                DisableInputFields.Add<DutyGroupEditModel>(c => c.CreatedBy);
                DisableInputFields.Add<DutyGroupEditModel>(c => c.UpdatedBy);
                //DisableInputFields.Add<DutyGroupEditModel>(c => c.Status);
            }
            DataSource.Add(property.Name(c => WorkStatus),
                new Dictionary<string, ISelectItem>
                {
                    { DutyGroupWorkStatus.Active, new SelectItem(DutyGroupWorkStatus.Active, "Đang trực") },
                    { DutyGroupWorkStatus.Disabled, new SelectItem(DutyGroupWorkStatus.Disabled, "Nghỉ") }
                });
            DataSource.Add(property.Name(c => AdminId),
                new Dictionary<string, ISelectItem>());
        }
    }
}
