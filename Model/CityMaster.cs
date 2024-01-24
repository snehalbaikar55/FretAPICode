using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CityMaster
{
    public int CityId { get; set; }

    public int StateId { get; set; }

    public string? CityName { get; set; }

    public virtual ICollection<CompanyAddress> CompanyAddresses { get; } = new List<CompanyAddress>();

    public virtual CountryStateMaster State { get; set; } = null!;
}
