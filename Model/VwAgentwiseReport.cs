using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwAgentwiseReport
{
    public string? JobNo { get; set; }

    public string? AgentName { get; set; }

    public int? CompanyId { get; set; }

    public string? ShipmentMonth { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public int? TotalPackages { get; set; }

    public decimal? TotalNetWeightKgs { get; set; }

    public decimal? TotalChargeable { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public decimal? TotalVolumeCbm { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? ModeOfTransport { get; set; }

    public string TypeOfShipment { get; set; } = null!;
}
