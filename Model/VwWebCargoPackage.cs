using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwWebCargoPackage
{
    public int CargoPackId { get; set; }

    public int CargoId { get; set; }

    public string? ContainerNumber { get; set; }

    public string? ContainerCode { get; set; }

    public string DisplayContainerText { get; set; } = null!;

    public string? PackageType { get; set; }

    public int? PackageCount { get; set; }

    public decimal? NetWeight { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? VolumeCbm { get; set; }

    public decimal? VolumeWeight { get; set; }

    public decimal? Length { get; set; }

    public decimal? Width { get; set; }

    public decimal? Height { get; set; }

    public string? InvoiceNumber { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string DisplayNetWeight { get; set; } = null!;

    public string DisplayGrossWeight { get; set; } = null!;

    public string DisplayVolume { get; set; } = null!;

    public string DisplayVolumeWeight { get; set; } = null!;

    public string? DisplayCommodityDescription { get; set; }

    public string? DisplayDimensions { get; set; }

    public string? DisplayInvoiceNo { get; set; }
}
