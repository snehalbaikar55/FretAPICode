using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class EntityTypeMaster
{
    public int EntityTypeId { get; set; }

    public string? EntityTypeName { get; set; }

    public bool IsAir { get; set; }

    public bool IsOcean { get; set; }

    public bool IsSurface { get; set; }

    public bool IsCompulsary { get; set; }
}
