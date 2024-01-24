using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwDsr
{
    public int CargoId { get; set; }

    public string? JobNo { get; set; }

    public string? ModeOfTransport { get; set; }

    public string? TransportDirection { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public int? ShipperId { get; set; }

    public int? ConsigneeId { get; set; }

    public string? ContainerNo { get; set; }

    public string? Invoiceno { get; set; }

    public int? TotalPackages { get; set; }

    public decimal? TotalGrossWeightKgs { get; set; }

    public decimal? TotalNetWeightKgs { get; set; }

    public decimal? TotalVolWeight { get; set; }

    public decimal? TotalVolumeCbm { get; set; }

    public decimal? TotalChargeable { get; set; }

    public string? Size { get; set; }

    public string? OceanLine { get; set; }

    public string? Vessel { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? Booking { get; set; }
}
