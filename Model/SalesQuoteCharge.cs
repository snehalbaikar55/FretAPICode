using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class SalesQuoteCharge
{
    public int SalesQuoteChargeId { get; set; }

    public int SalesQuoteServiceId { get; set; }

    public int SalesQuoteId { get; set; }

    public string? ChargePer { get; set; }

    public int ChargeGroupId { get; set; }

    public int ChargeItemId { get; set; }

    public string ChargeDescription { get; set; } = null!;

    public int? Quantity { get; set; }

    public int? UnitId { get; set; }

    public decimal? Rate { get; set; }

    public decimal? TaxPercent { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool IsExpense { get; set; }

    public int ApplicableToCompanyId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<ChargeAttribute> ChargeAttributes { get; } = new List<ChargeAttribute>();

    public virtual ChargeItemMaster ChargeItem { get; set; } = null!;

    public virtual SalesQuoteService SalesQuoteService { get; set; } = null!;
}
