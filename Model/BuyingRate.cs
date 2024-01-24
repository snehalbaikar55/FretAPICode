using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class BuyingRate
{
    public int BuyingRateId { get; set; }

    public int? Polid { get; set; }

    public string? Pol { get; set; }

    public int? Podid { get; set; }

    public string? Pod { get; set; }

    public string? ModeOfTransport { get; set; }

    public string? TransportDirection { get; set; }

    public string? ContainerType { get; set; }

    public string? Terms { get; set; }

    public string? TransitTime { get; set; }

    public int? Pot1id { get; set; }

    public string? Pot1 { get; set; }

    public int? Pot2id { get; set; }

    public string? Pot2 { get; set; }

    public int? Pot3id { get; set; }

    public string? Pot3 { get; set; }

    public string? Frequency { get; set; }

    public DateTime? OfferDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? Contact { get; set; }

    public string? Email { get; set; }

    public decimal? Amount { get; set; }

    public string? Currency { get; set; }

    public int? TaxId { get; set; }

    public string? TaxName { get; set; }

    public decimal? TaxPercent { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsApproved { get; set; }

    public decimal? C20gp { get; set; }

    public decimal? C20hc { get; set; }

    public decimal? C40hc { get; set; }

    public decimal? C40gp { get; set; }

    public decimal? C20ot { get; set; }

    public decimal? C40ot { get; set; }

    public decimal? C20ft { get; set; }

    public decimal? C40ft { get; set; }

    public int? CarrierId { get; set; }

    public string? CarrierName { get; set; }

    public decimal? Lclrate { get; set; }

    public decimal? Minimum { get; set; }

    public bool? IsLcl { get; set; }

    public decimal? C20rf { get; set; }

    public decimal? C40rf { get; set; }

    public decimal? Lcl { get; set; }

    public decimal? Bulk { get; set; }

    public string? Commodity { get; set; }

    public string? Notes { get; set; }
}
