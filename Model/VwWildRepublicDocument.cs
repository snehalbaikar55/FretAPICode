using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwWildRepublicDocument
{
    public string? JobNo { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public DateTime? PackingList { get; set; }

    public DateTime? CommercialInvoice { get; set; }

    public DateTime? Invoice { get; set; }

    public DateTime? Mbl { get; set; }

    public DateTime? Hbl { get; set; }
}
