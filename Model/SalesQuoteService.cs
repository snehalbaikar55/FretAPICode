using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class SalesQuoteService
{
    public int SalesQuoteServiceId { get; set; }

    public int SalesQuoteId { get; set; }

    public byte? SalesQuoteServiceOrder { get; set; }

    public int? ServiceTypeId { get; set; }

    public int OriginLocationId { get; set; }

    public string? OriginPoint { get; set; }

    public int DestinationLocationId { get; set; }

    public string? DestinationPoint { get; set; }

    public int? TransshipmentPoint1 { get; set; }

    public int? TransshipmentPoint2 { get; set; }

    public int? TransshipmentPoint3 { get; set; }

    public int? TransitTime { get; set; }

    public int? FrequencyId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public virtual SalesQuote SalesQuote { get; set; } = null!;

    public virtual ICollection<SalesQuoteCharge> SalesQuoteCharges { get; } = new List<SalesQuoteCharge>();
}
