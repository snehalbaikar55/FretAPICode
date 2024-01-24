using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwJobActivityByOffice
{
    public int? OfficeId { get; set; }

    public string? Modeoftransport { get; set; }

    public string? Transportdirection { get; set; }

    public string? Jobtype { get; set; }

    public int? JobCount { get; set; }
}
