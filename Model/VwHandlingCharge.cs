using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class VwHandlingCharge
{
    public int Cargoid { get; set; }

    public decimal? AirlineTerminalHandlingCharges { get; set; }

    public decimal? HandlingCharges { get; set; }

    public decimal? ProcessingMessengerHandlingFee { get; set; }

    public decimal? HandlingAgentFee { get; set; }

    public decimal? TerminalHandlingCharges { get; set; }

    public decimal? HandlingCharge { get; set; }

    public decimal? HandlingChargesOld { get; set; }

    public decimal? HandlingFee { get; set; }

    public decimal? PortHandlingCharges { get; set; }

    public decimal? TerminalHandlingChargesOld { get; set; }

    public decimal? TerminalHandlingChgsSe { get; set; }

    public decimal? AirportHandlingCharges { get; set; }

    public decimal? Handling { get; set; }

    public decimal? HandlingOld { get; set; }

    public decimal? HandlingFeeSE { get; set; }
}
