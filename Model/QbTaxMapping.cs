using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class QbTaxMapping
{
    public int? ComponentId { get; set; }

    public int? TaxCodeId { get; set; }

    public string? Name { get; set; }

    public decimal? TotalPercentage { get; set; }

    public decimal? Percentage { get; set; }

    public string? InvoiceTypeGst { get; set; }

    public string? QbtaxCodeId { get; set; }

    public string? QbtaxCodeName { get; set; }

    public string? QbtaxCodeDescription { get; set; }

    public string? QbtaxRateId { get; set; }

    public string? QbtaxRateName { get; set; }

    public int? SortOrder { get; set; }

    public decimal? TaxPercent { get; set; }

    public int? FretrackOfficeId { get; set; }

    public string? QbcompanyId { get; set; }
}
