using System;
using System.Collections.Generic;
using System.Text;

namespace Xcomp.Cloud.Core.AuditLog
{
    public struct LogMessage
    {
        public DateTimeOffset Timestamp { get; set; }
        public string Message { get; set; }
    }
}
