using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwSalesQuoteStatus
{
    public string SalesQuoteNumber { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public int? Won { get; set; }

    public int? Lost { get; set; }

    public int? Pending { get; set; }
}
