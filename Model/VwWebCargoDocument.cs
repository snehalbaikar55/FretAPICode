using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwWebCargoDocument
{
    public int CargoDocumentId { get; set; }

    public int? CargoId { get; set; }

    public string? DocumentType { get; set; }

    public string? Remarks { get; set; }

    public string? Ftplink { get; set; }

    public bool IsVisibleToCustomer { get; set; }
}
