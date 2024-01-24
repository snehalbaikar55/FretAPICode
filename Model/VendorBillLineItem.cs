using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VendorBillLineItem
{
    public int VendorBillLineItemId { get; set; }

    public int VendorBillId { get; set; }

    public int SortOrder { get; set; }

    public int? ChargeId { get; set; }

    public int ChargeItemId { get; set; }

    public string? ChargeDescription { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Rate { get; set; }

    public int? CurrencyId { get; set; }

    public string? CurrencyCode { get; set; }

    public int? ExRateId { get; set; }

    public decimal? ExRate { get; set; }

    public int? TaxRateId { get; set; }

    public decimal? TaxPercent { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? TaxableAmount { get; set; }

    public decimal? NonTaxableAmount { get; set; }

    public decimal? ExpectedAmount { get; set; }

    public decimal? RealizedAmount { get; set; }

    public decimal? TotalAmountLocalCurrency { get; set; }

    public decimal? TaxAmountLocalCurrency { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public string? ServiceCode { get; set; }

    public string? ApplyPer { get; set; }
}
