using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CurrencyMaster
{
    public int CurrencyId { get; set; }

    public int CountryId { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrencyName { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<ChargeAttribute> ChargeAttributes { get; } = new List<ChargeAttribute>();

    public virtual ICollection<Opportunity> Opportunities { get; } = new List<Opportunity>();
}
