using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class ContactType
{
    public int ContactTypeId { get; set; }

    public string? ContactTypeName { get; set; }

    public bool? IsActive { get; set; }
}
