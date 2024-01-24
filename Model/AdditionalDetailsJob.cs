using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class AdditionalDetailsJob
{
    public int AdditionalDetailsId { get; set; }

    public int CargoId { get; set; }

    public int AdditionalInfoId { get; set; }

    public string AdditionalInfoName { get; set; } = null!;

    public string? AdditionalInfoNotes { get; set; }

    public string? AdditionalInfoNotes1 { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public int? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }
}
