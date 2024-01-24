using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwPatcoAirDsr
{
    public string? JobNo { get; set; }

    public string? Pod { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? ShipperInvoiceNo { get; set; }

    public int? PackageCount { get; set; }

    public decimal? ChWt { get; set; }

    public string? Airline { get; set; }

    public string? AirwayBillNo { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public DateTime? DeliveryDt { get; set; }
}
