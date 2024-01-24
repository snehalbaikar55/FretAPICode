using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwSalesReportTurkey
{
    public string? Jobno { get; set; }

    public string? JobMonth { get; set; }

    public string? AccountName { get; set; }

    public string? Salesperson { get; set; }

    public string? Officename { get; set; }

    public string? CargoNumber { get; set; }

    public int? CargoId { get; set; }

    public decimal? IncomeTl { get; set; }

    public decimal? ExpenseTl { get; set; }

    public decimal? ProfitTl { get; set; }

    public decimal? ExpenseUsd { get; set; }

    public decimal? IncomeUsd { get; set; }

    public decimal? ProfitUsd { get; set; }

    public decimal? ExpenseEur { get; set; }

    public decimal? IncomeEur { get; set; }

    public decimal? ProfitEur { get; set; }

    public string? Costsheetstatus { get; set; }

    public string? Costsheettype { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public string? TransportDirection { get; set; }

    public string? ModeOfTransport { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }
}
