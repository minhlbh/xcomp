using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class DeviceOfUser : BaseModel
    {
        public string Phone { get; set; }
        public Device Device { get; set; }

    }
}
