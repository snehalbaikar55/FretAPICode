using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class WebRpair
{
    public int? CargoPackId { get; set; }

    public int? CargoId { get; set; }

    public string? JobNo { get; set; }

    public string? Pod { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? ShipperInvoiceNo { get; set; }

    public int? PackageCount { get; set; }

    public decimal? Weight { get; set; }

    public string? Airline { get; set; }

    public string? Awb { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public DateTime? CargoPickupDate { get; set; }

    public DateTime? CustomsClearanceDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }
}
