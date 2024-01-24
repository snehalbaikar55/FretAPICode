using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class FormMaster
{
    public int FormId { get; set; }

    public string FormName { get; set; } = null!;

    public string? FormGroup { get; set; }

    public bool AllowApproval { get; set; }

    public int? GroupSortOrder { get; set; }

    public int? FormSortOrder { get; set; }

    public virtual ICollection<ProfileRight> ProfileRights { get; } = new List<ProfileRight>();
}
