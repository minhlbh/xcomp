using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class RoleRequest: BaseModel
    {
        public HospitalRole HospitalRole { get; set; }
        public string CreatePhone { get; set; }
        public string CreateName { get; set; }
    }
}
