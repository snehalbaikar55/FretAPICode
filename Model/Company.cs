using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Company
{
    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? CompanyCode { get; set; }

    public int CompanyTypeId { get; set; }

    public string? CompanyTypeName { get; set; }

    public int ParentCompanyId { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public int OfficeId { get; set; }

    public string? CompanyApprovalStatus { get; set; }

    public int? OwnerId { get; set; }

    public bool? CafReceived { get; set; }

    public DateTime? CafReceivedDate { get; set; }

    public string? CreditDays { get; set; }

    public string? MepzCode { get; set; }

    public string? Pannumber { get; set; }

    public int? GsttypeId { get; set; }

    public string? Gstin { get; set; }

    public string? Pan { get; set; }

    public int? PaymentTermId { get; set; }

    public string? PaymentTermLabel { get; set; }

    public string? GsttypeName { get; set; }

    public virtual ICollection<CompanyAddress> CompanyAddresses { get; } = new List<CompanyAddress>();

    public virtual ICollection<CompanyBankAccount> CompanyBankAccounts { get; } = new List<CompanyBankAccount>();

    public virtual ICollection<CompanyDocument1> CompanyDocument1s { get; } = new List<CompanyDocument1>();

    public virtual ICollection<CompanyDocument> CompanyDocuments { get; } = new List<CompanyDocument>();

    public virtual ICollection<CompanyPhone> CompanyPhones { get; } = new List<CompanyPhone>();

    public virtual CompanyType CompanyType { get; set; } = null!;

    public virtual ICollection<Contact> Contacts { get; } = new List<Contact>();

    public virtual ICollection<Opportunity> Opportunities { get; } = new List<Opportunity>();

    public virtual ICollection<UserMaster> UserMasters { get; } = new List<UserMaster>();

    public virtual ICollection<UserOfficeAccess> UserOfficeAccesses { get; } = new List<UserOfficeAccess>();
}
