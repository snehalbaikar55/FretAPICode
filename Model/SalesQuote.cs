using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class SalesQuote
{
    public int SalesQuoteId { get; set; }

    public string SalesQuoteNumber { get; set; } = null!;

    public int CompanyId { get; set; }

    public int ContactId { get; set; }

    public int PreparedBy { get; set; }

    public int SalesPersonId { get; set; }

    public DateTime? SalesQuoteDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int TypeOfMoveId { get; set; }

    public int? IncoTermId { get; set; }

    public int? OldSalesQuoteId { get; set; }

    public int? RevisionId { get; set; }

    public int? FileId { get; set; }

    public bool IsDraft { get; set; }

    public bool IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public bool IsRejected { get; set; }

    public DateTime? RejectedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsContract { get; set; }

    public string? ContractNumber { get; set; }

    public int? PlaceOfOriginId { get; set; }

    public string? PlaceOfOrigin { get; set; }

    public int? Polid { get; set; }

    public string? Pol { get; set; }

    public int? Pot1id { get; set; }

    public string? Pot1 { get; set; }

    public int? Pot2id { get; set; }

    public string? Pot2 { get; set; }

    public int? Pot3id { get; set; }

    public string? Pot3 { get; set; }

    public int? Podid { get; set; }

    public string? Pod { get; set; }

    public int? PlaceOfDeliveryId { get; set; }

    public string? PlaceOfDelivery { get; set; }

    public int? PickupAddressId { get; set; }

    public string? PickupAddress { get; set; }

    public string? PickupAddressStreet { get; set; }

    public string? PickupAddressCity { get; set; }

    public string? PickupAddressState { get; set; }

    public string? PickupAddressCountry { get; set; }

    public string? PickupAddressZip { get; set; }

    public int? DeliveryAddressId { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? DeliveryAddressStreet { get; set; }

    public string? DeliveryAddressCity { get; set; }

    public string? DeliveryAddressState { get; set; }

    public string? DeliveryAddressCountry { get; set; }

    public string? DeliveryAddressZip { get; set; }

    public string? Frequency { get; set; }

    public int? CarrierId { get; set; }

    public string? Carrier { get; set; }

    public int? CarrierAgentId { get; set; }

    public string? CarrierAgent { get; set; }

    public bool? IsHazardous { get; set; }

    public string? Commodity { get; set; }

    public decimal? CommodityValue { get; set; }

    public int? CommodityValueCurrencyId { get; set; }

    public string? CommodityValueCurrency { get; set; }

    public string? RequiredEquipment { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? Volume { get; set; }

    public decimal? VolumeWeight { get; set; }

    public decimal? ChargeableWeight { get; set; }

    public string? CompanyDisplayName { get; set; }

    public string? ContactDisplayName { get; set; }

    public string? SalesPersonDisplayName { get; set; }

    public string? PreparedByDislayName { get; set; }

    public string? EmailTo { get; set; }

    public string? EmailCc { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactTelephone { get; set; }

    public string? IncoTerm { get; set; }

    public string? TypeOfMove { get; set; }

    public string? InternalNotes { get; set; }

    public string? CustomerNotes { get; set; }

    public bool? ShowLiner { get; set; }

    public int? SalesQuoteCurrencyId { get; set; }

    public string? SalesQuoteCurrency { get; set; }

    public int? SalesQuoteBaseCurrencyId { get; set; }

    public string? SalesQuoteBaseCurrency { get; set; }

    public bool? ShowAllIn { get; set; }

    public decimal? SalesQuoteExRate { get; set; }

    public decimal? SalesQuoteExRateInverse { get; set; }

    public int? OfficeId { get; set; }

    public int? OpportunityId { get; set; }

    public string? SalesQuoteType { get; set; }

    public virtual SalesQuoteAdditionalDetail? SalesQuoteAdditionalDetail { get; set; }

    public virtual ICollection<SalesQuoteCommodity> SalesQuoteCommodities { get; } = new List<SalesQuoteCommodity>();

    public virtual ICollection<SalesQuoteService> SalesQuoteServices { get; } = new List<SalesQuoteService>();
}
