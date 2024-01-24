using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwChennaiSalesJob
{
    public string? Salesperson { get; set; }

    public string? JobNo { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }
}
