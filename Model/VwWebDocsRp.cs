using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwWebDocsRp
{
    public int? CustomerId { get; set; }

    public int? CargoDocumentId { get; set; }

    public int CargoId { get; set; }

    public string? JobNo { get; set; }

    public string? DocumentType { get; set; }

    public string? Remarks { get; set; }

    public string? DocumentFileType { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? DocLink { get; set; }

    public int? CreatedBy { get; set; }
}
