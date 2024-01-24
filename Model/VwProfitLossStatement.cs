using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwProfitLossStatement
{
    public string? Shipper { get; set; }

    public string? Consignee { get; set; }

    public string? Jobnumber { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? Account { get; set; }

    public string? BillToName { get; set; }

    public string? ShipmentNumber { get; set; }

    public string? MasterNo { get; set; }

    public string? HouseNo { get; set; }

    public string? JobNo { get; set; }

    public string? InvoiceCurrency { get; set; }

    public string? ChargeDescription { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? TotalAmountLocalCurrency { get; set; }

    public string? CurrencyCode { get; set; }

    public string? MblMawb { get; set; }

    public string? HblHawb { get; set; }

    public decimal? TotalSelectedCurrency { get; set; }

    public string CompanyCode { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public decimal? Rate { get; set; }

    public decimal? TotalWithoutTax { get; set; }

    public decimal? TryAmount { get; set; }

    public decimal? UsdAmount { get; set; }

    public decimal? EurAmount { get; set; }

    public decimal? GbpAmount { get; set; }

    public int? IncomeExpense { get; set; }

    public decimal? IciExrate { get; set; }
}
