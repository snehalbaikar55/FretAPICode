using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Contact
{
    public int ContactId { get; set; }

    public int CompanyId { get; set; }

    public int? ContactTypeId { get; set; }

    public string? Salutation { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? DisplayName { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? Phone { get; set; }

    public string? Department { get; set; }

    public int? ReportsTo { get; set; }

    public int? AddressId { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? Dob { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<UserMaster> UserMasters { get; } = new List<UserMaster>();
}
