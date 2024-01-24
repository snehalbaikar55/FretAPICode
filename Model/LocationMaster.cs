using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class LocationMaster
{
    public int LocationId { get; set; }

    public string LocationType { get; set; } = null!;

    public string LocationCode { get; set; } = null!;

    public string LocationShortName { get; set; } = null!;

    public string LocationLongName { get; set; } = null!;

    public int CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public int? StateId { get; set; }

    public string? StateName { get; set; }

    public int? CityId { get; set; }

    public string? CityName { get; set; }

    public string? ScheduleD { get; set; }

    public string? ScheduleK { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<CompanyAddress> CompanyAddressRelatedAirports { get; } = new List<CompanyAddress>();

    public virtual ICollection<CompanyAddress> CompanyAddressRelatedPorts { get; } = new List<CompanyAddress>();
}
