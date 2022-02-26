using Xcomp.Cloud.Share.Domain;
using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models
{
    public class DutyGroupModel: BaseModel
    {
        public string Name { get; set; }
        public string WorkStatus { get; set; }
        public UserModel AdminUser { get; set; }
        public string Note { get; set; }
        public string FacultyId { get; set; }
    }

    public class CreateDutyGroupModel 
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string FacultyId { get; set; }
        [Required]
        public string AdminId { get; set; }
        [RegularExpression("Active|Disabled", ErrorMessage = "Chỉ được sử dụng 2 trạng thái 'Active' hoặc 'Disabled'")]
        public string WorkStatus { get; set; }
        public string Note { get; set; }
    }

    public class UpdateDutyGroupModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string WorkStatus { get; set; }
        public string Note { get; set; }

    }

    public class AddRoomDutyGroupModel
    {
        [Required]
        public string DutyGroupId { get; set; }
        [Required]
        public string ScheduleTimeId { get; set; }
        [Required]
        public string RoomId { get; set; }
    }

    public class AddUserDutyGroupModel
    {
        [Required]
        public string DutyGroupId { get; set; }
        [Required]
        public string UserId { get; set; }
    }

    public class UpdateAdminDutyGroupModel
    {
        [Required]
        public string DutyGroupId { get; set; }
        [Required]
        public string UserId { get; set; }
    }

    public class ScheduleTimeModel : BaseModel
    {
        public string ScheduleTimeId { get; set; }
        public string Name { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string WorkStatus { get; set; }
        public List<DayOfWeek> TableTime { get; set; }
    }

    public class ScheduleTimeWithDutyInfoModel : BaseModel
    {
        public string DutyGroupId { get; set; }
        public string DutyGroupName { get; set; }
        public string Name { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string WorkStatus { get; set; }
        public List<DayOfWeek> TableTime { get; set; }
    }

    public class QueryScheduleTimeModel
    {
        [Required]
        public string DutyGroupId { get; set; }
        [Required]
        public string ScheduleTimeId { get; set; }
    }

    public class CreateScheduleTimeModel
    {
        [Required]
        public string DutyGroupId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression("Active|Disabled", ErrorMessage = "Chỉ được sử dụng 2 trạng thái 'Active' hoặc 'Disabled'")]
        public string WorkStatus { get; set; }
    }

    public class UpdateScheduleTimeModel
    {
        [Required]
        public string DutyGroupId { get; set; }
        [Required]
        public string ScheduleTimeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression("Active|Disabled", ErrorMessage = "Chỉ được sử dụng 2 trạng thái 'Active' hoặc 'Disabled'")]
        public string WorkStatus { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public List<DayOfWeek> TableTime { get; set; }
    }

    public class DeleteScheduleTimeModel
    {
        [Required]
        public string DutyGroupId { get; set; }
        [Required]
        public string ScheduleTimeId { get; set; }
    }
}
