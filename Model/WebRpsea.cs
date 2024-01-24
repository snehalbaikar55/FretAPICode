using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class WebRpsea
{
    public int? CargoPackId { get; set; }

    public int? CargoId { get; set; }

    public string? JobNo { get; set; }

    public string? Shipper { get; set; }

    public string? ShipperInvoiceNo { get; set; }

    public int? PackageCount { get; set; }

    public decimal? Weight { get; set; }

    public DateTime? PickupDate { get; set; }

    public DateTime? ArrivalAtPort { get; set; }

    public DateTime? StuffingDate { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }
}
