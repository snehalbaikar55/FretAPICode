using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwDsrMeeting
{
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? CompanyName { get; set; }

    public string? Type { get; set; }

    public string? ContactName { get; set; }

    public string? Title { get; set; }

    public string? Area { get; set; }

    public string? Purpose { get; set; }

    public string? Comments { get; set; }

    public string? AppontmentType { get; set; }

    public string? CountryName { get; set; }

    public string? StateName { get; set; }

    public string? CityName { get; set; }

    public string? Street { get; set; }

    public string? Nextstep { get; set; }

    public string? UserName { get; set; }
}
