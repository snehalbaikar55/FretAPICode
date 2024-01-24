using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwAirDocumentsStatus
{
    public int? CargoId { get; set; }

    public string? JobNo { get; set; }

    public string AgentHawb { get; set; } = null!;

    public string AgentMawb { get; set; } = null!;

    public string CargoManifest { get; set; } = null!;

    public string CertificateOfOrigin { get; set; } = null!;

    public string CommercialInvoice { get; set; } = null!;

    public string CustomInvoice { get; set; } = null!;

    public string FreightInvoice { get; set; } = null!;

    public string Hawb { get; set; } = null!;

    public string Awb { get; set; } = null!;

    public string Invoice { get; set; } = null!;

    public string Sop { get; set; } = null!;

    public string VendorInvoice { get; set; } = null!;

    public string GatePass { get; set; } = null!;

    public string ShippingBill { get; set; } = null!;

    public string Are1 { get; set; } = null!;

    public string NForm { get; set; } = null!;

    public string ExportValueDeclaration { get; set; } = null!;

    public string FormSdf { get; set; } = null!;

    public string Do { get; set; } = null!;

    public string Can { get; set; } = null!;

    public string LcCopy { get; set; } = null!;

    public string EnsDeclaration { get; set; } = null!;

    public string DgDeclaration { get; set; } = null!;

    public string PreAlert { get; set; } = null!;
}
