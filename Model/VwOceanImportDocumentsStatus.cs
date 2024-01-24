using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwOceanImportDocumentsStatus
{
    public int? CargoId { get; set; }

    public string? JobNo { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string CommercialInvoice { get; set; } = null!;

    public string PackingList { get; set; } = null!;

    public string DebitNote { get; set; } = null!;

    public string Hbl { get; set; } = null!;

    public string Mbl { get; set; } = null!;

    public string Invoice { get; set; } = null!;

    public string Sop { get; set; } = null!;

    public string VendorBill { get; set; } = null!;

    public string TransportBill { get; set; } = null!;

    public string Can { get; set; } = null!;

    public string Do { get; set; } = null!;
}
