using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class AvaryShipmentGroup
{
    public int RecordId { get; set; }

    public int? ParentJobId { get; set; }

    public string? ParentJobNo { get; set; }

    public string? ChildJobNos { get; set; }
}
