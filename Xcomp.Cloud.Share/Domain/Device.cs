using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class Device : BaseModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string ProduceDate { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string HardwareVersion { get; set; }
        public string SoftwareVersion { get; set; }
        public string SellDate { get; set; }
        public string Price { get; set; }
        public Bed Bed { get; set; }
        public string FacultyId { get; set; }


    }
}
