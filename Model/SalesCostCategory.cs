using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class SalesCostCategory
{
    public int CostCategoryId { get; set; }

    public int SalesQuoteId { get; set; }

    public string? CostCategoryType { get; set; }

    public string? CostCategoryStatus { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? BuyingRatesIncharge { get; set; }

    public int? SellingRatesIncharge { get; set; }

    public int? AssignedTo { get; set; }

    public string? VerifiedBy { get; set; }

    public decimal? BuyExRateUsd { get; set; }

    public decimal? BuyExRateEur { get; set; }

    public decimal? BuyExRateTl { get; set; }

    public decimal? BuyExRateInr { get; set; }

    public decimal? SellExRateUsd { get; set; }

    public decimal? SellExRateEur { get; set; }

    public decimal? SellExRateTl { get; set; }

    public decimal? SellExRateInr { get; set; }

    public DateTime? ExchangeRateDate { get; set; }
}
