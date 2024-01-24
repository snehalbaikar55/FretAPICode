using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class OpportunityDocument
{
    public int DocumentId { get; set; }

    public int OpportunityId { get; set; }

    public virtual Document Document { get; set; } = null!;

    public virtual Opportunity Opportunity { get; set; } = null!;
}
