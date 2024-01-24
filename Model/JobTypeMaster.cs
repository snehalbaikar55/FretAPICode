using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class JobTypeMaster
{
    public int JobtypeId { get; set; }

    public string? JobtypeName { get; set; }

    public bool IsActive { get; set; }
}
