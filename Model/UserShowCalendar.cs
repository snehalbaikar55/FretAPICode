using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class UserShowCalendar
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ShowCalendarTo { get; set; }

    public int? UserShowCalendarIdPk { get; set; }

    public virtual UserMaster User { get; set; } = null!;
}
