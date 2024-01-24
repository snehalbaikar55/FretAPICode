using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwAccountsGstMain
{
    public string InvoiceNo { get; set; } = null!;

    public string? JobNumber { get; set; }

    public string? CustomerName { get; set; }

    public string? Gstin { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public decimal? InvoiceValue { get; set; }

    public decimal? TaxableValue { get; set; }

    public decimal? TaxRate { get; set; }

    public decimal? Igst { get; set; }

    public decimal? CentralTax { get; set; }

    public decimal? StateTax { get; set; }

    public string? StateOfSupply { get; set; }

    public string? StateName { get; set; }

    public string? Irn { get; set; }
}
