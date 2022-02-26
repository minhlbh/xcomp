using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class Patient : BaseModel
    {
        public string Name { get; set; }
        public string PID { get; set; }
        public string Avatar { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string HospitalId { get; set; }
        public string Room { get; set; }
        public string AccessCode { get; set; }
        public List<Note> Notes { get; set; }
        public List<Message> Messages { get; set; }
        public List<Call> Calls { get; set; }
        public Bed Bed { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<PatientRelative> PatientRelatives { get; set; }
        public string FacultyId { get; set; }
        public DateTime LastCall { get; set; }
        public int WaitCallCount { get; set; }


    }

    public class Doctor : BaseModel
    {
        public string Phone { get; set; }
        public string FullName { get; set; }
    }
}
