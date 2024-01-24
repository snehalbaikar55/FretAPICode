using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Lcljob
{
    public int CargoId { get; set; }

    public string JobNo { get; set; } = null!;

    public decimal? Cbm { get; set; }
}
