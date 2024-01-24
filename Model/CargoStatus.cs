using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CargoStatus
{
    public int CargoStatusId { get; set; }

    public int? StatusId { get; set; }

    public int CargoId { get; set; }

    public string? CargoStatusName { get; set; }

    public DateTime? CargoStatusDate { get; set; }

    public string? StatusRemarks { get; set; }

    public bool IsExpected { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModifed { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Cargo Cargo { get; set; } = null!;

    public virtual CargoStatusMaster? Status { get; set; }
}
