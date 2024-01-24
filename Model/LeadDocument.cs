using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class LeadDocument
{
    public int DocumentId { get; set; }

    public int LeadId { get; set; }

    public virtual Document Document { get; set; } = null!;

    public virtual Lead Lead { get; set; } = null!;
}
