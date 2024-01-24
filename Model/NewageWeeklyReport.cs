using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class NewageWeeklyReport
{
    public int Id { get; set; }

    public string? Jobno { get; set; }

    public string? Pod { get; set; }

    public string? Shipper { get; set; }

    public string? BookingIssueDate { get; set; }

    public string? BookingNo { get; set; }

    public string? Container { get; set; }

    public string? Type { get; set; }

    public string? HblNo { get; set; }

    public string? VesselName { get; set; }

    public string? Etd { get; set; }

    public string? EtaSavannah { get; set; }

    public string? EtdSavannah { get; set; }

    public string? GateOutFromTerminal { get; set; }

    public string? DeliveryDtMtyReturn { get; set; }

    public string? Remark { get; set; }

    public string? Status { get; set; }
}
