using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class TaxComponent
{
    public int TaxComponentId { get; set; }

    public int TaxRateId { get; set; }

    public string? ComponentName { get; set; }

    public decimal? ComponentPercent { get; set; }

    public string? InvoiceType { get; set; }
}
