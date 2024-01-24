using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class UnitConversionSetting
{
    public int UnitConversionId { get; set; }

    public int? BaseUnitId { get; set; }

    public int? ConvertedUnitId { get; set; }

    public decimal? ConversionFactor { get; set; }

    public string? InverseConversionFactor { get; set; }

    public virtual UnitMaster? BaseUnit { get; set; }

    public virtual UnitMaster? ConvertedUnit { get; set; }
}
