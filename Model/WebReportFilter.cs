using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class WebReportFilter
{
    public int WebReportFilterId { get; set; }

    public int WebReportId { get; set; }

    public string ReportColumnName { get; set; } = null!;

    public string ReportColumnType { get; set; } = null!;

    public bool IsRequired { get; set; }

    public int MaxRange { get; set; }

    public virtual WebReportMaster WebReport { get; set; } = null!;
}
