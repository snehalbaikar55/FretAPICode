using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwQbVendorBillLineItemsFinal
{
    public long? Id { get; set; }

    public long? LineNum { get; set; }

    public int? VendorBillId { get; set; }

    public string? ItemRefId { get; set; }

    public string? ItemRefValue { get; set; }

    public int Qty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? LineAmount { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? TaxPercent { get; set; }

    public string? QbtaxCodeId { get; set; }

    public string? ExpenseRefValue { get; set; }

    public string? ExpenseRefName { get; set; }

    public int SortCol { get; set; }

    public int? CompId { get; set; }

    public string? ChargeDescription { get; set; }
}
