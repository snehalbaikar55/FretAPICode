using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Abc
{
    public string? User { get; set; }

    public string? JobNo { get; set; }

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public string? BookingNumber { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? OceanCarrierName { get; set; }

    public string? CustomerName { get; set; }

    public string? InvoiceNo { get; set; }

    public int? TotalPackages { get; set; }

    public decimal? TotalNetWeightKgs { get; set; }

    public decimal? TotalGrossWeightKgs { get; set; }

    public decimal? TotalVolumeCbm { get; set; }

    public int? _20gp { get; set; }

    public int? _20hc { get; set; }

    public int? _40gp { get; set; }

    public int? _40hc { get; set; }

    public string? ContainerNo { get; set; }

    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? OriginAgent { get; set; }

    public string? DestinationAgent { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

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

    public DateTime? DateCreated { get; set; }
}
