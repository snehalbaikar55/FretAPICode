using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class LeadCampaign
{
    public int CampaignId { get; set; }

    public int LeadId { get; set; }

    public virtual Campaign Campaign { get; set; } = null!;

    public virtual Lead Lead { get; set; } = null!;
}
