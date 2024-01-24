using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CoveringLetterDocsMaster
{
    public int DocumetId { get; set; }

    public string? DocumetName { get; set; }

    public bool? IsActive { get; set; }

    public string? Cargotype { get; set; }
}
