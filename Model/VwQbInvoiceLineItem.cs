using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwQbInvoiceLineItem
{
    public long? Id { get; set; }

    public long? LineNum { get; set; }

    public int? InvoiceId { get; set; }

    public string? ItemRefId { get; set; }

    public string? ItemRefValue { get; set; }

    public int Qty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? LineAmount { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? TaxPercent { get; set; }

    public string? QbtaxCodeId { get; set; }

    public string? IncomeAccountRefValue { get; set; }

    public string? IncomeAccountRefName { get; set; }

    public int SortCol { get; set; }
}
