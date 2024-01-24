using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwFyjobsDaily
{
    public string? JobNo { get; set; }

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public string ShipmentType { get; set; } = null!;

    public string? AccountName { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? OriginAgent { get; set; }

    public string? DestinationAgent { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? SalesPerson { get; set; }

    public int? CargoId { get; set; }

    public int? _20gp { get; set; }

    public int? _20hc { get; set; }

    public int? _20ft { get; set; }

    public int? _20ot { get; set; }

    public int? _40gp { get; set; }

    public int? _40hc { get; set; }

    public int? _40ft { get; set; }

    public int? _40ot { get; set; }

    public int? TotalPackages { get; set; }

    public decimal? TotalChargeable { get; set; }

    public DateTime? JobOpenDate { get; set; }

    public DateTime? JobCloseDate { get; set; }

    public DateTime? InvoiceDate { get; set; }
}
