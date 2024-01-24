using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class JobVendorDetail
{
    public int JobVendorDetailId { get; set; }

    public int? CargoId { get; set; }

    public string VendorBillNumber { get; set; } = null!;

    public DateTime? VendorBillDate { get; set; }

    public decimal? VendorBillAmount { get; set; }

    public string VendorBillAmountText { get; set; } = null!;

    public int? VendorId { get; set; }

    public string? VendorName { get; set; }
}
