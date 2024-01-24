using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class ChargeAttribute
{
    public int ChargeAttributeId { get; set; }

    public int SalesQuoteChargeId { get; set; }

    public decimal? MinimumAmount { get; set; }

    public decimal? MaximumAmount { get; set; }

    public decimal? StartRange { get; set; }

    public decimal? EndRange { get; set; }

    public int? UnitId { get; set; }

    public decimal? ChargeAmount { get; set; }

    public int? CurrencyId { get; set; }

    public int? SortOrder { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public virtual CurrencyMaster? Currency { get; set; }

    public virtual SalesQuoteCharge SalesQuoteCharge { get; set; } = null!;
}
