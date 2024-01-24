using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwCompanyShipmentCount
{
    public int CompanyId { get; set; }

    public string Customer { get; set; } = null!;

    public string? Salesperson { get; set; }

    public int? Ocean { get; set; }

    public int? Air { get; set; }

    public DateTime? FirstShipmentDate { get; set; }

    public DateTime? LastShipmentDate { get; set; }
}
