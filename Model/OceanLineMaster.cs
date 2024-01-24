using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class OceanLineMaster
{
    public int OceanLineId { get; set; }

    public string? OceanLineCode { get; set; }

    public string? LineCallSign { get; set; }

    public string? LineCompanyName { get; set; }

    public int? LineOwnerCountry { get; set; }

    public bool IsActive { get; set; }

    public string? Scaccode { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }
}
