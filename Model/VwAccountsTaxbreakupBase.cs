using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwAccountsTaxbreakupBase
{
    public string InvoiceNumber { get; set; } = null!;

    public string? Taxgroup { get; set; }

    public decimal? Taxamt { get; set; }

    public decimal? Taxable { get; set; }

    public decimal? Nontaxable { get; set; }

    public int? TaxId { get; set; }

    public decimal? TaxPercent { get; set; }

    public string? ComponentName { get; set; }

    public decimal? ComponentPercent { get; set; }
}
