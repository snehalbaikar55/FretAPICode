using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class TaxManual
{
    public int TaxManualId { get; set; }

    public int? ChargeItemId { get; set; }
}
