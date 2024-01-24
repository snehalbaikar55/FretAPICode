using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CustomerAddress
{
    public string? CompanyName { get; set; }

    public int? CompanyId { get; set; }

    public string? AddressTypeNick { get; set; }

    public string? FormattedAddress { get; set; }

    public int CompanyAddressId { get; set; }
}
