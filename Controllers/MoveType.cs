using System;
using System.Collections.Generic;

namespace FretCloudAPI.Model;

public partial class MoveType
{
    public int TypeOfMoveId { get; set; }

    public string TypeOfMove { get; set; } = null!;

    public bool? IsActive { get; set; }

    public bool? IsPickup { get; set; }

    public bool? IsDelivery { get; set; }
}
