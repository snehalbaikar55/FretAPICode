using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class AwbchargeMaster
{
    public int AwbchargeTypeId { get; set; }

    public string? AwbchargeCode { get; set; }

    public string? AwbchargeDescription { get; set; }

    public string? DueType { get; set; }

    public string? ApplyPer { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }
}
