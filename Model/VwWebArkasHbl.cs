using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwWebArkasHbl
{
    public int? Hblid { get; set; }

    public int? CargoId { get; set; }

    public string? JobNo { get; set; }

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public string? OriginAgent { get; set; }

    public string? DestinationAgent { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }
}
