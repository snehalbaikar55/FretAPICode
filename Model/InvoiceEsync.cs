using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class InvoiceEsync
{
    public int SyncId { get; set; }

    public int InvoiceId { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public string AckNo { get; set; } = null!;

    public DateTime AckDt { get; set; }

    public string IrnNo { get; set; } = null!;

    public string SignedInvoice { get; set; } = null!;

    public string SignedQrcode { get; set; } = null!;

    public int? SyncedBy { get; set; }

    public DateTime? SyncDate { get; set; }

    public string SyncResponse { get; set; } = null!;
}
