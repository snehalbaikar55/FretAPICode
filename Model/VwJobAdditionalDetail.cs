using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwJobAdditionalDetail
{
    public int CargoId { get; set; }

    public string? IgmNoSublineNo { get; set; }

    public string? IgmSentOn { get; set; }

    public string? Remarks { get; set; }

    public string? FinalMblMawbNo { get; set; }

    public string? Cfs { get; set; }

    public string? SurrenderBlReceivedDate { get; set; }

    public string? Cha { get; set; }
}
