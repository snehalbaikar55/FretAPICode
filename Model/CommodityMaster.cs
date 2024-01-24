using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CommodityMaster
{
    public int CommodityId { get; set; }

    public string CommodityName { get; set; } = null!;

    public string? CommodityType { get; set; }

    public string? Hscode { get; set; }

    public bool IsHazardous { get; set; }

    public bool IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }
}
