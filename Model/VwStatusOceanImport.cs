using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwStatusOceanImport
{
    public int CargoId { get; set; }

    public DateTime? FactoryPickupDate { get; set; }

    public DateTime? BookingConfirmation { get; set; }

    public DateTime? ContainerPickupFromLiner { get; set; }

    public DateTime? ShippedOnBoard { get; set; }

    public DateTime? VesselDeparture { get; set; }

    public DateTime? DraftConfirmationReceivedFromConsignee { get; set; }

    public DateTime? PreAlertReceived { get; set; }

    public DateTime? DebitNoteReceivedFromAgent { get; set; }

    public DateTime? PreAlertSentToConsignee { get; set; }

    public DateTime? IgmFilingManfestation { get; set; }

    public DateTime? Transhippment { get; set; }

    public DateTime? VesselArrivalAtDestination { get; set; }

    public DateTime? CargoArrivalNoticeSentToCustomer { get; set; }

    public DateTime? LinerInvoiceReceived { get; set; }

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
