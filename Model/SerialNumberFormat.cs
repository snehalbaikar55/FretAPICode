using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class SerialNumberFormat
{
    public int SerialFormatId { get; set; }

    public string? SerialFormatDescription { get; set; }

    public string? SerialFormat { get; set; }

    public int? TotalLength { get; set; }

    public int OfficeId { get; set; }

    public int CounterId { get; set; }

    public string ResetEvery { get; set; } = null!;

    public DateTime? NextReset { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public virtual CounterMaster Counter { get; set; } = null!;
}
