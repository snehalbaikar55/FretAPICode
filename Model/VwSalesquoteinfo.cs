using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwSalesquoteinfo
{
    public string SalesQuoteNumber { get; set; } = null!;

    public DateTime? EnquiryReceivedDate { get; set; }

    public DateTime? QuoteSentOn { get; set; }

    public string? SalesPerson { get; set; }

    public string? Customer { get; set; }

    public string? Contact { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? BusinessReceivedDate { get; set; }

    public string? AgentDetails { get; set; }

    public string? Status { get; set; }

    public string? PreparedBy { get; set; }

    public int? QuoteDays { get; set; }

    public int? ResponseDays { get; set; }

    public string OfficeName { get; set; } = null!;
}
