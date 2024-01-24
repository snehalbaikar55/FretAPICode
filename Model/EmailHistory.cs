using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class EmailHistory
{
    public int EmailHistoryId { get; set; }

    public string EmailFrom { get; set; } = null!;

    public string? EmailTo { get; set; }

    public string? EmailCc { get; set; }

    public string? EmailBcc { get; set; }

    public string EmailSubject { get; set; } = null!;

    public string? EmailBodyHtml { get; set; }

    public string? EmailBodyText { get; set; }

    public bool IsHtml { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? EmailType { get; set; }

    public int? EmailReferenceId { get; set; }

    public string? EmailReference { get; set; }

    public bool IsSent { get; set; }

    public DateTime? SentDate { get; set; }

    public int? AttemptCount { get; set; }

    public string? SendResponse { get; set; }
}
