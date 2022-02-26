using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class Role: BaseModel
    {
        public string Name { get; set; }
        public string Note { get; set; }
    }

    public class HospitalRole : Role
    {
        public Faculty Faculty { get; set; }
        public string FacultyActive { get; set; }
        public string Used { get; set; }
    }
}
