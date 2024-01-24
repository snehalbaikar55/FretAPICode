using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class ProfileRight
{
    public int ProfileRightId { get; set; }

    public int ProfileId { get; set; }

    public int FormId { get; set; }

    public bool? AllowView { get; set; }

    public bool? AllowRead { get; set; }

    public bool? AllowCreate { get; set; }

    public bool? AllowModify { get; set; }

    public bool? AllowDelete { get; set; }

    public bool? IsApprover { get; set; }

    public bool? ApprovalReq { get; set; }

    public int? ApprovalLevel { get; set; }

    public virtual FormMaster Form { get; set; } = null!;

    public virtual ProfileMaster Profile { get; set; } = null!;
}
