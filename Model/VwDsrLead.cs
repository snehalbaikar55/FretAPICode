using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwDsrLead
{
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? CompanyName { get; set; }

    public string? Type { get; set; }

    public string? ContactName { get; set; }

    public string? Title { get; set; }

    public string? Area { get; set; }

    public string? Purpose { get; set; }

    public string? Comments { get; set; }
}
