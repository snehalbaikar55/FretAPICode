using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class WebReportAccess
{
    public int WebReportAccessId { get; set; }

    public int WebReportId { get; set; }

    public int WebUserId { get; set; }

    public virtual WebReportMaster WebReport { get; set; } = null!;
}
