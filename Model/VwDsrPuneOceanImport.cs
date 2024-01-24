using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwDsrPuneOceanImport
{
    public string? User { get; set; }

    public string? JobNo { get; set; }

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Salesperson { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public int? _20gp { get; set; }

    public int? _20hc { get; set; }

    public int? _20ot { get; set; }

    public int? _20ft { get; set; }

    public int? _40gp { get; set; }

    public int? _40hc { get; set; }

    public int? _40ot { get; set; }

    public int? _40ft { get; set; }

    public string? OceanCarrierName { get; set; }

    public string? CarrierAgent { get; set; }

    public string? VesselName { get; set; }

    public string? ContainerNo { get; set; }

    public string? OriginAgent { get; set; }

    public string? DestinationAgent { get; set; }

    public string? ShipperInvoiceDetails { get; set; }

    public string? InvoiceNo { get; set; }

    public string? InvoiceDate { get; set; }

    public DateTime? Jobdate { get; set; }

    public int CargoId { get; set; }

    public DateTime? BookingRequestDocumentsReceivedFromCustomer { get; set; }

    public DateTime? BookingRequestToLiner { get; set; }

    public DateTime? BookingConfirmedByLiner { get; set; }

    public DateTime? BookingIssuedToCustomer { get; set; }

    public DateTime? ContainerPickedUpByCustomer { get; set; }

    public DateTime? LoadingListSentToLiner { get; set; }

    public DateTime? SiIssuedFromCustomer { get; set; }

    public DateTime? SiSubmissionToTheLiner { get; set; }

    public DateTime? BlFirstPrintReceivedFromLiner { get; set; }

    public DateTime? DebitNoteReceivedFromLiner { get; set; }

    public DateTime? ShippedOnBoard { get; set; }

    public DateTime? VesselDeparture { get; set; }

    public DateTime? CostSheetApprovalLockDate { get; set; }

    public DateTime? CostSheetHandedOverToAccounts { get; set; }

    public DateTime? InvoiceGenerationDate { get; set; }

    public DateTime? InvoiceIssuedToCustomer { get; set; }

    public DateTime? BlIssuedToCustomer { get; set; }

    public DateTime? PreAlertSentToAgent { get; set; }

    public DateTime? VesselArrivalAtDestination { get; set; }

    public DateTime? DestinationCustomsHold { get; set; }

    public DateTime? DeliveryOrderSentByDestinationAgent { get; set; }

    public DateTime? DestinationCustomsCleared { get; set; }

    public DateTime? PickedUpByCustomerAgent { get; set; }

    public DateTime? Delivered { get; set; }

    public DateTime? ShipmentClosed { get; set; }
}
