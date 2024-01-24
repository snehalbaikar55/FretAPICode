using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Campaign
{
    public int CampaignId { get; set; }

    public string? CampaignName { get; set; }

    public bool? IsActive { get; set; }

    public int? ParentCampaignId { get; set; }

    public int CampaignTypeId { get; set; }

    public string? CampaignDescription { get; set; }

    public int CampaignOwnerId { get; set; }

    public string? CampaignStatus { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? ImpressionsTargetted { get; set; }

    public int? ImpressionsRecieved { get; set; }

    public decimal? ExpectedResponse { get; set; }

    public decimal? ActualResponse { get; set; }

    public decimal? BudgetedCost { get; set; }

    public decimal? ActualCost { get; set; }

    public decimal? ExpectedRevenue { get; set; }

    public int? CurrencyId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual UserMaster CampaignOwner { get; set; } = null!;

    public virtual CampaignTypeMaster CampaignType { get; set; } = null!;

    public virtual LeadCampaign? LeadCampaign { get; set; }

    public virtual OpportunityCampaign? OpportunityCampaign { get; set; }
}
