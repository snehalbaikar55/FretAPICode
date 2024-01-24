using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class UploadedFile
{
    public int FileId { get; set; }

    public string? FileName { get; set; }

    public string? FileType { get; set; }

    public string? FileLink { get; set; }

    public string? ProtocolUsed { get; set; }

    public string? Pcname { get; set; }

    public string? Ipaddress { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }
}
