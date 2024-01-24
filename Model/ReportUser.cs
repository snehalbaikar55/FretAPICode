using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class ReportUser
{
    public int? ReportId { get; set; }

    public int? UserId { get; set; }

    public int ReportAccessId { get; set; }
}
