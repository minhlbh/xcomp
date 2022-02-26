using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class DeviceFollow : BaseModel
    {
        public string Phone { get; set; }
        public List<string> DeviceIds { get; set; }
    }
}
