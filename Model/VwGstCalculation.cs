using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwGstCalculation
{
    public decimal? CgstRate { get; set; }

    public decimal? CgstAmount { get; set; }

    public decimal? SgstRate { get; set; }

    public decimal? SgstAmount { get; set; }

    public decimal? IgstRate { get; set; }

    public decimal? IgstAmount { get; set; }

    public int InvoiceLineItemId { get; set; }
}
