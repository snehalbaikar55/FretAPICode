using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class TaskTypeMaster
{
    public int TaskTypeId { get; set; }

    public string? TaskTypeName { get; set; }

    public bool IsActive { get; set; }
}
