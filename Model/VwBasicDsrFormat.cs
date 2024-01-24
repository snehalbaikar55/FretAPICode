using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwBasicDsrFormat
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

    public DateTime? Eta { get; set; }

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public string? MblNo { get; set; }

    public string? HblNo { get; set; }

    public string? PreAlert { get; set; }

    public string? DeliveryDt { get; set; }

    public string? Remark { get; set; }

    public string? ApproxEta { get; set; }

    public string? ContainerPickedUpByCustomer { get; set; }

    public string? CustomerReference { get; set; }

    public string? Containertext { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? CustomerName { get; set; }

    public int? IncoTermId { get; set; }

    public DateTime? Ata { get; set; }

    public DateTime? Atd { get; set; }

    public string? TransitTime { get; set; }
}
