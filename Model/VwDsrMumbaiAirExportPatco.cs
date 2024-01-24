using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwDsrMumbaiAirExportPatco
{
    public string? JobNo { get; set; }

    public string? Pod { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? ShipperInvoiceNo { get; set; }

    public int? Pkg { get; set; }

    public decimal? Weight { get; set; }

    public decimal? ChWt { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? FlightNo { get; set; }

    public string? IgmNoSublineNo { get; set; }

    public DateTime? IgmInwardDate { get; set; }

    public string? AirCarrierName { get; set; }
}
