using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CompanyReportGrouping
{
    public int? DuplicateCompanyId { get; set; }

    public int? ActualComanyId { get; set; }

    public string? CompanyDisplayName { get; set; }

    public DateTime? CompanyStartDate { get; set; }
}
