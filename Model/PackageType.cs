using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class PackageType
{
    public int PackageTypeId { get; set; }

    public int PackageGroupId { get; set; }

    public string PackageTypeName { get; set; } = null!;

    public string? PackageTypeShortName { get; set; }

    public string? PackageCode { get; set; }

    public bool IsContainer { get; set; }

    public string? ContainerIsocode { get; set; }

    public decimal? DefaultLength { get; set; }

    public decimal? DefaultWidth { get; set; }

    public decimal? DefaultHeight { get; set; }

    public int? DimensionsUnitId { get; set; }

    public decimal? Weight { get; set; }

    public decimal? MaxWeight { get; set; }

    public int? WeightUnitId { get; set; }

    public bool IsOcean { get; set; }

    public bool IsAir { get; set; }

    public bool IsSurface { get; set; }

    public bool IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<CargoContainer> CargoContainers { get; } = new List<CargoContainer>();

    public virtual ICollection<CargoPackage> CargoPackages { get; } = new List<CargoPackage>();

    public virtual PackageGroup PackageGroup { get; set; } = null!;
}
