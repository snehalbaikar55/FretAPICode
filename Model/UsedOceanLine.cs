using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class UsedOceanLine
{
    public int LinersId { get; set; }

    public string LineCountry { get; set; } = null!;

    public string LineCallSign { get; set; } = null!;

    public string LineCompanyName { get; set; } = null!;

    public string LineOwnerCountry { get; set; } = null!;

    public string LineOwnerName { get; set; } = null!;

    public byte IsActive { get; set; }

    public string? Scac { get; set; }
}
