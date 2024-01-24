using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Lead
{
    public int LeadId { get; set; }

    public string? Salutation { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Title { get; set; }

    public string? Email { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public int? CountryId { get; set; }

    public int? StateId { get; set; }

    public int? CityId { get; set; }

    public string? CityName { get; set; }

    public string? Street { get; set; }

    public string? ZipCode { get; set; }

    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public int? IndustryId { get; set; }

    public int? EmployeeCount { get; set; }

    public int? LeadSourceId { get; set; }

    public int? LeadStatusId { get; set; }

    public int? LeadOwnerId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsCallingAllowed { get; set; }

    public string? Notes { get; set; }

    public DateTime? Followup1 { get; set; }

    public DateTime? Followup2 { get; set; }

    public DateTime? Followup3 { get; set; }

    public DateTime? ProfileSentOn { get; set; }

    public DateTime? Meeting1 { get; set; }

    public DateTime? Meeting2 { get; set; }

    public DateTime? Meeting3 { get; set; }

    public DateTime? EnquiryReceivedOn { get; set; }

    public string? ShipmentType { get; set; }

    public string? Sector { get; set; }

    public DateTime? QuoteSentOn { get; set; }

    public DateTime? RevQuoteSentOn { get; set; }

    public bool? Secured { get; set; }

    public int? AttendedBy { get; set; }

    public string? ResonNotSecured { get; set; }

    public virtual CountryMaster? Country { get; set; }

    public virtual IndustryMaster? Industry { get; set; }

    public virtual ICollection<LeadCampaign> LeadCampaigns { get; } = new List<LeadCampaign>();

    public virtual ICollection<LeadDocument> LeadDocuments { get; } = new List<LeadDocument>();

    public virtual UserMaster? LeadOwner { get; set; }

    public virtual MarketingSourceMaster? LeadSource { get; set; }

    public virtual MarketingStageMaster? LeadStatus { get; set; }

    public virtual ICollection<LeadTask> LeadTasks { get; } = new List<LeadTask>();
}
