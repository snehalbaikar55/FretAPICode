using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwVendorBill
{
    public string? JobNo { get; set; }

    public string? VendorBillNumber { get; set; }

    public DateTime? VendorBillDate { get; set; }

    public string? PayingParty { get; set; }

    public decimal? VendorBillAmount { get; set; }

    public decimal? TaxAmount { get; set; }

    public string? BillStatus { get; set; }

    public string? Remarks { get; set; }

    public int? CargoDocumentId { get; set; }

    public string? BillUploaded { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }
}
