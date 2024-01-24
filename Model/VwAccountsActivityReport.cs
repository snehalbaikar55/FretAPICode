using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwAccountsActivityReport
{
    public string? Month { get; set; }

    public DateTime? Eta { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? InvDate { get; set; }

    public string? JobNo { get; set; }

    public decimal? Cost { get; set; }

    public decimal? Revenue { get; set; }

    public decimal? GrossProfit { get; set; }

    public decimal? Profit { get; set; }

    public decimal? CostNontax { get; set; }

    public decimal? RevenueNontax { get; set; }

    public decimal? GrossProfitNontax { get; set; }

    public decimal? ProfitNontax { get; set; }

    public string CostsheetStatus { get; set; } = null!;

    public string? SalesExecutive { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Customer { get; set; }

    public string? Agent { get; set; }
}
