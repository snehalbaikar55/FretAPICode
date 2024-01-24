using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwWildRepublicStatus
{
    public int CargoId { get; set; }

    public DateTime? BookingDate { get; set; }

    public DateTime? VesselDeparture { get; set; }

    public DateTime? VesselArrival { get; set; }

    public DateTime? CustomClearanceDate { get; set; }

    public DateTime? Delivered { get; set; }
}
