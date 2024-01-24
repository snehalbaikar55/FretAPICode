using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CargoHbl
{
    public int Hblid { get; set; }

    public int CargoId { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? DocumentType { get; set; }

    public string? Mblnumber { get; set; }

    public string? Hblnumber { get; set; }

    public string? DocumentNumber { get; set; }

    public int? ShipperAddressId { get; set; }

    public string? ShipperName { get; set; }

    public string? ShipperAddress { get; set; }

    public int? ConsigneeAddressId { get; set; }

    public string? ConsigneeName { get; set; }

    public string? ConsigneeAddress { get; set; }

    public int? NotifyAddressId { get; set; }

    public string? NotifyName { get; set; }

    public string? NotifyAddress { get; set; }

    public string? ExportReferences { get; set; }

    public int? ForwardingAgentAddressId { get; set; }

    public string? ForwardingAgent { get; set; }

    public string? ForwardingAgentAddress { get; set; }

    public string? PointOfOriginFtz { get; set; }

    public string? DeliveryInstructions { get; set; }

    public string? PreCarriageBy { get; set; }

    public string? PlaceOfReceipt { get; set; }

    public string? VesselVoyage { get; set; }

    public string? PortOfLoading { get; set; }

    public string? PortOfDischarge { get; set; }

    public string? PlaceOfDelivery { get; set; }

    public string? LoadingTerminal { get; set; }

    public string? TypeOfMove { get; set; }

    public bool? IsContainerized { get; set; }

    public string? MarksandNumbers { get; set; }

    public string? NoOfPackages { get; set; }

    public string? DescriptionOfPackagesGoods { get; set; }

    public string? GrossWeight { get; set; }

    public string? Measurement { get; set; }

    public string? DeclaredValue { get; set; }

    public DateTime? Hbldate { get; set; }

    public string? Hblplace { get; set; }

    public string? ByAgentForCarrier { get; set; }

    public string? FreightCharges { get; set; }

    public string? Description1 { get; set; }

    public string? Description2 { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public string? ForeignPortUnloading { get; set; }

    public string? TotalCp { get; set; }

    public string? Movement { get; set; }

    public decimal? OriginIhc { get; set; }

    public decimal? OriginThc { get; set; }

    public decimal? DestinationIhc { get; set; }

    public decimal? DestinationThc { get; set; }

    public decimal? OceanFreight { get; set; }

    public string? Blby { get; set; }
}
