using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class PaymentTerm
{
    public int PaymentTermId { get; set; }

    public string? PaymentTerm1 { get; set; }

    public byte? DueDays { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public byte? DiscountDays { get; set; }

    public bool IsActive { get; set; }
}
