using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class UserMaster
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string? Email { get; set; }

    public int? ContactId { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public bool IsActive { get; set; }

    public int? LoginFailStreak { get; set; }

    public int? LoginFailTotal { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public int? PrimaryOfficeId { get; set; }

    public int? ProfileId { get; set; }

    public DateTime? DateLocked { get; set; }

    public int? ManagerId { get; set; }

    public string? UserDisplayName { get; set; }

    public virtual ICollection<Campaign> Campaigns { get; } = new List<Campaign>();

    public virtual Contact? Contact { get; set; }

    public virtual ICollection<Lead> Leads { get; } = new List<Lead>();

    public virtual ICollection<Opportunity> Opportunities { get; } = new List<Opportunity>();

    public virtual Company? PrimaryOffice { get; set; }

    public virtual ProfileMaster? Profile { get; set; }

    public virtual ICollection<UserOfficeAccess> UserOfficeAccesses { get; } = new List<UserOfficeAccess>();

    public virtual ICollection<UserShowCalendar> UserShowCalendars { get; } = new List<UserShowCalendar>();
}
