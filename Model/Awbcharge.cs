using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Awbcharge
{
    public int AwbchargeId { get; set; }

    public int Awbid { get; set; }

    public int CargoId { get; set; }

    public int AwbchargeTypeId { get; set; }

    public string? DueType { get; set; }

    public string? ApplyPer { get; set; }

    public decimal? ChargeAmount { get; set; }

    public int? SortOrder { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public virtual CargoAwb Awb { get; set; } = null!;
}
