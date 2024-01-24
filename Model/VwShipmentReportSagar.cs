using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwShipmentReportSagar
{
    public DateTime? InvoiceDate { get; set; }

    public string? JobMonth { get; set; }

    public string? JobNo { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? AirlineOceanLine { get; set; }

    public string? CargoType { get; set; }

    public string? ModeOfTransport { get; set; }

    public string? TransportDirection { get; set; }

    public int ContainerCount { get; set; }

    public decimal? Cbm { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public decimal TotalWeightKgs { get; set; }

    public string? IncotermName { get; set; }

    public string OriginAgent { get; set; } = null!;

    public string DestinationAgent { get; set; } = null!;

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public DateTime? DateCreated { get; set; }
}
