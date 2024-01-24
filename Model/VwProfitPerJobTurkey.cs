using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwProfitPerJobTurkey
{
    public string? CargoNumber { get; set; }

    public int CargoId { get; set; }

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
}
