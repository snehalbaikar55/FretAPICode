using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class ProfileMaster
{
    public int ProfileId { get; set; }

    public string ProfileName { get; set; } = null!;

    public string AssociatedDesignation { get; set; } = null!;

    public int? OfficeId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<ProfileRight> ProfileRights { get; } = new List<ProfileRight>();

    public virtual ICollection<UserMaster> UserMasters { get; } = new List<UserMaster>();
}
