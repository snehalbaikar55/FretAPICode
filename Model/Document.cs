using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Document
{
    public int DocumentId { get; set; }

    public string? DocumentName { get; set; }

    public string? DocumentFileType { get; set; }

    public string? DocumentLocalLink { get; set; }

    public string? DocumentFtplink { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual CompanyDocument? CompanyDocument { get; set; }

    public virtual LeadDocument? LeadDocument { get; set; }

    public virtual OpportunityDocument? OpportunityDocument { get; set; }
}
