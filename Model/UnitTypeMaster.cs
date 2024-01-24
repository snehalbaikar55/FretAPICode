using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class UnitTypeMaster
{
    public short UnitTypeId { get; set; }

    public string? UnitTypeName { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<UnitMaster> UnitMasters { get; } = new List<UnitMaster>();
}
