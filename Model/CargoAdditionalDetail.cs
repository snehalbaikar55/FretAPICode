﻿using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CargoAdditionalDetail
{
    public int CargoAdditionalInfoId { get; set; }

    public int CargoId { get; set; }

    public string? DocumentDeliveryAddress { get; set; }

    public string? TruckPlate { get; set; }

    public string? TruckerMobile { get; set; }

    public string? CustomsBroker { get; set; }

    public string? Ktnotes { get; set; }

    public string? Hsno { get; set; }

    public string? CustomsArea { get; set; }

    public string? PreAlertInfo { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public int? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ArrivalNoticeTo { get; set; }

    public string? BookingTo { get; set; }

    public string? BookingLoadingPlace { get; set; }

    public string? BookingTrucking { get; set; }

    public DateTime? BookingWarehousePickupDate { get; set; }

    public string? BookingNotes { get; set; }

    public string? BookingContainerCount { get; set; }

    public string? BookingCommodity { get; set; }

    public string? BookingPayableAt { get; set; }

    public string? BookingOceanFreight { get; set; }

    public string? BookingPortCharges { get; set; }

    public string? BookingBlcost { get; set; }

    public string? BookingTruckingCost { get; set; }

    public string? BookingLcno { get; set; }

    public string? BookingOrderNo { get; set; }

    public string? ContainerDepoAddress { get; set; }

    public DateTime? ContainerDepoPickupDate { get; set; }
}
