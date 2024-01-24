using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwShipmentOperationsReport
{
    public string? JobNo { get; set; }

    public string? ModeOfTransport { get; set; }

    public string? TransportDirection { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Commodity { get; set; }

    public string? Invoiceno { get; set; }

    public string? Sbno { get; set; }

    public string? Sbdate { get; set; }

    public string? OriginAgent { get; set; }

    public string? DestinationAgent { get; set; }

    public string? OceanLine { get; set; }

    public string? Vessel { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public string? CustomerName { get; set; }

    public DateTime? Jobdate { get; set; }
}
