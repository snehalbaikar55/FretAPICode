using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwQbTdsline
{
    public int VendorBillId { get; set; }

    public string Chg { get; set; } = null!;

    public string ServiceCode { get; set; } = null!;

    public string? ChargeDescription { get; set; }

    public int Quantity { get; set; }

    public decimal? Rate { get; set; }

    public int ExRate { get; set; }

    public decimal? ExpectedAmount { get; set; }

    public decimal? LineAmount { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public int TaxPercent { get; set; }

    public int ExpenseAccountHeadId { get; set; }

    public int ChargeHeadId { get; set; }

    public string ChargeHeadName { get; set; } = null!;

    public string QbChargeId { get; set; } = null!;

    public string ExpenseRefId { get; set; } = null!;

    public string ExpenseRefName { get; set; } = null!;

    public int SortCol { get; set; }

    public int? CompId { get; set; }

    public int Cmid { get; set; }
}
