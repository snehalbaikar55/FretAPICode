using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwDsrMumbaiOceanImport
{
    public string? JobNo { get; set; }

    public string? Mbl { get; set; }

    public DateTime? MblDate { get; set; }

    public string? Hbl { get; set; }

    public DateTime? HblDate { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? Carrier { get; set; }

    public string? DestinationAgent { get; set; }

    public string? Vessel { get; set; }

    public DateTime? BookingConfirmation { get; set; }

    public DateTime? ContainerPickupFromLiner { get; set; }

    public DateTime? ShippedOnBoard { get; set; }

    public DateTime? VesselDeparture { get; set; }

    public DateTime? DraftConfirmationReceivedFromConsignee { get; set; }

    public DateTime? PreAlertReceived { get; set; }

    public DateTime? DebitNoteReceivedFromAgent { get; set; }

    public DateTime? PreAlertSentToConsignee { get; set; }

    public DateTime? IgmFilingManfestation { get; set; }

    public DateTime? VesselArrivalAtDestination { get; set; }

    public string? IgmNo { get; set; }

    public DateTime? IgmDate { get; set; }

    public string? LineNo { get; set; }

    public DateTime? CargoArrivalNoticeSentToCustomer { get; set; }

    public DateTime? LinerInvoiceReceived { get; set; }

    public DateTime? CostSheetApprovalLockDate { get; set; }

    public DateTime? CostSheetHandedOverToAccounts { get; set; }

    public DateTime? InvoiceGenerationDate { get; set; }

    public DateTime? InvoiceIssuedToCustomer { get; set; }

    public string? FreightInvoiceNo { get; set; }

    public string? Customer { get; set; }

    public string? InvoiceTo { get; set; }

    public decimal? InvoiceAmount { get; set; }

    public string? Currency { get; set; }

    public string? Cha { get; set; }

    public DateTime? DeliveryOrderIssuedToConsigneeCha { get; set; }
}
