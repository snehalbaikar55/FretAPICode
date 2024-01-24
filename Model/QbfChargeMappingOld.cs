using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class QbfChargeMappingOld
{
    public int? ChargeHeadId { get; set; }

    public string? ChargeHeadName { get; set; }

    public string? TaxCode { get; set; }

    public decimal? TaxPercent { get; set; }

    public string? QbchennaiId { get; set; }

    public string? QbchennaiName { get; set; }
}
