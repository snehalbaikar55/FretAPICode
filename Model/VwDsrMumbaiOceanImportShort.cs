using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwDsrMumbaiOceanImportShort
{
    public string? JobNo { get; set; }

    public string Note { get; set; } = null!;

    public DateTime? JobDate { get; set; }

    public string? MblNo { get; set; }

    public string? FinalMblNo { get; set; }

    public string? HblNo { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Origin { get; set; }

    public string? Destination { get; set; }

    public int? Pkg { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Cbm { get; set; }

    public string? VesselName { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? IgmNoSublineNo { get; set; }

    public DateTime? IgmSplitDate { get; set; }

    public DateTime? IgmInwardDate { get; set; }

    public string? Cfs { get; set; }

    public string Destuffing { get; set; } = null!;

    public string? ContainerNo { get; set; }

    public string? Carrier { get; set; }

    public string TypeOfShipment { get; set; } = null!;
}
