using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class Call : BaseModel
    {
        public string Type { get; set; }
        public string CreateName { get; set; }
        public string Role { get; set; }

    }
}
