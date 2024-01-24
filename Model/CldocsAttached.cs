using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CldocsAttached
{
    public int CourierDocDetailId { get; set; }

    public int CourierDocId { get; set; }

    public int DocumetId { get; set; }

    public bool? IsAttached { get; set; }
}
