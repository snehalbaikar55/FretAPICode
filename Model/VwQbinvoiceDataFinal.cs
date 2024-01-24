using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwQbinvoiceDataFinal
{
    public string InvoiceNumber { get; set; } = null!;

    public DateTime InvoiceDate { get; set; }

    public int InvoiceId { get; set; }

    public int CargoId { get; set; }

    public int? DepartmentRefValue { get; set; }

    public string? DepartmentRefName { get; set; }

    public string? CurrencyRefValue { get; set; }

    public string? CurrencyRefName { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? PrivateNote { get; set; }

    public decimal? TotalTax { get; set; }

    public string? TranactionLocationType { get; set; }

    public int? CustomerRefValue { get; set; }

    public string? CustomerRefName { get; set; }

    public int? FretrackCustomerId { get; set; }

    public string? FretrackCustomerName { get; set; }

    public int? BillingAddrId { get; set; }

    public string BillingAddrLine1 { get; set; } = null!;

    public string BillingAddrLine2 { get; set; } = null!;

    public string BillingAddrLine3 { get; set; } = null!;

    public string BillingAddrLine4 { get; set; } = null!;

    public string BillingAddrLine5 { get; set; } = null!;

    public string BillingAddrCountrySubDivisionCode { get; set; } = null!;

    public int? ShipAddrId { get; set; }

    public string ShipAddrLine1 { get; set; } = null!;

    public string ShipAddrLine2 { get; set; } = null!;

    public string ShipAddrLine3 { get; set; } = null!;

    public string ShipAddrLine4 { get; set; } = null!;

    public string ShipAddrLine5 { get; set; } = null!;

    public string ShipAddrCountrySubDivisionCode { get; set; } = null!;

    public bool? FreeFormAddress { get; set; }

    public string ClassRefValue { get; set; } = null!;

    public string? ClassRefName { get; set; }

    public string? SalesTermRefValue { get; set; }

    public DateTime? DueDate { get; set; }

    public string GlobalTaxCalculation { get; set; } = null!;

    public decimal? TotalAmt { get; set; }

    public decimal? HomeTotalAmt { get; set; }

    public string PrintStatus { get; set; } = null!;

    public string EmailStatus { get; set; } = null!;

    public decimal? Balance { get; set; }

    public decimal? HomeBalance { get; set; }

    public int DiscountAmt { get; set; }
}
