using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Share.Domain
{
    public class Note : BaseModel
    {
        public string CreateName { get; set; }
        public string Text { get; set; }
        public string File { get; set; }

    }
}
