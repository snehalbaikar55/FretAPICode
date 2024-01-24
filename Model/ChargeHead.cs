using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class ChargeHead
{
    public int ChargeHeadId { get; set; }

    public string? ChargeHeadName { get; set; }

    public int? ChargeGroupId { get; set; }

    public string? ChargeGroupName { get; set; }

    public int? TaxId { get; set; }

    public string? TaxName { get; set; }

    public decimal? TaxPercent { get; set; }

    public string? IncomeExpense { get; set; }
}
