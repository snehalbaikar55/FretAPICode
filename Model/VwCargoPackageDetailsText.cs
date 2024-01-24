using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwCargoPackageDetailsText
{
    public int CargoId { get; set; }

    public string? InvnoOutput { get; set; }

    public string? InvdtOutput { get; set; }

    public string? SbnoOutput { get; set; }

    public string? SbdateOutput { get; set; }

    public string? CommOutput { get; set; }
}
