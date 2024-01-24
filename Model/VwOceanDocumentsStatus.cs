using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwOceanDocumentsStatus
{
    public int? CargoId { get; set; }

    public string? JobNo { get; set; }

    public string AgentHbl { get; set; } = null!;

    public string AgentMbl { get; set; } = null!;

    public string CertificateOfInsurance { get; set; } = null!;

    public string CertificateOfOrigin { get; set; } = null!;

    public string CommercialInvoice { get; set; } = null!;

    public string DebitNote { get; set; } = null!;

    public string FreightInvoice { get; set; } = null!;

    public string Hbl { get; set; } = null!;

    public string Mbl { get; set; } = null!;

    public string Invoice { get; set; } = null!;

    public string Sop { get; set; } = null!;

    public string PackingList { get; set; } = null!;

    public string Msds { get; set; } = null!;

    public string Iip { get; set; } = null!;

    public string DgDeclaration { get; set; } = null!;

    public string VendorBill { get; set; } = null!;

    public string TransportBill { get; set; } = null!;

    public string BookingCopy { get; set; } = null!;

    public string BlFirstPrint { get; set; } = null!;

    public string BlInstructions { get; set; } = null!;

    public string ShippingBill { get; set; } = null!;

    public string EpCopy { get; set; } = null!;

    public string ArrivalNotice { get; set; } = null!;

    public string Can { get; set; } = null!;

    public string Do { get; set; } = null!;

    public string LcCopy { get; set; } = null!;

    public string EnsDeclaration { get; set; } = null!;

    public string PreAlert { get; set; } = null!;
}
