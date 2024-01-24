﻿using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class UsedAirport
{
    public string? Country { get; set; }

    public string? CountryName { get; set; }

    public string? Location { get; set; }

    public string? NameWoDiacritics { get; set; }

    public string? StateCode { get; set; }

    public string? StateName { get; set; }

    public string? AirportLongName { get; set; }

    public string? ScheduleD { get; set; }

    public string? ScheduleK { get; set; }
}
