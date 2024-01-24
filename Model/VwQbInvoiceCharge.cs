using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwQbInvoiceCharge
{
    public string? ChargeDescription { get; set; }

    public decimal? ExpectedAmount { get; set; }

    public decimal? TaxPercent { get; set; }

    public int? IncomeAccountHeadId { get; set; }

    public int? ChargeHeadId { get; set; }

    public string? ChargeHeadName { get; set; }

    public string? QbchennaiId { get; set; }

    public string? QbchennaiName { get; set; }

    public string? IncomeAccountRefValue { get; set; }

    public string? IncomeAccountRefName { get; set; }
}
