using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class AttributeMaster
{
    public int AttributeId { get; set; }

    public string? AttributeName { get; set; }

    public bool IsDeleted { get; set; }
}
