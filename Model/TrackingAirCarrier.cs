using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class TrackingAirCarrier
{
    public int Id { get; set; }

    public int AirCarrierId { get; set; }

    public string? AirCarrierLink { get; set; }

    public string? SearchType { get; set; }

    public bool IsDeleted { get; set; }
}
