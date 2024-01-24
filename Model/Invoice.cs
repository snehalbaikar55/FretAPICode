using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Invoice
{
    public int InvoiceId { get; set; }

    public int CargoId { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public DateTime InvoiceDate { get; set; }

    public string? InvoiceType { get; set; }

    public int? PayingPartyId { get; set; }

    public string? PayingParty { get; set; }

    public int? PayingPartyAddressId { get; set; }

    public string? PayingPartyAddress { get; set; }

    public int? CurrencyId { get; set; }

    public string? CurrencyCode { get; set; }

    public int? ExchangeRateId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? JobNumber { get; set; }

    public string? VesselVoyage { get; set; }

    public string? Cycle { get; set; }

    public string? CargoType { get; set; }

    public string? FreightStatus { get; set; }

    public string? MblMawb { get; set; }

    public string? Pol { get; set; }

    public string? FinalDestination { get; set; }

    public string? CreditDays { get; set; }

    public string? ShipperInvoiceDetails { get; set; }

    public string? HblHawb { get; set; }

    public string? FlightDetails { get; set; }

    public string? Notes1 { get; set; }

    public decimal? InvoiceAmount { get; set; }

    public decimal? TaxAmount { get; set; }

    public string? InvoiceAmountWords { get; set; }

    public decimal? InvoiceAmountLocalCurrency { get; set; }

    public decimal? TaxAmountLocalCurrency { get; set; }

    public decimal? ServiceTax { get; set; }

    public decimal? EducationCess { get; set; }

    public decimal? Shecess { get; set; }

    public decimal? NonTaxableAmount { get; set; }

    public decimal? TaxableAmount { get; set; }

    public int? LocalCurrencyId { get; set; }

    public bool IsLocked { get; set; }

    public int? LockedBy { get; set; }

    public DateTime? DateLocked { get; set; }

    public bool IsSentToParty { get; set; }

    public int? SentBy { get; set; }

    public DateTime? SentDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public string? InvoiceApprovalStatus { get; set; }

    public int? CostSheetId { get; set; }

    public string? InvoiceTypeGst { get; set; }

    public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; } = new List<InvoiceLineItem>();
}
