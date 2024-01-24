using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwPuneAirExportDsr
{
    public string? User { get; set; }

    public string? JobNo { get; set; }

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? ShipperInvoiceDetails { get; set; }

    public string? Salesperson { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? InvoiceNo { get; set; }

    public string? InvoiceDate { get; set; }

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
}
