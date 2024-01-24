using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwSopreport
{
    public string? Jobno { get; set; }

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public string? ModeOfTransport { get; set; }

    public string? TransportDirection { get; set; }

    public string? OceanLine { get; set; }

    public int? ContainerCount { get; set; }

    public string? ContainerType { get; set; }

    public string? ContainerNo { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public decimal? BuyingTotal { get; set; }

    public decimal? SellingTotal { get; set; }

    public decimal? Profit { get; set; }

    public string? Costsheettype { get; set; }

    public DateTime? JobDate { get; set; }
}
