using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class QbStateMaster
{
    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public string? StateName { get; set; }

    public string? StateCode { get; set; }

    public string? QbstateName { get; set; }

    public string? QbstateCode { get; set; }
}
