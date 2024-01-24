using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class QbExpenseItem
{
    public int ChargeItemId { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? FullyQualifiedName { get; set; }

    public string? Active { get; set; }

    public string? Classification { get; set; }

    public string? AccountType { get; set; }

    public string? AccountSubType { get; set; }

    public string? MetaDataCreateTime { get; set; }

    public string? MetaDataLastUpdatedTime { get; set; }

    public string? ParentRefValue { get; set; }

    public string? Description { get; set; }

    public string? TaxCodeRefValue { get; set; }

    public int? CompId { get; set; }

    public string? Location { get; set; }
}
