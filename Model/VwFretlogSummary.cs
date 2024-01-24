using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwFretlogSummary
{
    public string? JobNo { get; set; }

    public string Officename { get; set; } = null!;

    public string? ModeOfTransport { get; set; }

    public string? TransportDirection { get; set; }

    public bool IsConsolidation { get; set; }

    public int? CargoId { get; set; }

    public int? _20gp { get; set; }

    public int? _20hc { get; set; }

    public int? _20ft { get; set; }

    public int? _20ot { get; set; }

    public int? _40gp { get; set; }

    public int? _40hc { get; set; }

    public int? _40ft { get; set; }

    public int? _40ot { get; set; }

    public DateTime? JobMonth { get; set; }

    public decimal? TotalGrossWeightKgs { get; set; }

    public decimal? TotalChargeable { get; set; }

    public decimal? TotalVolumeCbm { get; set; }

    public int? TotalPackages { get; set; }
}
