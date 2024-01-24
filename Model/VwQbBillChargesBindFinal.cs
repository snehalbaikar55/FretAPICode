using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwQbBillChargesBindFinal
{
    public int? VendorBillId { get; set; }

    public string? QbChargeName { get; set; }

    public string? ServiceCode { get; set; }

    public string? ChargeDescription { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ExRate { get; set; }

    public decimal? ExpectedAmount { get; set; }

    public decimal? LineAmount { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? TaxPercent { get; set; }

    public int? ExpenseAccountHeadId { get; set; }

    public int? ChargeHeadId { get; set; }

    public string? ChargeHeadName { get; set; }

    public string? QbChargeId { get; set; }

    public string? ExpenseRefId { get; set; }

    public string? ExpenseRefName { get; set; }

    public int SortCol { get; set; }

    public int? CompId { get; set; }

    public int? Cmid { get; set; }
}
