using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwChennaiDsrOiCando
{
    public DateTime? CreatedDate { get; set; }

    public string? JobNo { get; set; }

    public DateTime? BookingConfirmationDate { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Chaname { get; set; }

    public string? OverseasAgent { get; set; }

    public string? Origin { get; set; }

    public string? Destination { get; set; }

    public string TypeOfShipment { get; set; } = null!;

    public string? MblNo { get; set; }

    public string? FinalMblNo { get; set; }

    public string? HblNo { get; set; }

    public string? ContainerNo { get; set; }

    public string? NoPkgs { get; set; }

    public string? GrossWeight { get; set; }

    public string? Cbm { get; set; }

    public int? _20gp { get; set; }

    public int? _20hc { get; set; }

    public int? _40gp { get; set; }

    public int? _40hc { get; set; }

    public string? VesselName { get; set; }

    public string? Etd { get; set; }

    public DateTime? PreAlertReceived { get; set; }

    public string? SurrenderBlReceived { get; set; }

    public DateTime? PreAlertSentToConsignee { get; set; }

    public DateTime? ManifestSent { get; set; }

    public string? Eta { get; set; }

    public string? IgmNoSublineNo { get; set; }

    public string? IgmSentOn { get; set; }

    public string? Cfs { get; set; }

    public string? Liner { get; set; }

    public string? CoLoader { get; set; }

    public string? Remarks { get; set; }

    public DateTime? InvoicesSentDate { get; set; }

    public DateTime? CourierMailSentDate { get; set; }

    public string? InvoiceNumber { get; set; }

    public string CurrentStatus { get; set; } = null!;
}
