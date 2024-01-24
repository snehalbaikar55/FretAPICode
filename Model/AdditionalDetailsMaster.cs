using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class AdditionalDetailsMaster
{
    public int AdditionalInfoId { get; set; }

    public string AdditionalInfoName { get; set; } = null!;

    public bool? IsActive { get; set; }
}
