using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class IncoTerrmMaster
{
    public int IncoTermId { get; set; }

    public string? IncotermName { get; set; }

    public bool IsActive { get; set; }
}
