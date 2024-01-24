using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Cargo
{
    public int CargoId { get; set; }

    public string? CargoNumber { get; set; }

    public string? JobNo { get; set; }

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public string? ModeOfTransport { get; set; }

    public string? TransportDirection { get; set; }

    public bool IsConsolidation { get; set; }

    public int? IncoTermId { get; set; }

    public int? TypeOfMoveId { get; set; }

    public int? PickupAddressId { get; set; }

    public int? DeliveryAddressId { get; set; }

    public int? OpportunityId { get; set; }

    public string? CustomerReference { get; set; }

    public int? Polid { get; set; }

    public string? Pol { get; set; }

    public int? Podid { get; set; }

    public string? Pod { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public int? ShipperId { get; set; }

    public int? ShipperAddressId { get; set; }

    public string? Shipper { get; set; }

    public int? ConsigneeId { get; set; }

    public int? ConsigneeAddressId { get; set; }

    public string? Consignee { get; set; }

    public int? NotifyParty1Id { get; set; }

    public int? NotifyParty1AddressId { get; set; }

    public string? NotifyParty1 { get; set; }

    public int? NotifyParty2Id { get; set; }

    public int? NotifyParty2AddressId { get; set; }

    public int? ForwarderId { get; set; }

    public int? ForwardedAddressId { get; set; }

    public int? OriginAgentId { get; set; }

    public int? OriginAgentAddressId { get; set; }

    public int? DestinationAgentId { get; set; }

    public int? DestinationAgentAddressId { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CustomerId { get; set; }

    public string? CargoApprovalStatus { get; set; }

    public string? CargoSopapprovalStatus { get; set; }

    public int? OfficeId { get; set; }

    public string? FreightStatus { get; set; }

    public string? PaymentTerms { get; set; }

    public string? InvoicingParty { get; set; }

    public int? JobType { get; set; }

    public bool? IsHblnoautogenerate { get; set; }

    public int? SalesQuoteId { get; set; }

    public bool? IsLocked { get; set; }

    public int? LockedBy { get; set; }

    public DateTime? LockedDate { get; set; }

    public string? HblTerm { get; set; }

    public string? MblTerm { get; set; }

    public string? HblStatus { get; set; }

    public string? MblStatus { get; set; }

    public string? FreeDays { get; set; }

    public string? Por { get; set; }

    public bool? IsGstJob { get; set; }

    public virtual ICollection<CargoContainer> CargoContainers { get; } = new List<CargoContainer>();

    public virtual ICollection<CargoPackage> CargoPackages { get; } = new List<CargoPackage>();

    public virtual ICollection<CargoStatus> CargoStatuses { get; } = new List<CargoStatus>();

    public virtual ICollection<CargoTask> CargoTasks { get; } = new List<CargoTask>();
}
