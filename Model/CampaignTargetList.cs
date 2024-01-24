using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CampaignTargetList
{
    public int CampaignTargetId { get; set; }

    public int? CampaignId { get; set; }

    public int? LeadId { get; set; }

    public bool? IsSent { get; set; }

    public DateTime? SentDate { get; set; }

    public bool? IsResponded { get; set; }

    public DateTime? RespondedDate { get; set; }

    public string? ResponseLog { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }
}
