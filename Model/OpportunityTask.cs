using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class OpportunityTask
{
    public int TaskId { get; set; }

    public int OpportunityId { get; set; }

    public virtual Opportunity Opportunity { get; set; } = null!;

    public virtual Task Task { get; set; } = null!;
}
