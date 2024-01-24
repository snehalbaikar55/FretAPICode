using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CountryMaster
{
    public int CountryId { get; set; }

    public string? CountryCode { get; set; }

    public string? CountryName { get; set; }

    public string? ContinentName { get; set; }

    public virtual ICollection<CompanyAddress> CompanyAddresses { get; } = new List<CompanyAddress>();

    public virtual ICollection<CountryStateMaster> CountryStateMasters { get; } = new List<CountryStateMaster>();

    public virtual ICollection<Lead> Leads { get; } = new List<Lead>();
}
