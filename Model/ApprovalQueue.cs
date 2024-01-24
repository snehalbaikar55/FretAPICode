using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class ApprovalQueue
{
    public int ApprovalQueueId { get; set; }

    public int? FormId { get; set; }

    public string ApprovalType { get; set; } = null!;

    public int ApprovalEntityId { get; set; }

    public string? ApprovalEntityReference { get; set; }

    public DateTime? RequestDate { get; set; }

    public DateTime? DueDate { get; set; }

    public int ApproverId { get; set; }

    public int RequestorId { get; set; }

    public int? ApprovalLevel { get; set; }

    public string? CurrentStatus { get; set; }

    public string? Remarks { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }
}
