using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class TaxRate
{
    public int TaxRateId { get; set; }

    public int TaxId { get; set; }

    public string? TaxName { get; set; }

    public string? TaxCode { get; set; }

    public decimal? EffectiveTaxPercentage { get; set; }

    public DateTime? EffectiveFrom { get; set; }
}
