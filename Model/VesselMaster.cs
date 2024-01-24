using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VesselMaster
{
    public int VesselId { get; set; }

    public int OceanLineId { get; set; }

    public string? VesselName { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }
}
