using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CounterMaster
{
    public int CounterId { get; set; }

    public string CounterName { get; set; } = null!;

    public int CounterValue { get; set; }

    public virtual ICollection<SerialNumberFormat> SerialNumberFormats { get; } = new List<SerialNumberFormat>();
}
