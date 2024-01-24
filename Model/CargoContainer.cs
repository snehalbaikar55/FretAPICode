using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CargoContainer
{
    public int ContainerId { get; set; }

    public int ContainerTypeId { get; set; }

    public int? CargoId { get; set; }

    public string ContainerCode { get; set; } = null!;

    public string? ContainerNumber { get; set; }

    public string? Seal1 { get; set; }

    public string? Seal2 { get; set; }

    public string? Description { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public decimal? Vgmweight { get; set; }

    public virtual Cargo? Cargo { get; set; }

    public virtual ICollection<CargoPackage> CargoPackages { get; } = new List<CargoPackage>();

    public virtual PackageType ContainerType { get; set; } = null!;
}
