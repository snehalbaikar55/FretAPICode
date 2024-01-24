using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class ExchangeRate
{
    public int ExchangeRateId { get; set; }

    public DateTime ExchangeDateFrom { get; set; }

    public DateTime ExchangeDateTo { get; set; }

    public int BaseCurrencyId { get; set; }

    public int ConvertedCurrencyId { get; set; }

    public decimal? ExchangeBuyingRate { get; set; }

    public decimal? ExchangeSellingRate { get; set; }

    public decimal? ExchangeBuyingRateInverse { get; set; }

    public decimal? ExchangeSellingInverse { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool IsDeleted { get; set; }

    public int? OfficeId { get; set; }

    public int? CountryId { get; set; }
}
