using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwLinerReportExport
{
    public string? BookingNo { get; set; }

    public string? BlNo { get; set; }

    public string? Vessel { get; set; }

    public string? Voyage { get; set; }

    public string? Pol { get; set; }

    public string? Pod { get; set; }

    public DateTime? SailedOn { get; set; }

    public string Trade { get; set; } = null!;

    public decimal? NetFreightInUsdPp { get; set; }

    public decimal? Brokerage { get; set; }

    public decimal AmtInUsd { get; set; }

    public decimal? ExRate { get; set; }

    public decimal AmtInInr { get; set; }

    public string FrtInvoiceSettledOn { get; set; } = null!;
}
