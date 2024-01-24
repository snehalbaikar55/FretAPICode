using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwRedEpartsAirDsr
{
    public int CargoId { get; set; }

    public string? JobNo { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public int? CargoPackId { get; set; }

    public string? ShipperInvoiceNo { get; set; }

    public int? PackageCount { get; set; }

    public decimal? TotalGrossWeight { get; set; }

    public string? Airline { get; set; }

    public string? MasterNo { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string CargoPickupDate { get; set; } = null!;

    public string CustomsClearanceDate { get; set; } = null!;

    public DateTime? DeliveryDate { get; set; }

    public string? CargoStatus { get; set; }

    public string? Remarks { get; set; }
}
