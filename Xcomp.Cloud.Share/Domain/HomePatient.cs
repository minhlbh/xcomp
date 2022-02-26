using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class HomePatient : BaseModel
    {
        public string Name { get; set; }
        public string PID { get; set; }
        public string Avatar { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AccessCode { get; set; }
        public List<Note> Notes { get; set; }
        public List<Message> Messages { get; set; }
        public List<Call> Calls { get; set; }
        public List<PatientRelative> PatientRelatives { get; set; }
        public Device Device { get; set; }
        public string UserId { get; set; }

    }

}
