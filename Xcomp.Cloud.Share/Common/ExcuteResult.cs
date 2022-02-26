﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Xcomp.Cloud.Share.Common
{

    public record ExcuteResult(bool Status = true, string ErrorMessage = "", dynamic Result = null);
    public record NotFoundRecordResult(string ErrorMessage = "Not found") : ExcuteResult(false, ErrorMessage, null);
    public record ExistRecordResult(string ErrorMessage = "Object was exist") : ExcuteResult(false, ErrorMessage, null);
    public record InvalidRecordResult(string ErrorMessage = "Invalid data") : ExcuteResult(false, ErrorMessage, null);
}
