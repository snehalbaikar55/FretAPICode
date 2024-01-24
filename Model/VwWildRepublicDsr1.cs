using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwWildRepublicDsr1
{
    public string? JobNo { get; set; }

    public string? CustomerPo { get; set; }

    public string? Hbl { get; set; }

    public string? Mbl { get; set; }

    public string? ContainerNo { get; set; }

    public string? ContainerSize { get; set; }

    public string? Vessel { get; set; }

    public string? Origin { get; set; }

    public string? PortOfUnloading { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? EstimatedAtPort { get; set; }

    public DateTime? EstimatedClearance { get; set; }

    public string? Shipper { get; set; }

    public string ContainerValue { get; set; } = null!;

    public string? Invoiceno { get; set; }

    public string Status { get; set; } = null!;

    public string Remarks { get; set; } = null!;
}
