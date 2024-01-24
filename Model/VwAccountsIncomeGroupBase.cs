using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwAccountsIncomeGroupBase
{
    public int? SrNo { get; set; }

    public int CargoId { get; set; }

    public string? JobNo { get; set; }

    public string? Month { get; set; }

    public decimal? ChargeAmount { get; set; }

    public string? Group { get; set; }
}
