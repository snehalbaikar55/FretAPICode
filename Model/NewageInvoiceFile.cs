using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class NewageInvoiceFile
{
    public string? JobNo { get; set; }

    public string? Pod { get; set; }

    public string? Invoiceid { get; set; }

    public string? Invtype { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? PayingParty { get; set; }

    public string? InvoiceAmount { get; set; }

    public string? CurrencyCode { get; set; }

    public string? PaymentReceivedOn { get; set; }

    public string? Memo { get; set; }

    public string? FilesName { get; set; }

    public string? FretrackFilesName { get; set; }
}
