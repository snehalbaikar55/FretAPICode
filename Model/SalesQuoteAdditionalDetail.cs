using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class SalesQuoteAdditionalDetail
{
    public int SalesQuoteId { get; set; }

    public string? Introduction { get; set; }

    public string? Conditions { get; set; }

    public string? Conclusion { get; set; }

    public virtual SalesQuote SalesQuote { get; set; } = null!;
}
