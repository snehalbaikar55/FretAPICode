using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwWildRepublicDsr2
{
    public int CargoId { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? Eta { get; set; }

    public string? JobNo { get; set; }

    public string? Hbl { get; set; }

    public string? Mbl { get; set; }

    public string? ContainerNo { get; set; }

    public string? ContainerSize { get; set; }

    public string? Vessel { get; set; }

    public string? Origin { get; set; }

    public string? Shipper { get; set; }

    public DateTime? DateOfBooking { get; set; }

    public DateTime? DateOfDispatch { get; set; }

    public string? PortOfUnloading { get; set; }

    public DateTime? DateOfDeliveryToPort { get; set; }

    public DateTime? DateOfClearance { get; set; }

    public DateTime? DateDeliveredToWarehouse { get; set; }

    public string? ContainerValue { get; set; }

    public string? InvoiceNoWildRepublic { get; set; }

    public string? InvoiceNoFretlog { get; set; }

    public decimal FreightCharges { get; set; }

    public decimal DestinationCharges { get; set; }

    public decimal CustomsClearanceCharges { get; set; }

    public decimal OtherChargesIfAny { get; set; }

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }
}
