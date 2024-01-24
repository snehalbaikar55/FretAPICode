using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwProductwiseShipmentCountLastyear
{
    public int CompanyId { get; set; }

    public string Customer { get; set; } = null!;

    public string? Salesperson { get; set; }

    public int? OceanImport { get; set; }

    public int? OceanExport { get; set; }

    public int? AirImport { get; set; }

    public int? AirExport { get; set; }

    public int? FirstShipmentDate { get; set; }

    public int? LastShipmentDate { get; set; }

    public int? OfficeId { get; set; }
}
