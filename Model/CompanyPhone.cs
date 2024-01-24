using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CompanyPhone
{
    public int PhoneId { get; set; }

    public int CountryId { get; set; }

    public int PhoneTypeId { get; set; }

    public int CompanyId { get; set; }

    public int? ContactId { get; set; }

    public string? PhoneReference { get; set; }

    public string? CountryName { get; set; }

    public string? Stdcode { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Extension { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Company Company { get; set; } = null!;
}
