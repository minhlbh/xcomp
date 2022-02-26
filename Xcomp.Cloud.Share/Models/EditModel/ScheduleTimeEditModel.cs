using Xcomp.Cloud.Core.Extentions;
using System.ComponentModel.DataAnnotations;
using Xcomp.Cloud.Core.Attributes.Web;
using Xcomp.Cloud.Core.Enums;
using Xcomp.Cloud.Core.Ultis;
using Xcomp.Cloud.Core.Data;
using Xcomp.Cloud.Share.Common;

namespace Xcomp.Cloud.Share.Models.EditModel
{
    public class ScheduleTimeEditModel: EditBaseModel
{
        public string ScheduleTimeId { get; set; }
        [Display(Name = "Tên lịch trực")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        public string Name { get; set; }
        public string DutyGroupId { get; set; }
        [Display(Name = "Trạng thái")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        [Field(FieldType.Combobox)]
        public string WorkStatus { get; set; }

        [Display(Name = "Thời gian bắt đầu")]
        [Field(FieldType.TimePicker)]
        public DateTime? StartTime { get; set; }
        [Display(Name = "Thời gian kết thúc")]
        [Field(FieldType.TimePicker)]
        public DateTime? EndTime { get; set; }
        [Display(Name = "Ngày trực")]
        [Field(FieldType.CheckBoxGroup)]
        public List<DayOfWeek> TableTime { get; set; }

        [Display(Name = "Ngày tạo")]
        [Field(FieldType.DateTimeFull)]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Ngày sửa")]
        [Field(FieldType.DateTimeFull)]
        public DateTime UpdatedAt { get; set; }
        [Display(Name = "Tạo bởi")]
        public string CreatedBy { get; set; }
        [Display(Name = "Chỉnh sửa bởi")]
        public string UpdatedBy { get; set; }
        Property<ScheduleTimeEditModel> property = new();

        public ScheduleTimeEditModel(bool isEdit = true)
        {
            InputFields.Add<ScheduleTimeEditModel>(c => c.Name);
            InputFields.Add<ScheduleTimeEditModel>(c => c.WorkStatus);
            if (isEdit)
            {
                InputFields.Add<ScheduleTimeEditModel>(c => c.StartTime);
                InputFields.Add<ScheduleTimeEditModel>(c => c.EndTime);
                InputFields.Add<ScheduleTimeEditModel, List<DayOfWeek>>(c => c.TableTime);
                InputFields.Add<ScheduleTimeEditModel>(c => c.CreatedAt);
                InputFields.Add<ScheduleTimeEditModel>(c => c.UpdatedAt);
                InputFields.Add<ScheduleTimeEditModel>(c => c.CreatedBy);
                InputFields.Add<ScheduleTimeEditModel>(c => c.UpdatedBy);

                DisableInputFields.Add<ScheduleTimeEditModel>(c => c.CreatedAt);
                DisableInputFields.Add<ScheduleTimeEditModel>(c => c.UpdatedAt);
                DisableInputFields.Add<ScheduleTimeEditModel>(c => c.CreatedBy);
                DisableInputFields.Add<ScheduleTimeEditModel>(c => c.UpdatedBy);
            }
            DataSource.Add(property.Name(c => WorkStatus),
                new Dictionary<string, ISelectItem>
                {
                    { DutyGroupWorkStatus.Active, new SelectItem(DutyGroupWorkStatus.Active, "Sử dụng") },
                    { DutyGroupWorkStatus.Disabled, new SelectItem(DutyGroupWorkStatus.Disabled, "Ngừng") }
                });
        }
    }
}
