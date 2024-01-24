using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class QbSyncHistory
{
    public int SyncId { get; set; }

    public int? FretrackInvoiceId { get; set; }

    public string? FretrackJobNo { get; set; }

    public string? QbinvoiceId { get; set; }

    public string? FretrackInvoiceNo { get; set; }

    public DateTime SyncDate { get; set; }

    public int? SyncById { get; set; }

    public string? SyncByName { get; set; }

    public string? SyncResponse { get; set; }

    public string? SyncStatus { get; set; }

    public string? SyncType { get; set; }
}
