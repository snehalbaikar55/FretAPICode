using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class OceanSchedule
{
    public int OceanScheduleId { get; set; }

    public int OceanLineId { get; set; }

    public int VesselId { get; set; }

    public string? Voyage { get; set; }

    public int Polid { get; set; }

    public int Podid { get; set; }

    public DateTime? DateDocumentCutoff { get; set; }

    public DateTime? DatePortCutoff { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? Frequency { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }
}
