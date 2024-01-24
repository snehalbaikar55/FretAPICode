using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class GstTypeMaster
{
    public int GsttypeId { get; set; }

    public string GstregType { get; set; } = null!;

    public string? QbGsttype { get; set; }

    public string? ZohoGsttype { get; set; }

    public string? GssttypeDescription { get; set; }
}
