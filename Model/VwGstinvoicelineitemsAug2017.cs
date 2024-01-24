using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwGstinvoicelineitemsAug2017
{
    public string? InvoiceNumber { get; set; }

    public string? JobNumber { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? ChargeDescription { get; set; }

    public string? ServiceCode { get; set; }

    public decimal? InvoiceAmount { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ExRate { get; set; }

    public decimal? TaxPercent { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Taxamount { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? CompanyName { get; set; }

    public string? InvoiceTypeGst { get; set; }
}
