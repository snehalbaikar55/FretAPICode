using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CargoPackage
{
    public int CargoPackId { get; set; }

    public int CargoId { get; set; }

    public int CargoPackTypeId { get; set; }

    public int? ContainerId { get; set; }

    public string? CargoPackName { get; set; }

    public int? PackageCount { get; set; }

    public decimal? Length { get; set; }

    public decimal? Width { get; set; }

    public decimal? Height { get; set; }

    public int? SizeId { get; set; }

    public decimal? NetWeight { get; set; }

    public decimal? GrossWeight { get; set; }

    public int? WeightUnitId { get; set; }

    public decimal? Volume { get; set; }

    public int? VolumeUnitId { get; set; }

    public string? PackageDescription { get; set; }

    public string? MarksAndNumbers { get; set; }

    public string? InvoiceNumber { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? Sbno { get; set; }

    public DateTime? Sbdate { get; set; }

    public bool? IsPerPackage { get; set; }

    public decimal? WeightKgs { get; set; }

    public decimal? WeightLbs { get; set; }

    public decimal? VolumeCbm { get; set; }

    public decimal? VolumeFt3 { get; set; }

    public decimal? VolumeWeight { get; set; }

    public decimal? TotalNetWeight { get; set; }

    public decimal? TotalGrossWeight { get; set; }

    public decimal? TotalVolume { get; set; }

    public decimal? TotalVolumeWeight { get; set; }

    public int? ParentPackageId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Cargo Cargo { get; set; } = null!;

    public virtual PackageType CargoPackType { get; set; } = null!;

    public virtual CargoContainer? Container { get; set; }
}
