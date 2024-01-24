using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Opportunity
{
    public int OpportunityId { get; set; }

    public string OpportunityName { get; set; } = null!;

    public int? AccountId { get; set; }

    public string? AccountName { get; set; }

    public string? OpportunityType { get; set; }

    public int? OpportunityOwnerId { get; set; }

    public DateTime? DateClose { get; set; }

    public int? OpportunityStageId { get; set; }

    public byte? ProbabilityPercent { get; set; }

    public decimal? Amount { get; set; }

    public int? CurrencyId { get; set; }

    public string? NextStep { get; set; }

    public string? Description { get; set; }

    public int? PrimaryCampaignId { get; set; }

    public int? LeadSourceId { get; set; }

    public int? AssociatedLeadId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public string? ApprovalStatus { get; set; }

    public virtual Company? Account { get; set; }

    public virtual CurrencyMaster? Currency { get; set; }

    public virtual ICollection<OpportunityAttribute> OpportunityAttributes { get; } = new List<OpportunityAttribute>();

    public virtual ICollection<OpportunityCampaign> OpportunityCampaigns { get; } = new List<OpportunityCampaign>();

    public virtual ICollection<OpportunityDocument> OpportunityDocuments { get; } = new List<OpportunityDocument>();

    public virtual UserMaster? OpportunityOwner { get; set; }

    public virtual MarketingStageMaster? OpportunityStage { get; set; }

    public virtual ICollection<OpportunityTask> OpportunityTasks { get; } = new List<OpportunityTask>();
}
