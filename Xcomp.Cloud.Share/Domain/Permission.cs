using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class Permission: BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
