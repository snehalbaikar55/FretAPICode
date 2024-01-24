using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class FinancialYearMaster
{
    public int FinancialYearId { get; set; }

    public string? FinancialYearName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
