using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class OceanShipmentRouting
{
    public int OceanRoutingId { get; set; }

    public int ShipmentId { get; set; }

    public int LegNumber { get; set; }

    public int Polid { get; set; }

    public string Pol { get; set; } = null!;

    public int Podid { get; set; }

    public string Pod { get; set; } = null!;

    public DateTime? Etd { get; set; }

    public DateTime? Atd { get; set; }

    public DateTime? Eta { get; set; }

    public DateTime? Ata { get; set; }

    public int? LoadingTerminalId { get; set; }

    public string? LoadingTerminalName { get; set; }

    public int? UnloadingTerminalId { get; set; }

    public string? UnloadingTerminalName { get; set; }

    public int? OceanCarrierId { get; set; }

    public string? OceanCarrierName { get; set; }

    public int? ContainerAgentId { get; set; }

    public int? VesselId { get; set; }

    public string? VesselName { get; set; }

    public int? VesselFlagId { get; set; }

    public string? VesselFlagName { get; set; }

    public string? LlyodsCode { get; set; }

    public string? VoyageNumber { get; set; }

    public string? Imonumber { get; set; }

    public DateTime? DocumentCutoffDate { get; set; }

    public DateTime? GatesClosingDate { get; set; }

    public bool? IsPot1 { get; set; }

    public int? Pot1id { get; set; }

    public string? Pot1 { get; set; }

    public bool? IsPot2 { get; set; }

    public int? Pot2id { get; set; }

    public string? Pot2 { get; set; }

    public string? BookingNumber { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? InttrarefNo { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public string? BuiltYear { get; set; }

    public int? CarrierAgentId { get; set; }

    public string? CarrierAgent { get; set; }

    public DateTime? BlinstructionCutoff { get; set; }

    public DateTime? LoadingDate { get; set; }

    public string? PlaceOfLoading { get; set; }

    public string? PlaceOfFinalDestination { get; set; }

    public DateTime? Transhipment1Eta { get; set; }

    public DateTime? Transhipment1Etd { get; set; }

    public string? Transhipment1Vessel { get; set; }

    public DateTime? Transhipment2Eta { get; set; }

    public DateTime? Transhipment2Etd { get; set; }

    public string? Transhipment2Vessel { get; set; }

    public string? ArrivalNoticeTo { get; set; }

    public string? BookingTo { get; set; }

    public string? BookingLoadingPlace { get; set; }

    public string? BookingTrucking { get; set; }

    public DateTime? BookingWarehousePickupDate { get; set; }

    public string? BookingNotes { get; set; }

    public string? BookingContainerCount { get; set; }

    public string? BookingCommodity { get; set; }

    public string? BookingPayableAt { get; set; }

    public string? BookingOceanFreight { get; set; }

    public string? BookingPortCharges { get; set; }

    public string? BookingBlcost { get; set; }

    public string? BookingTruckingCost { get; set; }

    public string? BookingLcno { get; set; }

    public string? BookingOrderNo { get; set; }
}
