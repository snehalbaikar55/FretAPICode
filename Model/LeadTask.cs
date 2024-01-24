using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class LeadTask
{
    public int TaskId { get; set; }

    public int LeadId { get; set; }

    public virtual Lead Lead { get; set; } = null!;

    public virtual Task Task { get; set; } = null!;
}
