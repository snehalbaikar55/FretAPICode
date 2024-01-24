using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class TrackingOceanCarrier
{
    public int Id { get; set; }

    public int OceanCarrierId { get; set; }

    public string? OceanCarrierLink { get; set; }

    public string? SearchType { get; set; }

    public bool IsDeleted { get; set; }
}
