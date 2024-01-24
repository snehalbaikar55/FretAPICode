using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CompanyType
{
    public int CompanyTypeId { get; set; }

    public string? CompanyType1 { get; set; }

    public bool IsInternal { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Company> Companies { get; } = new List<Company>();
}
