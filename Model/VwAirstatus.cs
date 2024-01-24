using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwAirstatus
{
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
}
