using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwGoodPackXingdaReport
{
    public string? Plant { get; set; }

    public string? JobNo { get; set; }

    public int? _40hc { get; set; }

    public string? InvoiceNumber { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public int? Spools { get; set; }

    public int? Seperator { get; set; }

    public int? Pallet { get; set; }

    public string? Bl { get; set; }

    public string? Hbl { get; set; }

    public DateTime? Eta { get; set; }

    public DateTime? Ata { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Atd { get; set; }
}
