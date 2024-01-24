using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwRedEpartsOceanDsrDaily
{
    public int CargoId { get; set; }

    public string? JobNo { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? ShipperInvoiceNo { get; set; }

    public int? PackageCount { get; set; }

    public decimal? ChargeableWeight { get; set; }

    public string? ShippingLine { get; set; }

    public string? BookingNumber { get; set; }

    public string? ContainerNumber { get; set; }

    public string? Vessel { get; set; }

    public string? Mbl { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public DateTime? CargoPickupDate { get; set; }

    public DateTime? ArrivalAtPol { get; set; }

    public DateTime? StuffingDate { get; set; }

    public string? CargoStatus { get; set; }

    public string? Remarks { get; set; }
}
