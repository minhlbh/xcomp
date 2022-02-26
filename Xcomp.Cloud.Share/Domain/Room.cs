using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class Room: BaseModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public Faculty FacultyParent { get; set; }
    }

    public class DutyGroupRoom
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
