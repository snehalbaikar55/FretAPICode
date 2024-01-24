using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class QbChargeItem
{
    public int ChargeItemId { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? TaxClass { get; set; }

    public string? IncomeAccountRefValue { get; set; }

    public string? IncomeAccountRefName { get; set; }

    public string? Description { get; set; }

    public string? FullyQualifiedName { get; set; }

    public string? TaxClassificationRefName { get; set; }

    public string? MetaDataCreateTime { get; set; }

    public string? MetaDataLastUpdatedTime { get; set; }

    public int? CompId { get; set; }

    public string? Location { get; set; }
}
