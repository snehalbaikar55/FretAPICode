using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CompanyDocument1
{
    public int DocumentId { get; set; }

    public int CompanyId { get; set; }

    public string DocumentType { get; set; } = null!;

    public string DocumentLink { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public string FileExtension { get; set; } = null!;

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Company Company { get; set; } = null!;
}
