using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CampaignTypeMaster
{
    public int CampaignTypeId { get; set; }

    public string CampaignTypeName { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<Campaign> Campaigns { get; } = new List<Campaign>();
}
