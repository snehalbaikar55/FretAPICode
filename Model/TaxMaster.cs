using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class TaxMaster
{
    public int TaxId { get; set; }

    public string? TaxName { get; set; }

    public string? TaxCode { get; set; }

    public int? OfficeId { get; set; }
}
