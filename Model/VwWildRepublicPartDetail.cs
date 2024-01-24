using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwWildRepublicPartDetail
{
    public int? CargoPackId { get; set; }

    public string? JobNo { get; set; }

    public string? ShipperInvoiceNo { get; set; }

    public string? Ponumber { get; set; }

    public string? PartNumber { get; set; }

    public string? PartQty { get; set; }

    public int? PackageCount { get; set; }

    public string MarksAndNumbers { get; set; } = null!;

    public string? PackageDescription { get; set; }
}
