using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class EmailResponse
{
    public int ResponseId { get; set; }

    public int EmailId { get; set; }

    public DateTime AttemptDate { get; set; }

    public string? EmailResponse1 { get; set; }

    public string ResponseType { get; set; } = null!;

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? SourceType { get; set; }
}
