using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwChnDsrAi
{
    public string? JobNo { get; set; }

    public DateTime? JobDate { get; set; }

    public string? MawbNo { get; set; }

    public string? HawbNo { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Origin { get; set; }

    public string? Destination { get; set; }

    public int? Pkg { get; set; }

    public decimal? Weight { get; set; }

    public decimal? ChWt { get; set; }

    public string? FlightNo { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? IgmNoSublineNo { get; set; }

    public DateTime? IgmInwardDate { get; set; }
}
