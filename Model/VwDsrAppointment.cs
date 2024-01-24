using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwDsrAppointment
{
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? CompanyName { get; set; }

    public string? Type { get; set; }

    public string? ContactName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Area { get; set; }

    public string? Comments { get; set; }

    public string? Purpose { get; set; }

    public string? Createdby { get; set; }

    public string? AppontmentType { get; set; }

    public int? Userid { get; set; }
}
