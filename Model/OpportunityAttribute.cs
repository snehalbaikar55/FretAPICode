using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class OpportunityAttribute
{
    public int OpportunityAttributeId { get; set; }

    public int? OpportunityId { get; set; }

    public string? Mode { get; set; }

    public string? CargoType { get; set; }

    public int? Polid { get; set; }

    public string? Pol { get; set; }

    public int? Podid { get; set; }

    public string? Pod { get; set; }

    public string? EquipmentType { get; set; }

    public decimal? TotalWeightKgs { get; set; }

    public decimal? TotalVolumeCbm { get; set; }

    public string? RequiredEquipment { get; set; }

    public virtual Opportunity? Opportunity { get; set; }
}
