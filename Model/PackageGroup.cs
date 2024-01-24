using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class PackageGroup
{
    public int PackageGroupId { get; set; }

    public string PackageGroupName { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<PackageType> PackageTypes { get; } = new List<PackageType>();
}
