using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwStatusAirImport
{
    public int CargoId { get; set; }

    public DateTime? NominationReceivedFromConsignee { get; set; }

    public DateTime? NominationInformedToOverseasAgent { get; set; }

    public DateTime? CargoPickupDate { get; set; }

    public DateTime? CargoBookingDate { get; set; }

    public DateTime? FlightDepartureDate { get; set; }

    public DateTime? PreAlertReceivedFromOverseas { get; set; }

    public DateTime? PreAlertSentToConsignee { get; set; }

    public DateTime? PreAlertSentToBbAgent { get; set; }

    public DateTime? IgmFilingDate { get; set; }

    public DateTime? FlightArrival { get; set; }

    public DateTime? CargoArrivalNotice { get; set; }

    public DateTime? AirlineBbAgentInvoiceReceived { get; set; }

    public DateTime? CostSheetApprovalLockDate { get; set; }

    public DateTime? CostSheetHandedOverToAccounts { get; set; }

    public DateTime? InvoiceGenerationDate { get; set; }

    public DateTime? InvoiceIssuedToCustomer { get; set; }

    public DateTime? DeliveryOrderIssuedToConsigneeCha { get; set; }

    public DateTime? DocumentsCouriedToConsignee { get; set; }

    public DateTime? CargoDeliveredToCustomer { get; set; }

    public DateTime? DocumentsReceivedAck { get; set; }

    public DateTime? ShipmentClosed { get; set; }

    public DateTime? ClearanceBillReceived { get; set; }

    public DateTime? ClearanceDone { get; set; }

    public DateTime? DduDdpClearance { get; set; }

    public DateTime? DestinationDnReceived { get; set; }

    public DateTime? FreightBillReceived { get; set; }

    public DateTime? PreAlertDocsSent { get; set; }

    public DateTime? TransportBillReceived { get; set; }
}
