using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwShipmentInvoiceGeneration
{
    public string? JobNumber { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? TransitStatus { get; set; }

    public string? ModeOfTransport { get; set; }

    public string? TransportDirection { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public int? _20gp { get; set; }

    public int? _20hc { get; set; }

    public int? _20ft { get; set; }

    public int? _20ot { get; set; }

    public int? _20rf { get; set; }

    public int? _40gp { get; set; }

    public int? _40hc { get; set; }

    public int? _40ft { get; set; }

    public int? _40ot { get; set; }

    public int? _40rf { get; set; }

    public int? _45gp { get; set; }

    public int? TotalPackages { get; set; }

    public decimal? TotalGrossWeightKgs { get; set; }

    public decimal? TotalVolumeCbm { get; set; }

    public decimal? TotalChargeable { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? Invno { get; set; }

    public string? InvoiceDate { get; set; }

    public string? Invdt { get; set; }

    public string? Mblno { get; set; }

    public string? Hblno { get; set; }

    public string? Containers { get; set; }

    public int? OfficeId { get; set; }
}
