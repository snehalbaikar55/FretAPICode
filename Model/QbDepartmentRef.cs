using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class QbDepartmentRef
{
    public int Id { get; set; }

    public string? Value { get; set; }

    public string? Name { get; set; }

    public int? Qbcompid { get; set; }
}
