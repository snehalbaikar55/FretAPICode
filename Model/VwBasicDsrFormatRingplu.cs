using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwBasicDsrFormatRingplu
{
    public string IncotermName { get; set; } = null!;

    public string? JobNo { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? ShipperInvoiceNo { get; set; }

    public string? ShippingLine { get; set; }

    public string? BookingNo { get; set; }

    public string? Container { get; set; }

    public string? VesselName { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? EtaAtPod { get; set; }

    public string Status { get; set; } = null!;

    public string? Remark { get; set; }

    public string? MblNo { get; set; }

    public string? HblNo { get; set; }

    public string? PreAlert { get; set; }

    public string? FinalDeliveryDt { get; set; }
}
