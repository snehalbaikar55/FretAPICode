using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwXingdaReportMumbai
{
    public string? Plant { get; set; }

    public string? JobNo { get; set; }

    public int? _40hc { get; set; }

    public int? _20gp { get; set; }

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

    public string? SbnoOutput { get; set; }

    public string? SbdateOutput { get; set; }

    public DateTime? CargoPickupDate { get; set; }

    public DateTime? ArrivalDateIntoCfs { get; set; }

    public DateTime? CustomsClearanceDate { get; set; }

    public DateTime? StuffingDateAtCfs { get; set; }

    public string? ContainerNos { get; set; }

    public DateTime? ShipperInformDate { get; set; }
}
