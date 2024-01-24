using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwMumAirDsr
{
    public string? User { get; set; }

    public string? JobNo { get; set; }

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public string? BookingNumber { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? InvoiceNo { get; set; }

    public string? AirCarrierName { get; set; }

    public string? CustomerName { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public int CargoId { get; set; }

    public DateTime? Draft { get; set; }

    public DateTime? DocumentHandover { get; set; }

    public DateTime? BookingRequestReceived { get; set; }

    public DateTime? BookingIssuedToCustomer { get; set; }

    public DateTime? AwbDraft { get; set; }

    public DateTime? FlightDeparture { get; set; }

    public DateTime? CostSheetApproval { get; set; }

    public DateTime? InvoiceGeneration { get; set; }

    public DateTime? InvoiceIssuedToCustomer { get; set; }

    public DateTime? AwbIssuedByLiner { get; set; }

    public DateTime? AwbIssuedToCustomer { get; set; }

    public DateTime? CustomDocumentsHandover { get; set; }

    public DateTime? EpCopyHandover { get; set; }

    public DateTime? PreAlertSent { get; set; }

    public DateTime? InvoiceSentToAgent { get; set; }

    public DateTime? Delivered { get; set; }

    public DateTime? DateCreated { get; set; }
}
