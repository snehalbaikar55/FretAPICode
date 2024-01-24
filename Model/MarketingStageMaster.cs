using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class MarketingStageMaster
{
    public int MarketingStageId { get; set; }

    public string MarketingStageName { get; set; } = null!;

    public int CompanyTypeId { get; set; }

    public bool IsActive { get; set; }

    public int StageOrder { get; set; }

    public virtual ICollection<Lead> Leads { get; } = new List<Lead>();

    public virtual ICollection<Opportunity> Opportunities { get; } = new List<Opportunity>();
}
