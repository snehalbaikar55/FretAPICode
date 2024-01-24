using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class DocumentMaster
{
    public int DocumentId { get; set; }

    public string? DocumentName { get; set; }

    public string? DocumentType { get; set; }

    public string? ShipmentType { get; set; }

    public bool? IsActive { get; set; }

    public bool IsVisibleToCustomer { get; set; }
}
