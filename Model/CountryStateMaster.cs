using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CountryStateMaster
{
    public int StateId { get; set; }

    public int CountryId { get; set; }

    public string StateName { get; set; } = null!;

    public string? StateCode { get; set; }

    public virtual ICollection<CityMaster> CityMasters { get; } = new List<CityMaster>();

    public virtual ICollection<CompanyAddress> CompanyAddresses { get; } = new List<CompanyAddress>();

    public virtual CountryMaster Country { get; set; } = null!;
}
