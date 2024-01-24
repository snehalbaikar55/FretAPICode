using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class AirlineMaster
{
    public int AirlineId { get; set; }

    public string? AirlineName { get; set; }

    public string? A2code { get; set; }

    public string? A3code { get; set; }

    public int CountryId { get; set; }

    public string? N3code { get; set; }

    public bool IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }
}
