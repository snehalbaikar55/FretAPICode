using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwOpportunity
{
    public int OpportunityId { get; set; }

    public decimal? Amount { get; set; }

    public string OpportunityName { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public string? CargoType { get; set; }

    public string? Mode { get; set; }

    public string? CompanyName { get; set; }
}
