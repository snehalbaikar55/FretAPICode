using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CompanyAddress
{
    public int CompanyAddressId { get; set; }

    public int CompanyId { get; set; }

    public int? ContactId { get; set; }

    public int AddressTypeId { get; set; }

    public string? AddressTypeNick { get; set; }

    public int CountryId { get; set; }

    public string Country { get; set; } = null!;

    public int? StateId { get; set; }

    public string? StateName { get; set; }

    public int? CityId { get; set; }

    public string? CityName { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? Zipcode { get; set; }

    public int? RelatedPortId { get; set; }

    public int? RelatedAirportId { get; set; }

    public string? FormattedAddress { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Faxnumber { get; set; }

    public string? Gstnumber { get; set; }

    public virtual CityMaster? City { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual CountryMaster CountryNavigation { get; set; } = null!;

    public virtual LocationMaster? RelatedAirport { get; set; }

    public virtual LocationMaster? RelatedPort { get; set; }

    public virtual CountryStateMaster? State { get; set; }
}
