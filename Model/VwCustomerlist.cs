using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwCustomerlist
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

    public Guid Rowguid { get; set; }

    public string? CityName { get; set; }

    public string? AddressTypeNick { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }
}
