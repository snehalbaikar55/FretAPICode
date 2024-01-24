using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class Enquiry
{
    public int EnquiryId { get; set; }

    public DateTime EnquiryDate { get; set; }

    public string? EnquirySubject { get; set; }

    public int ServiceTypeId { get; set; }

    public int? Polid { get; set; }

    public string? Pol { get; set; }

    public int? Podid { get; set; }

    public string? Pod { get; set; }

    public int? CommodityId { get; set; }

    public string? Commodity { get; set; }

    public int? ContainerTypeId { get; set; }

    public int? ContainerCount { get; set; }

    public int? PackageTypeId { get; set; }

    public int? PackageCount { get; set; }

    public int? Length { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public decimal? TotalCbm { get; set; }

    public decimal? TotalGrossWeight { get; set; }

    public string? WeightUnit { get; set; }

    public string? EnquirySource { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? AssignedTo { get; set; }

    public string? EnquiryStatus { get; set; }
}
