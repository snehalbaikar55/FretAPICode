using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class SaleQuoteDetailNewdisplayView
{
    public int SalesQuoteDetailId { get; set; }

    public int SalesQuoteId { get; set; }

    public int SortOrder { get; set; }

    public int? PlaceOfOriginId { get; set; }

    public string? PlaceOfOrigin { get; set; }

    public int? Polid { get; set; }

    public string? Pol { get; set; }

    public int? Pot1id { get; set; }

    public string? Pot1 { get; set; }

    public int? Podid { get; set; }

    public string? Pod { get; set; }

    public int? PlaceOfDeliveryId { get; set; }

    public string? PlaceOfDelivery { get; set; }

    public int? CarrierId { get; set; }

    public string? Carrier { get; set; }

    public int? VesselId { get; set; }

    public string? VesselName { get; set; }

    public string? TransitTime { get; set; }

    public string? FreeTime { get; set; }

    public string? IncoTerm { get; set; }

    public string? TypeOfMove { get; set; }

    public string? Notes { get; set; }

    public string? LocationShortName { get; set; }

    public string? OceanLineCode { get; set; }

    public string? Polname { get; set; }
}
