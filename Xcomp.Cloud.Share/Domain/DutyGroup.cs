using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class DutyGroup : BaseModel
    {
        public string Name { get; set; }
        public string WorkStatus { get; set; }
        public List<DutyGroupUser> Users { get; set; }
        public List<ScheduleTime> ScheduleTimes { get; set; }
        public string HospitalId { get; set; }
        public string FacultyId { get; set; }
        public User AdminUser { get; set; }
        public string Note { get; set; }
    }

    public class ScheduleTime : BaseModel
    {
        public string Name { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string WorkStatus { get; set; }
        public List<DutyGroupRoom> Rooms { get; set; }
        public List<DayOfWeek> TableTime { get; set; }
    }
}
