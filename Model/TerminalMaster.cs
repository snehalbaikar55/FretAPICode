using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class TerminalMaster
{
    public int TerminalId { get; set; }

    public int LocationId { get; set; }

    public string TerminalName { get; set; } = null!;

    public bool IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool IsDeleted { get; set; }
}
