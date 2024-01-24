using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwStatusOceanExportCc
{
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

    public DateTime? CustomsClearanceCompleted { get; set; }

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

    public DateTime? ClearanceBillReceived { get; set; }

    public DateTime? ClearanceDone { get; set; }

    public DateTime? DduDdpClearance { get; set; }

    public DateTime? DestinationDnReceived { get; set; }

    public DateTime? DocumentsCouriedToConsignee { get; set; }

    public DateTime? FreightBillReceived { get; set; }

    public DateTime? PreAlertDocsSent { get; set; }

    public DateTime? TransportBillReceived { get; set; }
}
