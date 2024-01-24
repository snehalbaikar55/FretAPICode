using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwAccountsActivity
{
    public string? JobNumber { get; set; }

    public string? AccountName { get; set; }

    public string? SalesPerson { get; set; }

    public decimal? Income { get; set; }

    public decimal? Expense { get; set; }

    public decimal? ProfitOnJob { get; set; }

    public decimal? ProfitValueAge { get; set; }

    public decimal? IncomeNontax { get; set; }

    public decimal? ExpenseNontax { get; set; }

    public decimal? ProfitOnJobNontax { get; set; }

    public decimal? ProfitValueNontaxAge { get; set; }

    public string? JobMonth { get; set; }

    public string? CostsheetStatus { get; set; }

    public string? Officename { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? Agent { get; set; }

    public DateTime? InvoiceDate { get; set; }
}
