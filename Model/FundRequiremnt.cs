using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class FundRequiremnt
{
    public int Frid { get; set; }

    public int? CargoId { get; set; }

    public int? VendorId { get; set; }

    public string? VendorName { get; set; }

    public string? VendorType { get; set; }

    public decimal? Amount { get; set; }

    public string? CurrencyCode { get; set; }

    public DateTime? DueDate { get; set; }

    public int? CollectFromId { get; set; }

    public string? CollectFromName { get; set; }

    public int? SalesPersonId { get; set; }

    public string? Remarks { get; set; }

    public string? CurrentStatus { get; set; }

    public string? CurrentStatusDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? OfficeId { get; set; }

    public decimal? AmtInr { get; set; }

    public decimal? AmtEur { get; set; }

    public decimal? AmtUsd { get; set; }

    public decimal? AmtSgd { get; set; }

    public string? Jobtype { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? Datedeleted { get; set; }

    public int? DeletedBy { get; set; }

    public int? Polid { get; set; }

    public int? Podid { get; set; }
}
