using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwDetailsAddress
{
    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public int? CompanyAddressId { get; set; }

    public string? AddressTypeNick { get; set; }

    public string? FormattedAddress { get; set; }
}
