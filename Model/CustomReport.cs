using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CustomReport
{
    public int ReportId { get; set; }

    public string? ReportName { get; set; }

    public string? ReportQuery { get; set; }

    public bool? IsActive { get; set; }

    public string? GridFormat { get; set; }
}
