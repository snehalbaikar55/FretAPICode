using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class WebUserAccess
{
    public int WebUserAccessId { get; set; }

    public int WebUserId { get; set; }

    public int WebUserCompanyId { get; set; }

    public virtual WebUser WebUser { get; set; } = null!;
}
