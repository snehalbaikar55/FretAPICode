using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CompanyBankAccount
{
    public int BankAccountId { get; set; }

    public int CompanyId { get; set; }

    public string BankName { get; set; } = null!;

    public string? AccountNumber { get; set; }

    public int? CountryId { get; set; }

    public string? Branch { get; set; }

    public string? Ifsccode { get; set; }

    public string? Swift { get; set; }

    public string? Iban { get; set; }

    public string? BankContactName { get; set; }

    public string? BankContactNumber { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Company Company { get; set; } = null!;
}
