using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class PatientRelative: BaseModel
    {
        public string Phone { get; set; }
        public string FullName { get; set; }
        public string Relationship { get; set; }

    }
}
