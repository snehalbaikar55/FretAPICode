using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwAccountsShipmentList
{
    public string? Office { get; set; }

    public string? JobMonth { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? InvoiceNumber { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? JobNo { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? OriginAgent { get; set; }

    public string? DestinationAgent { get; set; }

    public string? ModeOfTransport { get; set; }

    public string? TransportDirection { get; set; }

    public string? JobType { get; set; }
}
