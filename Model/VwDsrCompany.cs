using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwDsrCompany
{
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? CompanyName { get; set; }

    public string? Type { get; set; }

    public string? ContactName { get; set; }

    public string? Designation { get; set; }

    public string? Area { get; set; }

    public string? Comments { get; set; }

    public string? Purpose { get; set; }
}
