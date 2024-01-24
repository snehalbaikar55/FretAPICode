using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VariableMaster
{
    public int VariableId { get; set; }

    public int? VariableModuleId { get; set; }

    public string? VariableName { get; set; }

    public string? VariableTable { get; set; }

    public string? VariableField { get; set; }

    public string? VariableCalculationFormula { get; set; }

    public bool IsActive { get; set; }
}
