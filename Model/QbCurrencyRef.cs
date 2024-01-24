using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class QbCurrencyRef
{
    public int Id { get; set; }

    public string? Value { get; set; }

    public string Name { get; set; } = null!;

    public string? Code { get; set; }

    public int Qbcompid { get; set; }
}
