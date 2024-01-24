using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class MarketingSourceMaster
{
    public int MarketingSourceId { get; set; }

    public string? MarketingSourceName { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Lead> Leads { get; } = new List<Lead>();
}
