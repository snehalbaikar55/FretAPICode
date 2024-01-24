using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwWildRepublicCharge
{
    public int Cargoid { get; set; }

    public string Chargedesc { get; set; } = null!;

    public decimal? Amount { get; set; }

    public string? Currencycode { get; set; }
}
