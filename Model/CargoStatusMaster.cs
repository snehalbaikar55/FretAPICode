using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CargoStatusMaster
{
    public int StatusId { get; set; }

    public string StatusServiceType { get; set; } = null!;

    public string StatusName { get; set; } = null!;

    public string? StatusReferenceNumber { get; set; }

    public bool IsSystemGenerated { get; set; }

    public int? StatusStageNumber { get; set; }

    public int? StagePercentage { get; set; }

    public bool IsWebTracking { get; set; }

    public bool? IsCompulsary { get; set; }

    public int? RemindBefore { get; set; }

    public int? AutoTaskTemplateId { get; set; }

    public int? RelatedCargoDocumentId { get; set; }

    public string? TransportDirection { get; set; }

    public virtual ICollection<CargoStatus> CargoStatuses { get; } = new List<CargoStatus>();
}
