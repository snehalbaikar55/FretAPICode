using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwPuneAirImportDsr
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

    public string? InvoiceNo { get; set; }

    public string? InvoiceDate { get; set; }

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
}
