using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwProfitPerJobNonTax
{
    public string? CargoNumber { get; set; }

    public int CargoId { get; set; }

    public decimal? Income { get; set; }

    public decimal? Expense { get; set; }

    public decimal? Profit { get; set; }

    public string? CargoSopapprovalStatus { get; set; }
}
