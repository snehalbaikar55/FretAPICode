using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwWebCargoStatus
{
    public int CargoId { get; set; }

    public int CargoStatusId { get; set; }

    public string? CargoStatusName { get; set; }

    public DateTime? CargoStatusDate { get; set; }

    public string? StatusRemarks { get; set; }

    public bool? IsWebTracking { get; set; }

    public bool IsExpected { get; set; }
}
