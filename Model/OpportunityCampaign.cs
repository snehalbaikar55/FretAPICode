using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class OpportunityCampaign
{
    public int CampaignId { get; set; }

    public int OpportunityId { get; set; }

    public virtual Campaign Campaign { get; set; } = null!;

    public virtual Opportunity Opportunity { get; set; } = null!;
}
