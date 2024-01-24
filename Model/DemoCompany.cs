using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class DemoCompany
{
    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? DisplayName { get; set; }

    public int? CompanyTypeId { get; set; }

    public string? CompanyTypeName { get; set; }

    public int? ParentCompanyId { get; set; }

    public string? ParentCompanyName { get; set; }

    public string? GstNumber { get; set; }

    public string? GstType { get; set; }

    public string? PlaceOfSupply { get; set; }

    public string? Website { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? CreatedBy { get; set; }
}
