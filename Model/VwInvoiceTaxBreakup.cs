using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwInvoiceTaxBreakup
{
    public string InvoiceNumber { get; set; } = null!;

    public int InvoiceId { get; set; }

    public string GstTaxCode { get; set; } = null!;

    public string? CurrencyCode { get; set; }

    public decimal? TaxableAmount { get; set; }

    public decimal? GstRate { get; set; }

    public decimal? GstAmount { get; set; }
}
