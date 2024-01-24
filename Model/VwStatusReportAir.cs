using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwStatusReportAir
{
    public string? User { get; set; }

    public string? JobNo { get; set; }

    public string? BillingPatry { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public DateTime? PreAlertSentOn { get; set; }

    public DateTime? DueDatePreAlert { get; set; }

    public int? AgeingPreAlert { get; set; }

    public DateTime? CourierSentOn { get; set; }

    public DateTime? DueDateCourierSent { get; set; }

    public int? AgeingCourierSent { get; set; }

    public DateTime? ClearanceDone { get; set; }

    public DateTime? ClearanceBillReceived { get; set; }

    public DateTime? DueDateClearanceDone { get; set; }

    public DateTime? InvoiceRaisedOn { get; set; }

    public DateTime? InvoiceAttachedOn { get; set; }
}
