using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwQbVendorBillTaxFinal
{
    public int VendorBillId { get; set; }

    public string? TaxLineName { get; set; }

    public decimal? TaxLinePercent { get; set; }

    public decimal? TaxableLineAmount { get; set; }

    public decimal? TaxAmount { get; set; }

    public string? VendorBillTypeGst { get; set; }

    public int? SortOrder { get; set; }

    public string? QbtaxCodeId { get; set; }

    public string? QbtaxCodeName { get; set; }

    public string? QbtaxRateId { get; set; }

    public string? QbtaxRateName { get; set; }

    public decimal? InvoiceLinePercent { get; set; }

    public int? CompId { get; set; }
}
