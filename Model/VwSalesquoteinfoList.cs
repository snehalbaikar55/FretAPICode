using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwSalesquoteinfoList
{
    public string? SalesQuoteType { get; set; }

    public int SalesQuoteId { get; set; }

    public string SalesQuoteNumber { get; set; } = null!;

    public DateTime? EnquiryReceivedDate { get; set; }

    public DateTime? QuoteSentOn { get; set; }

    public string? SalesPerson { get; set; }

    public string? Customer { get; set; }

    public string? Contact { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? Volume { get; set; }

    public string? Commodity { get; set; }

    public string? RequiredEquipment { get; set; }

    public int SalesPersonId { get; set; }

    public DateTime? BusinessReceivedDate { get; set; }

    public string? AgentDetails { get; set; }

    public string? Status { get; set; }

    public string? PreparedBy { get; set; }

    public int? QuoteDays { get; set; }

    public int? ResponseDays { get; set; }

    public int? CreatedBy { get; set; }

    public int PreparedBy1 { get; set; }

    public int? ManagerId { get; set; }

    public string? Modeoftransport { get; set; }

    public string? Direction { get; set; }

    public string OfficeName { get; set; } = null!;

    public string? BusinessLostNotes { get; set; }

    public DateTime? DateCreated { get; set; }
}
