using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class InvoiceListNewAge
{
    public int InvoiceLineId { get; set; }

    public int? InvoiceId { get; set; }

    public int? CargoId { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public DateTime? InvoiceDate { get; set; }

    public string TransactionType { get; set; } = null!;

    public string? Name { get; set; }

    public string JobNumber { get; set; } = null!;

    public decimal? ForeignAmount { get; set; }

    public string? CurrencyCode { get; set; }

    public string? Memo { get; set; }

    public DateTime? PaymentReceivedOn { get; set; }

    public string? FilePath { get; set; }
}
