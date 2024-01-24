using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwTaskList
{
    public int TaskId { get; set; }

    public string? Subject { get; set; }

    public string? Tt { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Priority { get; set; }

    public string? TaskStatus { get; set; }

    public string? UserName { get; set; }

    public int? ContactId { get; set; }

    public int? LeadId { get; set; }

    public int? OpportunityId { get; set; }

    public int? CargoId { get; set; }

    public string? TaskTypeName { get; set; }
}
