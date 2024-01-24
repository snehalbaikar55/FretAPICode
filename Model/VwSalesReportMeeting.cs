using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwSalesReportMeeting
{
    public string? CargoNumber { get; set; }

    public string? JobMonth { get; set; }

    public string? Salesperson { get; set; }

    public string? Officename { get; set; }

    public string? AccountName { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public string? TransportDirection { get; set; }

    public string? ModeOfTransport { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public int? ContainerCount { get; set; }

    public decimal? TotalGrossWeightKgs { get; set; }

    public decimal? TotalVolumeCbm { get; set; }
}
