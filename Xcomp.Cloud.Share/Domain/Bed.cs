using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class Bed: BaseModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Room RoomParent { get; set; }
    }
}
