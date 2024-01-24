using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class WebUser
{
    public int WebUserId { get; set; }

    public int? LinkedDesktopUserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? UserType { get; set; }

    public string? UserPassword { get; set; }

    public string? UserDisplayName { get; set; }

    public int? CompanyId { get; set; }

    public string? CompanyDisplayName { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsLocked { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public string? DateDeleted { get; set; }

    public int? LockedBy { get; set; }

    public DateTime? DateLocked { get; set; }

    public string? Remarks { get; set; }

    public virtual ICollection<WebUserAccess> WebUserAccesses { get; } = new List<WebUserAccess>();
}
