using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class Hospital : BaseModel
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public string GPS { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public string Domain { get; set; }
        public string LocalDomain { get; set; }

    }
}
