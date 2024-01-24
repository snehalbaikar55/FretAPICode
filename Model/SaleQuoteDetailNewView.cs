using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class SaleQuoteDetailNewView
{
    public int? CarrierId { get; set; }

    public string? OceanLineCode { get; set; }

    public int? Polid { get; set; }

    public string? LocationShortName { get; set; }

    public int? Podid { get; set; }

    public string? IncoTerm { get; set; }

    public string? Notes { get; set; }

    public int SortOrder { get; set; }

    public string? TransitTime { get; set; }
}
