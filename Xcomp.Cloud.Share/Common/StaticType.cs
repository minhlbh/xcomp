
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Share.Common
{

    public static class RoleType
    {
        public const string SuperAdmin = "SuperAdmin";
        public const string Admin = "Admin";
        public const string HospitalAdmin = "HospitalAdmin";
        public const string Doctor = "Doctor";
        public const string Nurse = "Nurse";
        public const string NurseStaff = "NurseStaff";
        public const string NormalUser = "NormalUser";
        public static List<Role> Roles = new List<Role>
        {
            new Role { Name = RoleType.SuperAdmin, Note = "Super admin" },
            new Role { Name = RoleType.Admin, Note = "Admin" },
            new Role { Name = RoleType.HospitalAdmin, Note = "Quản trị bệnh viện" },
            new Role { Name = RoleType.Doctor, Note = "Bác sĩ" },
            new Role { Name = RoleType.Nurse, Note = "Y tá" },
            new Role { Name = RoleType.NurseStaff, Note = "Điều dưỡng" },
            new Role { Name = RoleType.NormalUser, Note = "Người dùng" }
        };
    }

    public static class RoleTypeState
    {
        public const string Disabled = "Disabled";
        public const string Allowed = "Allowed";
        public const string Pendding = "Pendding";

    }

    public static class DutyGroupWorkStatus
    {
        public const string Active = "Active";
        public const string Disabled = "Disabled";
    }

    public static class RoomType
    {
        public const string Normal = "Normal";
        public const string Operating = "Operating";
    }

}
