using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwCustomerOwnerList
{
    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? UserDisplayName { get; set; }

    public int? PrimaryOfficeId { get; set; }
}
