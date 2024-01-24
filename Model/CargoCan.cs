using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CargoCan
{
    public string? ShipperName { get; set; }

    public string? ShipperAddress { get; set; }

    public string? ConsigneeName { get; set; }

    public string? ConsigneeAddress { get; set; }

    public string? LineName { get; set; }

    public string? LineAddress { get; set; }

    public string? Chaname { get; set; }

    public string? PackageDesc { get; set; }

    public string? NoticeNo { get; set; }

    public string? Hblno { get; set; }

    public string? Mblno { get; set; }

    public string? Pol { get; set; }

    public string? Poa { get; set; }

    public string? PkgsCont { get; set; }

    public string? WeightCbm { get; set; }

    public string? Containernos { get; set; }

    public string? Vesselvoyage { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public DateTime? Hbldate { get; set; }

    public DateTime? Mbldate { get; set; }

    public string? Imno { get; set; }

    public DateTime? Imdate { get; set; }

    public string? Lineno { get; set; }

    public string? Cfs { get; set; }

    public string? Finalagent { get; set; }

    public int Noticeid { get; set; }

    public int Cargoid { get; set; }

    public string? DocumentType { get; set; }

    public string? Cargotype { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public bool? Isdeleted { get; set; }

    public DateTime? UnstuffDate { get; set; }

    public DateTime? IgMsplitDate { get; set; }

    public string? OblNumber { get; set; }

    public DateTime? OblDate { get; set; }
}
