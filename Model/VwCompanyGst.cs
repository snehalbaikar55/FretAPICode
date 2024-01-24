using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwCompanyGst
{
    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyTypeName { get; set; }

    public string? CompanyNameAddress { get; set; }

    public int CompanyAddressId { get; set; }

    public string? AddressTypeNick { get; set; }

    public string? FormattedAddress { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? StateName { get; set; }

    public string? StateCode { get; set; }

    public string Country { get; set; } = null!;

    public string? Gstnumber { get; set; }

    public string? Pannumber { get; set; }

    public string? CityName { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }
}
