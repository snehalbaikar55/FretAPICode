using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class SalesQuoteHistory
{
    public int SalesQuoteHistoryId { get; set; }

    public int SalesQuoteId { get; set; }

    public int? RevisionId { get; set; }

    public string? SalesQuoteStatus { get; set; }

    public string? SalesQuoteStatusRemarks { get; set; }

    public int? AssignedBy { get; set; }

    public int? AssignedTo { get; set; }

    public int? TaskId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }
}
