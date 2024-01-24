using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwPolyrubShipment
{
    public string? Job { get; set; }

    public decimal? TotalSell { get; set; }

    public decimal? TotalBuy { get; set; }

    public decimal? GrossProfit { get; set; }

    public decimal? AirFreight { get; set; }

    public decimal? CustomDuty { get; set; }

    public decimal? FreightOtherComponent { get; set; }

    public decimal? HandlingCharges { get; set; }

    public decimal? OtherCharges { get; set; }

    public decimal? Rebate { get; set; }
}
