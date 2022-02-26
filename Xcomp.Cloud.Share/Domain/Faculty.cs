using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class Faculty: BaseModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public Hospital Parent  { get; set; }
        public User Manager { get; set; }
    }
}
