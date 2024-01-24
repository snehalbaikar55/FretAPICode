using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwCompanyDetail
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

    public string? CompanyType { get; set; }

    public string? UserDisplayName { get; set; }

    public string? GstregType { get; set; }

    public string? PaymentTerm { get; set; }
}
