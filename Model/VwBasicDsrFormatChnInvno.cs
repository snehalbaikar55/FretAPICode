using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwBasicDsrFormatChnInvno
{
    public string? JobNo { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public string Cargotype { get; set; } = null!;

    public string? Product { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? ShipperInvoiceNo { get; set; }

    public DateTime? ShipperInvoiceDate { get; set; }

    public string? ShippingLine { get; set; }

    public string? BookingNo { get; set; }

    public string? Container { get; set; }

    public string? VesselName { get; set; }

    public string? Etd { get; set; }

    public string? Eta { get; set; }

    public string? ApproxEta { get; set; }

    public string Status { get; set; } = null!;

    public string? Remark { get; set; }

    public string? MblNo { get; set; }

    public string? HblNo { get; set; }

    public string? PreAlert { get; set; }

    public string? DeliveryDt { get; set; }

    public string? IncotermName { get; set; }

    public string? NoPkgs { get; set; }

    public string? GrossWeight { get; set; }

    public string? Cbm { get; set; }

    public string CutOff { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string CurrentStatus { get; set; } = null!;

    public int CargoId { get; set; }

    public string? DestinationAgent { get; set; }

    public DateTime? DateCreated { get; set; }
}
