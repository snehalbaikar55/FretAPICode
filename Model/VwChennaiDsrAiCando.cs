using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwChennaiDsrAiCando
{
    public DateTime? CreatedDate { get; set; }

    public DateTime? BookingReceivedDate { get; set; }

    public DateTime? BookingConfirmationDate { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Chaname { get; set; }

    public string? Origin { get; set; }

    public string? Destination { get; set; }

    public string? JobNo { get; set; }

    public string? MawbNo { get; set; }

    public string? FinalMawbNo { get; set; }

    public string? HawbNo { get; set; }

    public string? NoPkgsGrsWtCbm { get; set; }

    public string? FlightNo { get; set; }

    public string? Etd { get; set; }

    public DateTime? PreAlertReceived { get; set; }

    public DateTime? SurrenderblReceived { get; set; }

    public DateTime? PreAlertSentToConsignee { get; set; }

    public DateTime? ManifestSent { get; set; }

    public string? Eta { get; set; }

    public string TransitStatus { get; set; } = null!;

    public string? IgmNoSublineNo { get; set; }

    public string? IgmSentOn { get; set; }

    public string? Cfs { get; set; }

    public string ContainerNo { get; set; } = null!;

    public string? Carrier { get; set; }

    public string TypeOfShipment { get; set; } = null!;

    public string? Remarks { get; set; }

    public DateTime? InvoicesSentDate { get; set; }

    public string CurrentStatus { get; set; } = null!;

    public string? InvoiceNumber { get; set; }
}
