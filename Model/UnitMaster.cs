using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class UnitMaster
{
    public int UnitId { get; set; }

    public string? UnitName { get; set; }

    public string? UnitDisplayShortName { get; set; }

    public string? UnitDisplayLongName { get; set; }

    public short UnitTypeId { get; set; }

    public string? UnitTypeName { get; set; }

    public virtual ICollection<UnitConversionSetting> UnitConversionSettingBaseUnits { get; } = new List<UnitConversionSetting>();

    public virtual ICollection<UnitConversionSetting> UnitConversionSettingConvertedUnits { get; } = new List<UnitConversionSetting>();

    public virtual UnitTypeMaster UnitType { get; set; } = null!;
}
