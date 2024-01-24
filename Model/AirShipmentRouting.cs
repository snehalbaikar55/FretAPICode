using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class AirShipmentRouting
{
    public int AirRoutingId { get; set; }

    public int ShipmentId { get; set; }

    public int RoutingOrder { get; set; }

    public int? AirCarrierId { get; set; }

    public string? FlightNumber { get; set; }

    public int? Polid { get; set; }

    public string? Pol { get; set; }

    public int? Podid { get; set; }

    public string? Pod { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Atd { get; set; }

    public DateTime? Eta { get; set; }

    public DateTime? Ata { get; set; }

    public int? Pot1id { get; set; }

    public string? Pot1 { get; set; }

    public DateTime? Pot1date { get; set; }

    public int? Pot2id { get; set; }

    public string? Pot2 { get; set; }

    public DateTime? Pot2date { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public bool? IsPot1 { get; set; }

    public bool? IsPot2 { get; set; }

    public string? AirCarrierName { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? BookingNumber { get; set; }

    public string? Igmno { get; set; }
}
