using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwTotalContainersPerCargo
{
    public int CargoId { get; set; }

    public int? ContainerCount { get; set; }
}
