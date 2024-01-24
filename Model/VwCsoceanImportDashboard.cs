using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwCsoceanImportDashboard
{
    public int CargoId { get; set; }

    public string? JobNo { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? OriginAgent { get; set; }

    public string? ContainerNo { get; set; }

    public string? OceanLine { get; set; }

    public string? Vessel { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public string? Cycle { get; set; }

    public DateTime? PreAlertDate { get; set; }

    public DateTime? InvoiceHandover { get; set; }

    public DateTime? ManifestSubmission { get; set; }

    public DateTime? Dosent { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public string? CargoSopapprovalStatus { get; set; }

    public int? OfficeId { get; set; }

    public string? AccountName { get; set; }

    public int? AccountId { get; set; }

    public int? _20gp { get; set; }

    public int? _20hc { get; set; }

    public int? _40gp { get; set; }

    public int? _40hc { get; set; }
}
