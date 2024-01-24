using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwBasicDsrFormatPune
{
    public string? JobNo { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? ShipperInvoiceNo { get; set; }

    public string? SbNo { get; set; }

    public string? SbDate { get; set; }

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

    public string? ContainerPickedUpByCustomer { get; set; }

    public string? Remarks { get; set; }

    public string? CustomerReference { get; set; }

    public string? Containertext { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? CustomerName { get; set; }

    public string? Agent { get; set; }

    public string? IncotermName { get; set; }

    public int? NoPkgs { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? Cbm { get; set; }

    public string? YourFreightBillNo { get; set; }

    public string? YourFreightBillDate { get; set; }

    public string? CommOutput { get; set; }
}
