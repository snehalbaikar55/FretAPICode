using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class QbChargeMapping
{
    public int ChargeMappingId { get; set; }

    public int? ChargeHeadId { get; set; }

    public string? ChargeHeadName { get; set; }

    public string? TaxCode { get; set; }

    public decimal? TaxPercent { get; set; }

    public string? QbChargeId { get; set; }

    public string? QbChargeName { get; set; }

    public string? ChargeDescription { get; set; }

    public string? CargoType { get; set; }

    public string? ChargeGroupName { get; set; }

    public int? CompId { get; set; }

    public string? Location { get; set; }
}
