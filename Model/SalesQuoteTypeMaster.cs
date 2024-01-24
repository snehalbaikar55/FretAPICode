using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class SalesQuoteTypeMaster
{
    public int SalesQuoteTypeId { get; set; }

    public string? SalesQuoteType { get; set; }

    public int? AssociatedShipmentTypeId { get; set; }

    public bool IsActive { get; set; }
}
