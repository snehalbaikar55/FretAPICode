using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Task
{
    public int TaskId { get; set; }

    public string? Subject { get; set; }

    public string? Comments { get; set; }

    public int? TaskTypeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Priority { get; set; }

    public string? TaskStatus { get; set; }

    public int? ContactId { get; set; }

    public string? Location { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual CargoTask? CargoTask { get; set; }

    public virtual LeadTask? LeadTask { get; set; }

    public virtual OpportunityTask? OpportunityTask { get; set; }
}
