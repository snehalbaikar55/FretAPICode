using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwLeadSalesReport
{
    public string? SalesPerson { get; set; }

    public string? CompanyName { get; set; }

    public string? ContactNo { get; set; }

    public string? ContactName { get; set; }

    public string? RemarksStatus { get; set; }

    public DateTime? FolloupDate { get; set; }

    public string? Email { get; set; }

    public string? Area { get; set; }

    public string? Address { get; set; }

    public string ProfileSent { get; set; } = null!;

    public string Met { get; set; } = null!;

    public string Enquiry { get; set; } = null!;

    public string? Shipments { get; set; }

    public string? Sector { get; set; }

    public string? AttendedBy { get; set; }

    public string Quote { get; set; } = null!;

    public string Secured { get; set; } = null!;

    public int? PrimaryOfficeId { get; set; }

    public string? ResonNotSecured { get; set; }
}
