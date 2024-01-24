using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwRingplusLineExRate
{
    public int InvoiceId { get; set; }

    public DateTime InvoiceDate { get; set; }

    public string Invoicenumber { get; set; } = null!;

    public string? Jobno { get; set; }

    public decimal? Usd { get; set; }

    public decimal? Eur { get; set; }

    public decimal? Inr { get; set; }
}
