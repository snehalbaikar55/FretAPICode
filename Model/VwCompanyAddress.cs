using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwCompanyAddress
{
    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public int CompanyAddressId { get; set; }

    public string? AddressTypeNick { get; set; }

    public string? FormattedAddress { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public int CompanyTypeId { get; set; }

    public string? Gstnumber { get; set; }
}
