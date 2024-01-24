using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class QbPaymentTermsRef
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public int? DueDays { get; set; }

    public int? Qbcompid { get; set; }
}
