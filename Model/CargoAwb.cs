using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CargoAwb
{
    public int Awbid { get; set; }

    public int CargoId { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? DocumentType { get; set; }

    public string? HeadLeft { get; set; }

    public string? HeadCenter { get; set; }

    public string? HeadRight { get; set; }

    public string? MasterAwbnumber { get; set; }

    public string? HouseAwbnumber { get; set; }

    public string? AwbissuedBy { get; set; }

    public int? ShipperAddressId { get; set; }

    public string? ShipperName { get; set; }

    public string? ShipperAddress { get; set; }

    public int? ConsigneeAddressId { get; set; }

    public string? ConsigneeName { get; set; }

    public string? ConsigneeAddress { get; set; }

    public string? IssuingCarrierAddress { get; set; }

    public string? AgentsIatacode { get; set; }

    public string? AccountNo { get; set; }

    public string? AccountingInformation { get; set; }

    public string? AirportOfDeparture { get; set; }

    public string? Reference1 { get; set; }

    public string? Reference2 { get; set; }

    public string? Reference3 { get; set; }

    public string? RoutingTo1 { get; set; }

    public string? ByFirstCarrier { get; set; }

    public string? To2 { get; set; }

    public string? By2 { get; set; }

    public string? To3 { get; set; }

    public string? By3 { get; set; }

    public string? AirportOfDestination { get; set; }

    public string? RequestedFlight1 { get; set; }

    public string? RequestedFlight2 { get; set; }

    public string? CurrencyCode { get; set; }

    public string? Cghscode { get; set; }

    public bool? WtvalPpd { get; set; }

    public bool? WtvalColl { get; set; }

    public bool? OtherPpd { get; set; }

    public bool? OtherColl { get; set; }

    public string? DeclaredValueForCarriage { get; set; }

    public string? DeclaredValueForCustoms { get; set; }

    public string? HandlingInformation { get; set; }

    public string? Sci { get; set; }

    public int? NoOfPieces { get; set; }

    public decimal? GrossWeight { get; set; }

    public int? WeightUnitId { get; set; }

    public string? RateClass { get; set; }

    public decimal? ChargeableWeight { get; set; }

    public decimal? RateCharge { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? NatureAndQuantityOfGoods { get; set; }

    public decimal? WeightChargePpd { get; set; }

    public decimal? WeightChargeColl { get; set; }

    public decimal? ValuationPpd { get; set; }

    public decimal? ValuationColl { get; set; }

    public decimal? TaxPpd { get; set; }

    public decimal? TaxColl { get; set; }

    public decimal? DueAgentPpd { get; set; }

    public decimal? DueAgentColl { get; set; }

    public decimal? DueCarrierPpd { get; set; }

    public decimal? DueCarrierColl { get; set; }

    public decimal? TotalPpd { get; set; }

    public decimal? TotalColl { get; set; }

    public string? CurrencyConversionRates { get; set; }

    public decimal? CcdestCurrency { get; set; }

    public decimal? ChargesAtDestination { get; set; }

    public decimal? TotalCollectCharges { get; set; }

    public string? OtherCharges { get; set; }

    public string? SignatureOfShipper { get; set; }

    public DateTime? ExecutedOn { get; set; }

    public string? ExecutedPlace { get; set; }

    public string? SignatureOfIssuingCarrier { get; set; }

    public string? Description1 { get; set; }

    public string? Description2 { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public string? Kglb { get; set; }

    public virtual ICollection<Awbcharge> Awbcharges { get; } = new List<Awbcharge>();
}
