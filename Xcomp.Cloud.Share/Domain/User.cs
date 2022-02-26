using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class User: BaseModel
    {
        public string Phone { get; set; }
        public string Code { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime? BirthOfDate { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsActive { get; set; }
        public string SmsOtpCode { get; set; }
        public DateTime? SmsOtpTime { get; set; }
        public AccountType AccountType { get; set; }
        public Role Role { get; set; }
        public List<Permission> Permissions { get; set; }
        public Hospital Hospital { get; set; }
        public Faculty Faculty { get; set; }
        public List<HospitalRole> HospitalRoles { get; set; }
    }

    public class DutyGroupUser
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
    }
}
