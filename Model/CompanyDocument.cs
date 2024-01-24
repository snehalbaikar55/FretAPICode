using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CompanyDocument
{
    public int DocumentId { get; set; }

    public int CompanyId { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Document Document { get; set; } = null!;
}
