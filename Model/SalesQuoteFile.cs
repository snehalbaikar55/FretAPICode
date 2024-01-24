using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class SalesQuoteFile
{
    public int SalesQuoteFileId { get; set; }

    public int SalesQuoteId { get; set; }

    public int? RevisionId { get; set; }

    public string? FilePath { get; set; }

    public string? EmailTo { get; set; }

    public string? EmailCc { get; set; }

    public string? EmailSubject { get; set; }

    public string? EmailBody { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }
}
