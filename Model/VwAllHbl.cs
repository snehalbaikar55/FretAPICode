using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwAllHbl
{
    public int Hblid { get; set; }

    public int CargoId { get; set; }

    public string? DocumentType { get; set; }

    public string? Mblnumber { get; set; }

    public string? Hblnumber { get; set; }

    public string? DocumentNumber { get; set; }

    public string? ShipperName { get; set; }

    public string? ConsigneeName { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }
}
