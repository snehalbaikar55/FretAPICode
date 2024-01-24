using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class UsedAirline
{
    public int AirlineId { get; set; }

    public string? A2code { get; set; }

    public string? A3code { get; set; }

    public string? AirlineName { get; set; }

    public string? Country { get; set; }

    public string? N3code { get; set; }

    public byte IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifyBy { get; set; }

    public DateTime? ModifyDate { get; set; }
}
