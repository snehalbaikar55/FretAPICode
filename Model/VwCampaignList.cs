using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwCampaignList
{
    public int CampaignId { get; set; }

    public string? CampaignName { get; set; }

    public string? CampaignDescription { get; set; }

    public string? UserName { get; set; }

    public string? CampaignStatus { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int CampaignOwnerId { get; set; }
}
