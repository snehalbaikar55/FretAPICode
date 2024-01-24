using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CargoTask
{
    public int TaskId { get; set; }

    public int CargoId { get; set; }

    public virtual Cargo Cargo { get; set; } = null!;

    public virtual Task Task { get; set; } = null!;
}
