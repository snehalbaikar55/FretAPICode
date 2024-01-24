using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class ApplyPerMaster
{
    public int ApplyPerId { get; set; }

    public string? ApplyPerName { get; set; }

    public string? ApplyPerCode { get; set; }

    public bool IsActive { get; set; }
}
