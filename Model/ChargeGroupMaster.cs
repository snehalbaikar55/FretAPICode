using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class ChargeGroupMaster
{
    public int ChargeGroupId { get; set; }

    public string ChargeGroupCode { get; set; } = null!;

    public string ChargeGroupName { get; set; } = null!;

    public string? ChargeGroupDescription { get; set; }

    public int? ParentChargeGroupId { get; set; }

    public bool? IsExpense { get; set; }

    public bool? IsIncome { get; set; }

    public bool? IsAir { get; set; }

    public bool? IsOcean { get; set; }

    public bool? IsSurface { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }
}
