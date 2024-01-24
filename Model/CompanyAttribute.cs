using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CompanyAttribute
{
    public int CompanyAttributeId { get; set; }

    public int? LeadId { get; set; }

    public int? CompanyId { get; set; }

    public int? AttributeId { get; set; }

    public string? ModeofTransport { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }
}
