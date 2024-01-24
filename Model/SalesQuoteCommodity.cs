using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class SalesQuoteCommodity
{
    public int SalesQuoteCommodityId { get; set; }

    public int SalesQuoteId { get; set; }

    public int? CommodityId { get; set; }

    public string? CommodityDescription { get; set; }

    public int? PackageTypeId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Length { get; set; }

    public decimal? Width { get; set; }

    public decimal? Height { get; set; }

    public int? SizeUnitId { get; set; }

    public decimal? GrossWeight { get; set; }

    public int? WeightUnitId { get; set; }

    public decimal? Volume { get; set; }

    public int? VolumeUnitId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public virtual SalesQuote SalesQuote { get; set; } = null!;
}
