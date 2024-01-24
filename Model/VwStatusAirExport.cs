using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwStatusAirExport
{
    public int CargoId { get; set; }

    public DateTime? BookingRequestDocumentsReceivedFromCustomer { get; set; }

    public DateTime? BookingRequestToAirLiner { get; set; }

    public DateTime? BookingConfirmedByAirLiner { get; set; }

    public DateTime? BookingIssuedToCustomer { get; set; }

    public DateTime? AwbDraftIssuedToShipperCha { get; set; }

    public DateTime? ShippingInstructionsIssuedByCha { get; set; }

    public DateTime? CargoGatedInByCha { get; set; }

    public DateTime? CargoHandedOverToAirline { get; set; }

    public DateTime? FlightDeparture { get; set; }

    public DateTime? AwbHawbSentToShipperCha { get; set; }

    public DateTime? PreAlertSentToDestinationAgent { get; set; }

    public DateTime? CostSheetApprovalLockDate { get; set; }

    public DateTime? CostSheetHandedOverToAccounts { get; set; }

    public DateTime? InvoiceGenerationDate { get; set; }

    public DateTime? InvoiceIssuedToCustomer { get; set; }

    public DateTime? FlightArrivalAtDestination { get; set; }

    public DateTime? CargoCustomCleared { get; set; }

    public DateTime? CargoDelivered { get; set; }

    public DateTime? ProofOfDeliveryFromAgent { get; set; }

    public DateTime? ClearanceBillReceived { get; set; }

    public DateTime? ClearanceDone { get; set; }

    public DateTime? DduDdpClearance { get; set; }

    public DateTime? DestinationDnReceived { get; set; }

    public DateTime? DocumentsCouriedToConsignee { get; set; }

    public DateTime? FreightBillReceived { get; set; }

    public DateTime? PreAlertDocsSent { get; set; }

    public DateTime? TransportBillReceived { get; set; }
}
