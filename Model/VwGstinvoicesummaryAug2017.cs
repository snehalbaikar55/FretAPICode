using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwGstinvoicesummaryAug2017
{
    public DateTime InvoiceDate { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public string? JobNumber { get; set; }

    public string? PayingParty { get; set; }

    public string? PayingPartyAddress { get; set; }

    public string? Gstnumber { get; set; }

    public decimal? Amount { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal? InvoiceAmount { get; set; }

    public string? CurrencyCode { get; set; }

    public string? InvoiceTypeGst { get; set; }
}
