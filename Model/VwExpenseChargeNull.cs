using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwExpenseChargeNull
{
    public int? VendorBillId { get; set; }

    public int? VendorBillLineItemId { get; set; }

    public int? ChargeItemId { get; set; }

    public string? ChargeDescription { get; set; }

    public decimal? ExpectedAmount { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? TaxPercent { get; set; }

    public int? ChargeHeadId { get; set; }

    public string? ChargeHeadName { get; set; }
}
