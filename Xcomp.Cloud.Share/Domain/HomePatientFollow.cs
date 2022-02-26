using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class HomePatientFollow : BaseModel
    {
        public string Phone { get; set; }
        public List<string> PatientIds { get; set; }
    }
}
