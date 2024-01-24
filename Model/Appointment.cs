using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Appointment
{
    public int UniqueId { get; set; }

    public int? Type { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? AllDay { get; set; }

    public string? Subject { get; set; }

    public string? Location { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public int? Label { get; set; }

    public int? ResourceId { get; set; }

    public string? ResourceIds { get; set; }

    public string? ReminderInfo { get; set; }

    public string? RecurrenceInfo { get; set; }

    public string? CustomField1 { get; set; }

    public int? CompanyId { get; set; }

    public int? ContactId { get; set; }

    public string? Purpose { get; set; }

    public int? Createdby { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Createddate { get; set; }

    public DateTime? Modifieddate { get; set; }

    public string? ContactName { get; set; }

    public string? AppontmentType { get; set; }

    public int? CompanyAddressId { get; set; }

    public string? Nextstep { get; set; }
}
