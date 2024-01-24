using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class ChargeItemMaster
{
    public int ChargeItemId { get; set; }

    public string? ChargeItemCode { get; set; }

    public string? ChargeItemName { get; set; }

    public string? OperationsGroup { get; set; }

    public bool IsExpense { get; set; }

    public int? TaxId { get; set; }

    public string? TaxName { get; set; }

    public decimal? TaxPercent { get; set; }

    public string? ChargeDescription { get; set; }

    public string? TransportationMethod { get; set; }

    public string? TransportationDirection { get; set; }

    public int? IncomeAccountHeadId { get; set; }

    public string? IncomeAccountHead { get; set; }

    public int? ExpenseAccountHeadId { get; set; }

    public string? ExpenseAccountHead { get; set; }

    public bool? AllowNegative { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; } = new List<InvoiceLineItem>();

    public virtual ICollection<SalesQuoteCharge> SalesQuoteCharges { get; } = new List<SalesQuoteCharge>();
}
