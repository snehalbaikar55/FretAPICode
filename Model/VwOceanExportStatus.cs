using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwOceanExportStatus
{
    public int CargoId { get; set; }

    public DateTime? Draft { get; set; }

    public DateTime? DocumentHandover { get; set; }

    public DateTime? BookingRequestReceived { get; set; }

    public DateTime? BookingConfirmed { get; set; }

    public DateTime? ContainerPickedUp { get; set; }

    public DateTime? InTransitToOriginPort { get; set; }

    public DateTime? LoadingList { get; set; }

    public DateTime? SiFormatReceiptFromCustomer { get; set; }

    public DateTime? SiSubmissionToLiner { get; set; }

    public DateTime? BlFirstPrint { get; set; }

    public DateTime? ShippedOnBoard { get; set; }

    public DateTime? VesselDeparture { get; set; }

    public DateTime? CostSheetApproval { get; set; }

    public DateTime? InvoiceGeneration { get; set; }

    public DateTime? InvoiceIssuedToCustomer { get; set; }

    public DateTime? BlIssuedByLiner { get; set; }

    public DateTime? BlIssuedToCustomer { get; set; }

    public DateTime? PreAlertSent { get; set; }

    public DateTime? CustomsDocumentHandover { get; set; }

    public DateTime? EpCopyHandover { get; set; }

    public DateTime? ArrivedAtDestination { get; set; }

    public DateTime? DestinationCustomsHold { get; set; }

    public DateTime? ManifestSubmitted { get; set; }

    public DateTime? DestinationCustomsCleared { get; set; }

    public DateTime? DoSent { get; set; }

    public DateTime? PickedUpByCustomerAgent { get; set; }

    public DateTime? Delivered { get; set; }
}
