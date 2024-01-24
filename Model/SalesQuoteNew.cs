using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class SalesQuoteNew
{
    public int SalesQuoteId { get; set; }

    public string SalesQuoteNumber { get; set; } = null!;

    public int CompanyId { get; set; }

    public int ContactId { get; set; }

    public int PreparedBy { get; set; }

    public int SalesPersonId { get; set; }

    public DateTime? SalesQuoteDate { get; set; }

    public DateTime? EnqReceivedDate { get; set; }

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

    public bool? ShowTotal { get; set; }

    public bool? ShowTax { get; set; }

    public bool? ShowCarrier { get; set; }

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

    public string? InternalNotes { get; set; }

    public string? BusinessLostNotes { get; set; }

    public int? SalesQuoteCurrencyId { get; set; }

    public string? SalesQuoteCurrency { get; set; }

    public int? OfficeId { get; set; }

    public string? SalesQuoteStatus { get; set; }

    public string? SalesQuoteType { get; set; }

    public string? Modeoftransport { get; set; }

    public string? Direction { get; set; }

    public string? TermsConditions { get; set; }

    public int? PickupAddressId { get; set; }

    public int? DeliveryAddressId { get; set; }

    public string? PickupAddress { get; set; }

    public string? DeliveryAddress { get; set; }

    public DateTime? FollowUp1 { get; set; }

    public string? FollowUp1Remarks { get; set; }

    public DateTime? FollowUp2 { get; set; }

    public string? FollowUp2Remarks { get; set; }

    public int? CompanyAddressId { get; set; }

    public string? CompanyAddress { get; set; }
}
