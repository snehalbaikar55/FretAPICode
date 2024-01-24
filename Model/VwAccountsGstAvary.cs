using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwAccountsGstAvary
{
    public int InvoiceId { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public decimal? InvoiceAmount { get; set; }

    public DateTime InvoiceDate { get; set; }

    public string? PayingParty { get; set; }

    public int? PayingPartyId { get; set; }

    public string? Gstnumber { get; set; }

    public string? StateName { get; set; }

    public decimal? TaxableValue { get; set; }

    public decimal? TaxPercent { get; set; }

    public decimal? Igst { get; set; }

    public decimal? CentralTax { get; set; }

    public decimal? StateTax { get; set; }

    public string? InvoiceTypeGst { get; set; }
}
