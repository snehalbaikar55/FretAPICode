using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class LocalCharge
{
    public int LocalChargeId { get; set; }

    public string? LocalChargeName { get; set; }

    public string? LocalChargeDescription { get; set; }

    public string? ModeOfTransport { get; set; }

    public string? TransportDirection { get; set; }

    public int? Polid { get; set; }

    public string? Pol { get; set; }

    public int? Podid { get; set; }

    public string? Pod { get; set; }

    public int? CarrierId { get; set; }

    public string? CarrierName { get; set; }

    public int? TerminalId { get; set; }

    public string? TerminalName { get; set; }

    public DateTime? EffectiveFrom { get; set; }

    public string? ApplyPer { get; set; }

    public string? ContainerType { get; set; }

    public decimal? Rate { get; set; }

    public string? Currency { get; set; }

    public int? TaxId { get; set; }

    public string? TaxName { get; set; }

    public decimal? TaxPercent { get; set; }

    public decimal? Minimum { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public int? ChargeItemId { get; set; }
}
