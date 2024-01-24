using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CargoDocument
{
    public int CargoDocumentId { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? DocumentType { get; set; }

    public string? DocumentName { get; set; }

    public string? DocumentFileType { get; set; }

    public string? Remarks { get; set; }

    public string? Ftplink { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CargoId { get; set; }
}
