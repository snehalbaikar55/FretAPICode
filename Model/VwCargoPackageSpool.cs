using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwCargoPackageSpool
{
    public int CargoId { get; set; }

    public string? InvoiceNumber { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? MarksAndNumbers { get; set; }

    public int? Spools { get; set; }

    public int? Seperator { get; set; }

    public int? Pallet { get; set; }
}
