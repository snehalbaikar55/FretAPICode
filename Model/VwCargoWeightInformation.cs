using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwCargoWeightInformation
{
    public int CargoId { get; set; }

    public int? TotalPackages { get; set; }

    public decimal? TotalGrossWeightKgs { get; set; }

    public decimal? TotalVolWeight { get; set; }

    public decimal? TotalNetWeightKgs { get; set; }

    public decimal? TotalVolumeCbm { get; set; }

    public decimal? TotalChargeable { get; set; }
}
