using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class UserOfficeAccess
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int OfficeId { get; set; }

    public virtual Company Office { get; set; } = null!;

    public virtual UserMaster User { get; set; } = null!;
}
