using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class IndustryMaster
{
    public int IndustryId { get; set; }

    public string? IndustryName { get; set; }

    public int? ParentIndustryId { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Lead> Leads { get; } = new List<Lead>();
}
