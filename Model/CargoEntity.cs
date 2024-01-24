using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CargoEntity
{
    public int CargoEntityId { get; set; }

    public int CargoId { get; set; }

    public int? CompanyId { get; set; }

    public int? EntityTypeId { get; set; }

    public string? EntityName { get; set; }

    public int? EntityAddressId { get; set; }

    public int? EntityCountryId { get; set; }

    public string? EntityCountry { get; set; }

    public int? EntityStateId { get; set; }

    public string? EntityState { get; set; }

    public int? EntityCityId { get; set; }

    public string? EntityCity { get; set; }

    public string? EntityAddressLine1 { get; set; }

    public string? EntityZipCode { get; set; }

    public string? EntityDisplayText { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool? IsPayor { get; set; }

    public bool? IsDeleted { get; set; }
}
