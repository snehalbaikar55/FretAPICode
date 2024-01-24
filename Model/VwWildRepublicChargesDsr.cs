using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwWildRepublicChargesDsr
{
    public int CargoId { get; set; }

    public decimal? FreightCharges { get; set; }

    public decimal? CustomClearanceCharges { get; set; }

    public decimal? DestinationCharges { get; set; }

    public decimal? OtherCharges { get; set; }
}
