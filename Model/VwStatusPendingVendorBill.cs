using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwStatusPendingVendorBill
{
    public string? JobNo { get; set; }

    public string? VendorBillNumber { get; set; }

    public string? PayingParty { get; set; }

    public string? CostsheetVendor { get; set; }

    public string BillStatus { get; set; } = null!;

    public decimal? VendorBillAmount { get; set; }

    public DateTime? VendorBillDate { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public DateTime? Eta { get; set; }

    public DateTime? Etd { get; set; }

    public string? ModeOfShipment { get; set; }

    public DateTime? Ata { get; set; }

    public DateTime? Atd { get; set; }
}
