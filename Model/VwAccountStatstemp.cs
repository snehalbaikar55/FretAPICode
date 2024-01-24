using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwAccountStatstemp
{
    public string? InvoiceNumber { get; set; }

    public string? JobNumber { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? CompanyName { get; set; }

    public decimal? InvoiceAmount { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? AmountInr { get; set; }

    public string? TransportDirection { get; set; }

    public string? Country { get; set; }
}
