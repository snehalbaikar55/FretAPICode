using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FretAPI.Model;

public partial class FretCloudDBContext : DbContext
{
    public FretCloudDBContext()
    {
    }

    public FretCloudDBContext(DbContextOptions<FretCloudDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Abc> Abcs { get; set; }

    public virtual DbSet<AccReport2223v2> AccReport2223v2s { get; set; }

    public virtual DbSet<AdditionalDetailsJob> AdditionalDetailsJobs { get; set; }

    public virtual DbSet<AdditionalDetailsMaster> AdditionalDetailsMasters { get; set; }

    public virtual DbSet<AirShipmentRouting> AirShipmentRoutings { get; set; }

    public virtual DbSet<AirlineMaster> AirlineMasters { get; set; }

    public virtual DbSet<ApplyPerMaster> ApplyPerMasters { get; set; }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<ApprovalHistory> ApprovalHistories { get; set; }

    public virtual DbSet<ApprovalQueue> ApprovalQueues { get; set; }

    public virtual DbSet<AttributeMaster> AttributeMasters { get; set; }

    public virtual DbSet<AvaryShipmentGroup> AvaryShipmentGroups { get; set; }

    public virtual DbSet<Awbcharge> Awbcharges { get; set; }

    public virtual DbSet<AwbchargeMaster> AwbchargeMasters { get; set; }

    public virtual DbSet<BulkJobsApr22Sep22> BulkJobsApr22Sep22s { get; set; }

    public virtual DbSet<BulkMissingVendor> BulkMissingVendors { get; set; }

    public virtual DbSet<BulkMissingVendorsCategory> BulkMissingVendorsCategories { get; set; }

    public virtual DbSet<BuyingRate> BuyingRates { get; set; }

    public virtual DbSet<Campaign> Campaigns { get; set; }

    public virtual DbSet<CampaignTargetList> CampaignTargetLists { get; set; }

    public virtual DbSet<CampaignTypeMaster> CampaignTypeMasters { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<CargoAdditionalDetail> CargoAdditionalDetails { get; set; }

    public virtual DbSet<CargoAwb> CargoAwbs { get; set; }

    public virtual DbSet<CargoCan> CargoCans { get; set; }

    public virtual DbSet<CargoCharge> CargoCharges { get; set; }

    public virtual DbSet<CargoContainer> CargoContainers { get; set; }

    public virtual DbSet<CargoDocument> CargoDocuments { get; set; }

    public virtual DbSet<CargoEntity> CargoEntities { get; set; }

    public virtual DbSet<CargoHbl> CargoHbls { get; set; }

    public virtual DbSet<CargoPackage> CargoPackages { get; set; }

    public virtual DbSet<CargoStatus> CargoStatuses { get; set; }

    public virtual DbSet<CargoStatusMaster> CargoStatusMasters { get; set; }

    public virtual DbSet<CargoTask> CargoTasks { get; set; }

    public virtual DbSet<Cargochargestemp> Cargochargestemps { get; set; }

    public virtual DbSet<Cargochargestemp1> Cargochargestemp1s { get; set; }

    public virtual DbSet<ChargeAttribute> ChargeAttributes { get; set; }

    public virtual DbSet<ChargeGroupMaster> ChargeGroupMasters { get; set; }

    public virtual DbSet<ChargeHead> ChargeHeads { get; set; }

    public virtual DbSet<ChargeItemMaster> ChargeItemMasters { get; set; }

    public virtual DbSet<ChargeMasterAbt> ChargeMasterAbts { get; set; }

    public virtual DbSet<ChargeheadsIst> ChargeheadsIsts { get; set; }

    public virtual DbSet<CityMaster> CityMasters { get; set; }

    public virtual DbSet<CldocsAttached> CldocsAttacheds { get; set; }

    public virtual DbSet<CommodityMaster> CommodityMasters { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyAddress> CompanyAddresses { get; set; }

    public virtual DbSet<CompanyAttribute> CompanyAttributes { get; set; }

    public virtual DbSet<CompanyBankAccount> CompanyBankAccounts { get; set; }

    public virtual DbSet<CompanyCaf> CompanyCafs { get; set; }

    public virtual DbSet<CompanyDocument> CompanyDocuments { get; set; }

    public virtual DbSet<CompanyDocument1> CompanyDocuments1 { get; set; }

    public virtual DbSet<CompanyPhone> CompanyPhones { get; set; }

    public virtual DbSet<CompanyReportGrouping> CompanyReportGroupings { get; set; }

    public virtual DbSet<CompanyType> CompanyTypes { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ContactType> ContactTypes { get; set; }

    public virtual DbSet<CostSheet> CostSheets { get; set; }

    public virtual DbSet<CounterMaster> CounterMasters { get; set; }

    public virtual DbSet<CountryMaster> CountryMasters { get; set; }

    public virtual DbSet<CountryStateMaster> CountryStateMasters { get; set; }

    public virtual DbSet<CourierCoveringLetter> CourierCoveringLetters { get; set; }

    public virtual DbSet<CoveringLetterDocsMaster> CoveringLetterDocsMasters { get; set; }

    public virtual DbSet<CurrencyMaster> CurrencyMasters { get; set; }

    public virtual DbSet<CustomReport> CustomReports { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }

    public virtual DbSet<DemoList> DemoLists { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DocumentMaster> DocumentMasters { get; set; }

    public virtual DbSet<EmailHistory> EmailHistories { get; set; }

    public virtual DbSet<EmailResponse> EmailResponses { get; set; }

    public virtual DbSet<Enquiry> Enquiries { get; set; }

    public virtual DbSet<EntityTypeMaster> EntityTypeMasters { get; set; }

    public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }

    public virtual DbSet<FinancialYearMaster> FinancialYearMasters { get; set; }

    public virtual DbSet<FormMaster> FormMasters { get; set; }

    public virtual DbSet<FundRequiremnt> FundRequiremnts { get; set; }

    public virtual DbSet<GstTypeMaster> GstTypeMasters { get; set; }

    public virtual DbSet<ImportCustomersaddress> ImportCustomersaddresses { get; set; }

    public virtual DbSet<IncoTerrmMaster> IncoTerrmMasters { get; set; }

    public virtual DbSet<IndustryMaster> IndustryMasters { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceEsync> InvoiceEsyncs { get; set; }

    public virtual DbSet<InvoiceLineItem> InvoiceLineItems { get; set; }

    public virtual DbSet<InvoiceListNewAge> InvoiceListNewAges { get; set; }

    public virtual DbSet<JobTypeMaster> JobTypeMasters { get; set; }

    public virtual DbSet<JobVendorDetail> JobVendorDetails { get; set; }

    public virtual DbSet<Lcljob> Lcljobs { get; set; }

    public virtual DbSet<Lclrecord> Lclrecords { get; set; }

    public virtual DbSet<Lead> Leads { get; set; }

    public virtual DbSet<LeadCampaign> LeadCampaigns { get; set; }

    public virtual DbSet<LeadDocument> LeadDocuments { get; set; }

    public virtual DbSet<LeadTask> LeadTasks { get; set; }

    public virtual DbSet<LocalCharge> LocalCharges { get; set; }

    public virtual DbSet<LocationMaster> LocationMasters { get; set; }

    public virtual DbSet<MarketingSourceMaster> MarketingSourceMasters { get; set; }

    public virtual DbSet<MarketingStageMaster> MarketingStageMasters { get; set; }

    public virtual DbSet<MoveType> MoveTypes { get; set; }

    public virtual DbSet<NewageInvoiceFile> NewageInvoiceFiles { get; set; }

    public virtual DbSet<NewageWeeklyReport> NewageWeeklyReports { get; set; }

    public virtual DbSet<NewageWeeklyReportBackup> NewageWeeklyReportBackups { get; set; }

    public virtual DbSet<OceanLineMaster> OceanLineMasters { get; set; }

    public virtual DbSet<OceanSchedule> OceanSchedules { get; set; }

    public virtual DbSet<OceanShipmentRouting> OceanShipmentRoutings { get; set; }

    public virtual DbSet<Opportunity> Opportunities { get; set; }

    public virtual DbSet<OpportunityAttribute> OpportunityAttributes { get; set; }

    public virtual DbSet<OpportunityCampaign> OpportunityCampaigns { get; set; }

    public virtual DbSet<OpportunityDocument> OpportunityDocuments { get; set; }

    public virtual DbSet<OpportunityTask> OpportunityTasks { get; set; }

    public virtual DbSet<OtherCompanyType> OtherCompanyTypes { get; set; }

    public virtual DbSet<PackageGroup> PackageGroups { get; set; }

    public virtual DbSet<PackageType> PackageTypes { get; set; }

    public virtual DbSet<PaymentTerm> PaymentTerms { get; set; }

    public virtual DbSet<ProfileMaster> ProfileMasters { get; set; }

    public virtual DbSet<ProfileRight> ProfileRights { get; set; }

    public virtual DbSet<QbChargeItem> QbChargeItems { get; set; }

    public virtual DbSet<QbChargeMapping> QbChargeMappings { get; set; }

    public virtual DbSet<QbCurrencyRef> QbCurrencyRefs { get; set; }

    public virtual DbSet<QbCustomerMapping> QbCustomerMappings { get; set; }

    public virtual DbSet<QbCustomerMapping1> QbCustomerMappings1 { get; set; }

    public virtual DbSet<QbCustomerMappingMum> QbCustomerMappingMums { get; set; }

    public virtual DbSet<QbDepartmentRef> QbDepartmentRefs { get; set; }

    public virtual DbSet<QbExpenseItem> QbExpenseItems { get; set; }

    public virtual DbSet<QbExpenseMapping> QbExpenseMappings { get; set; }

    public virtual DbSet<QbItemsChennai> QbItemsChennais { get; set; }

    public virtual DbSet<QbItemsMumbai> QbItemsMumbais { get; set; }

    public virtual DbSet<QbPaymentTermsRef> QbPaymentTermsRefs { get; set; }

    public virtual DbSet<QbStateMaster> QbStateMasters { get; set; }

    public virtual DbSet<QbSyncHistory> QbSyncHistories { get; set; }

    public virtual DbSet<QbTaxMapping> QbTaxMappings { get; set; }

    public virtual DbSet<QbTaxMapping1> QbTaxMappings1 { get; set; }

    public virtual DbSet<QbTaxMappingMum> QbTaxMappingMums { get; set; }

    public virtual DbSet<QbTaxMappingOld> QbTaxMappingOlds { get; set; }

    public virtual DbSet<QbVendorMapping> QbVendorMappings { get; set; }

    public virtual DbSet<QbVendorMappingsTemp> QbVendorMappingsTemps { get; set; }

    public virtual DbSet<QbfChargeMapping> QbfChargeMappings { get; set; }

    public virtual DbSet<QbfChargeMappingOld> QbfChargeMappingOlds { get; set; }

    public virtual DbSet<R1ChargeGroup> R1ChargeGroups { get; set; }

    public virtual DbSet<R2ChargeGroup> R2ChargeGroups { get; set; }

    public virtual DbSet<R3ChargeGroup> R3ChargeGroups { get; set; }

    public virtual DbSet<R5ChargeGroup> R5ChargeGroups { get; set; }

    public virtual DbSet<RChargeGroup> RChargeGroups { get; set; }

    public virtual DbSet<ReportAcc1920> ReportAcc1920s { get; set; }

    public virtual DbSet<ReportAcc2021> ReportAcc2021s { get; set; }

    public virtual DbSet<ReportAcc202223V3> ReportAcc202223V3s { get; set; }

    public virtual DbSet<ReportAcc2122> ReportAcc2122s { get; set; }

    public virtual DbSet<ReportAcc2223> ReportAcc2223s { get; set; }

    public virtual DbSet<ReportUser> ReportUsers { get; set; }

    public virtual DbSet<Resource> Resources { get; set; }

    public virtual DbSet<SaleQuoteDetailNewdisplayView> SaleQuoteDetailNewdisplayViews { get; set; }

    public virtual DbSet<SalesCostCategory> SalesCostCategories { get; set; }

    public virtual DbSet<SalesQuote> SalesQuotes { get; set; }

    public virtual DbSet<SalesQuoteAdditionalDetail> SalesQuoteAdditionalDetails { get; set; }

    public virtual DbSet<SalesQuoteCharge> SalesQuoteCharges { get; set; }

    public virtual DbSet<SalesQuoteChargeItem> SalesQuoteChargeItems { get; set; }

    public virtual DbSet<SalesQuoteChargesNew> SalesQuoteChargesNews { get; set; }

    public virtual DbSet<SalesQuoteCommodity> SalesQuoteCommodities { get; set; }

    public virtual DbSet<SalesQuoteDetailsNew> SalesQuoteDetailsNews { get; set; }

    public virtual DbSet<SalesQuoteFile> SalesQuoteFiles { get; set; }

    public virtual DbSet<SalesQuoteHistory> SalesQuoteHistories { get; set; }

    public virtual DbSet<SalesQuoteNew> SalesQuoteNews { get; set; }

    public virtual DbSet<SalesQuoteService> SalesQuoteServices { get; set; }

    public virtual DbSet<SalesQuoteTypeMaster> SalesQuoteTypeMasters { get; set; }

    public virtual DbSet<SalesQuotesDetailView> SalesQuotesDetailViews { get; set; }

    public virtual DbSet<SerialNumberFormat> SerialNumberFormats { get; set; }

    public virtual DbSet<SubdivisionCode> SubdivisionCodes { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<TaskTypeMaster> TaskTypeMasters { get; set; }

    public virtual DbSet<TaxComponent> TaxComponents { get; set; }

    public virtual DbSet<TaxManual> TaxManuals { get; set; }

    public virtual DbSet<TaxMaster> TaxMasters { get; set; }

    public virtual DbSet<TaxRate> TaxRates { get; set; }

    public virtual DbSet<TempqbCustomersMapping> TempqbCustomersMappings { get; set; }

    public virtual DbSet<TerminalMaster> TerminalMasters { get; set; }

    public virtual DbSet<TrackingAirCarrier> TrackingAirCarriers { get; set; }

    public virtual DbSet<TrackingOceanCarrier> TrackingOceanCarriers { get; set; }

    public virtual DbSet<UniqueCustomer> UniqueCustomers { get; set; }

    public virtual DbSet<UnitConversionSetting> UnitConversionSettings { get; set; }

    public virtual DbSet<UnitMaster> UnitMasters { get; set; }

    public virtual DbSet<UnitTypeMaster> UnitTypeMasters { get; set; }

    public virtual DbSet<UploadedFile> UploadedFiles { get; set; }

    public virtual DbSet<UsedAirline> UsedAirlines { get; set; }

    public virtual DbSet<UsedAirport> UsedAirports { get; set; }

    public virtual DbSet<UsedOceanLine> UsedOceanLines { get; set; }

    public virtual DbSet<UsedOceanPort> UsedOceanPorts { get; set; }

    public virtual DbSet<UserMaster> UserMasters { get; set; }

    public virtual DbSet<UserOfficeAccess> UserOfficeAccesses { get; set; }

    public virtual DbSet<UserShowCalendar> UserShowCalendars { get; set; }

    public virtual DbSet<VariableMaster> VariableMasters { get; set; }

    public virtual DbSet<VendorBill> VendorBills { get; set; }

    public virtual DbSet<VendorBillLineItem> VendorBillLineItems { get; set; }

    public virtual DbSet<VesselMaster> VesselMasters { get; set; }

    public virtual DbSet<VwAccountStatstemp> VwAccountStatstemps { get; set; }

    public virtual DbSet<VwAccountsActivity> VwAccountsActivities { get; set; }

    public virtual DbSet<VwAccountsActivityReport> VwAccountsActivityReports { get; set; }

    public virtual DbSet<VwAccountsExpenseGroupBase> VwAccountsExpenseGroupBases { get; set; }

    public virtual DbSet<VwAccountsExpenseGroupBase2122> VwAccountsExpenseGroupBase2122s { get; set; }

    public virtual DbSet<VwAccountsGstAvary> VwAccountsGstAvaries { get; set; }

    public virtual DbSet<VwAccountsGstBase> VwAccountsGstBases { get; set; }

    public virtual DbSet<VwAccountsGstMain> VwAccountsGstMains { get; set; }

    public virtual DbSet<VwAccountsIncomeGroupBase> VwAccountsIncomeGroupBases { get; set; }

    public virtual DbSet<VwAccountsIncomeGroupBase2122> VwAccountsIncomeGroupBase2122s { get; set; }

    public virtual DbSet<VwAccountsShipmentList> VwAccountsShipmentLists { get; set; }

    public virtual DbSet<VwAccountsTaxbreakupBase> VwAccountsTaxbreakupBases { get; set; }

    public virtual DbSet<VwAgentwiseReport> VwAgentwiseReports { get; set; }

    public virtual DbSet<VwAirDocumentsStatus> VwAirDocumentsStatuses { get; set; }

    public virtual DbSet<VwAirstatus> VwAirstatuses { get; set; }

    public virtual DbSet<VwAllCargoList> VwAllCargoLists { get; set; }

    public virtual DbSet<VwAllCargoList1> VwAllCargoList1s { get; set; }

    public virtual DbSet<VwAllHbl> VwAllHbls { get; set; }

    public virtual DbSet<VwAppointment> VwAppointments { get; set; }

    public virtual DbSet<VwBasicDsrFormat> VwBasicDsrFormats { get; set; }

    public virtual DbSet<VwBasicDsrFormatChn> VwBasicDsrFormatChns { get; set; }

    public virtual DbSet<VwBasicDsrFormatChnInvno> VwBasicDsrFormatChnInvnos { get; set; }

    public virtual DbSet<VwBasicDsrFormatFy1819> VwBasicDsrFormatFy1819s { get; set; }

    public virtual DbSet<VwBasicDsrFormatPune> VwBasicDsrFormatPunes { get; set; }

    public virtual DbSet<VwBasicDsrFormatRingplu> VwBasicDsrFormatRingplus { get; set; }

    public virtual DbSet<VwBillList> VwBillLists { get; set; }

    public virtual DbSet<VwCampaignList> VwCampaignLists { get; set; }

    public virtual DbSet<VwCargoPackageDetailsText> VwCargoPackageDetailsTexts { get; set; }

    public virtual DbSet<VwCargoPackageSpool> VwCargoPackageSpools { get; set; }

    public virtual DbSet<VwCargoType> VwCargoTypes { get; set; }

    public virtual DbSet<VwCargoWeightInformation> VwCargoWeightInformations { get; set; }

    public virtual DbSet<VwCbmreport> VwCbmreports { get; set; }

    public virtual DbSet<VwChennaiDsrAi> VwChennaiDsrAis { get; set; }

    public virtual DbSet<VwChennaiDsrAiCando> VwChennaiDsrAiCandos { get; set; }

    public virtual DbSet<VwChennaiDsrOi> VwChennaiDsrOis { get; set; }

    public virtual DbSet<VwChennaiDsrOiCando> VwChennaiDsrOiCandos { get; set; }

    public virtual DbSet<VwChennaiDsrOiInvno> VwChennaiDsrOiInvnos { get; set; }

    public virtual DbSet<VwChennaiSalesJob> VwChennaiSalesJobs { get; set; }

    public virtual DbSet<VwChnDsrAe> VwChnDsrAes { get; set; }

    public virtual DbSet<VwChnDsrAi> VwChnDsrAis { get; set; }

    public virtual DbSet<VwChnDsrOi> VwChnDsrOis { get; set; }

    public virtual DbSet<VwCompanyAddress> VwCompanyAddresses { get; set; }

    public virtual DbSet<VwCompanyDetail> VwCompanyDetails { get; set; }

    public virtual DbSet<VwCompanyGst> VwCompanyGsts { get; set; }

    public virtual DbSet<VwCompanyShipmentCount> VwCompanyShipmentCounts { get; set; }

    public virtual DbSet<VwContainerCount> VwContainerCounts { get; set; }

    public virtual DbSet<VwContainerCount2> VwContainerCount2s { get; set; }

    public virtual DbSet<VwContainerCountNew> VwContainerCountNews { get; set; }

    public virtual DbSet<VwContainersPerCargoText> VwContainersPerCargoTexts { get; set; }

    public virtual DbSet<VwCsairExportDashboard> VwCsairExportDashboards { get; set; }

    public virtual DbSet<VwCsairImportDashboard> VwCsairImportDashboards { get; set; }

    public virtual DbSet<VwCsoceanExportDashboard> VwCsoceanExportDashboards { get; set; }

    public virtual DbSet<VwCsoceanImportDashboard> VwCsoceanImportDashboards { get; set; }

    public virtual DbSet<VwCustReportAug2020> VwCustReportAug2020s { get; set; }

    public virtual DbSet<VwCustomerOwnerList> VwCustomerOwnerLists { get; set; }

    public virtual DbSet<VwCustomerlist> VwCustomerlists { get; set; }

    public virtual DbSet<VwDetailsAddress> VwDetailsAddresses { get; set; }

    public virtual DbSet<VwDsr> VwDsrs { get; set; }

    public virtual DbSet<VwDsrAppointment> VwDsrAppointments { get; set; }

    public virtual DbSet<VwDsrCompany> VwDsrCompanies { get; set; }

    public virtual DbSet<VwDsrLead> VwDsrLeads { get; set; }

    public virtual DbSet<VwDsrMeeting> VwDsrMeetings { get; set; }

    public virtual DbSet<VwDsrMumbaiAirExport> VwDsrMumbaiAirExports { get; set; }

    public virtual DbSet<VwDsrMumbaiAirExportPatco> VwDsrMumbaiAirExportPatcos { get; set; }

    public virtual DbSet<VwDsrMumbaiAirImport> VwDsrMumbaiAirImports { get; set; }

    public virtual DbSet<VwDsrMumbaiOceanImport> VwDsrMumbaiOceanImports { get; set; }

    public virtual DbSet<VwDsrMumbaiOceanImportShort> VwDsrMumbaiOceanImportShorts { get; set; }

    public virtual DbSet<VwDsrPuneOceanExport> VwDsrPuneOceanExports { get; set; }

    public virtual DbSet<VwDsrPuneOceanImport> VwDsrPuneOceanImports { get; set; }

    public virtual DbSet<VwDsrTurkeyOceanExport> VwDsrTurkeyOceanExports { get; set; }

    public virtual DbSet<VwDsrTurkeyOceanImport> VwDsrTurkeyOceanImports { get; set; }

    public virtual DbSet<VwExpenseChargeNull> VwExpenseChargeNulls { get; set; }

    public virtual DbSet<VwFretlogSummary> VwFretlogSummaries { get; set; }

    public virtual DbSet<VwFyjobsDaily> VwFyjobsDailies { get; set; }

    public virtual DbSet<VwGoodPackXingdaReport> VwGoodPackXingdaReports { get; set; }

    public virtual DbSet<VwGoodPackXingdaReport1> VwGoodPackXingdaReport1s { get; set; }

    public virtual DbSet<VwGstCalculation> VwGstCalculations { get; set; }

    public virtual DbSet<VwGstinvoicelineitemsAug2017> VwGstinvoicelineitemsAug2017s { get; set; }

    public virtual DbSet<VwGstinvoicelineitemsJuly2017> VwGstinvoicelineitemsJuly2017s { get; set; }

    public virtual DbSet<VwGstinvoicesummaryAug2017> VwGstinvoicesummaryAug2017s { get; set; }

    public virtual DbSet<VwGstinvoicesummaryJuly2017> VwGstinvoicesummaryJuly2017s { get; set; }

    public virtual DbSet<VwHandlingCharge> VwHandlingCharges { get; set; }

    public virtual DbSet<VwInvoiceList> VwInvoiceLists { get; set; }

    public virtual DbSet<VwInvoiceTaxBreakup> VwInvoiceTaxBreakups { get; set; }

    public virtual DbSet<VwJobActivityByOffice> VwJobActivityByOffices { get; set; }

    public virtual DbSet<VwJobAdditionalDetail> VwJobAdditionalDetails { get; set; }

    public virtual DbSet<VwLeadSalesReport> VwLeadSalesReports { get; set; }

    public virtual DbSet<VwLinerReportExport> VwLinerReportExports { get; set; }

    public virtual DbSet<VwMumAirDsr> VwMumAirDsrs { get; set; }

    public virtual DbSet<VwOceanDocumentsStatus> VwOceanDocumentsStatuses { get; set; }

    public virtual DbSet<VwOceanExportStatus> VwOceanExportStatuses { get; set; }

    public virtual DbSet<VwOceanImportDocumentsStatus> VwOceanImportDocumentsStatuses { get; set; }

    public virtual DbSet<VwOpportunity> VwOpportunities { get; set; }

    public virtual DbSet<VwPatcoAirDsr> VwPatcoAirDsrs { get; set; }

    public virtual DbSet<VwPatcoOceanDsr> VwPatcoOceanDsrs { get; set; }

    public virtual DbSet<VwPolyrubShipment> VwPolyrubShipments { get; set; }

    public virtual DbSet<VwProductwiseShipmentCount> VwProductwiseShipmentCounts { get; set; }

    public virtual DbSet<VwProductwiseShipmentCountChn> VwProductwiseShipmentCountChns { get; set; }

    public virtual DbSet<VwProductwiseShipmentCountLastyear> VwProductwiseShipmentCountLastyears { get; set; }

    public virtual DbSet<VwProfitLossStatement> VwProfitLossStatements { get; set; }

    public virtual DbSet<VwProfitPerJob> VwProfitPerJobs { get; set; }

    public virtual DbSet<VwProfitPerJobNonTax> VwProfitPerJobNonTaxes { get; set; }

    public virtual DbSet<VwProfitPerJobTurkey> VwProfitPerJobTurkeys { get; set; }

    public virtual DbSet<VwProfitPerJobTurkeyKdv> VwProfitPerJobTurkeyKdvs { get; set; }

    public virtual DbSet<VwProfitPerJobTurkeyKdv1> VwProfitPerJobTurkeyKdv1s { get; set; }

    public virtual DbSet<VwProfitPerJobTurkeyKdvSq> VwProfitPerJobTurkeyKdvSqs { get; set; }

    public virtual DbSet<VwPuneAirExportDsr> VwPuneAirExportDsrs { get; set; }

    public virtual DbSet<VwPuneAirImportDsr> VwPuneAirImportDsrs { get; set; }

    public virtual DbSet<VwQbBillChargesBindFinal> VwQbBillChargesBindFinals { get; set; }

    public virtual DbSet<VwQbExpenseChargeNull> VwQbExpenseChargeNulls { get; set; }

    public virtual DbSet<VwQbInvoiceCharge> VwQbInvoiceCharges { get; set; }

    public virtual DbSet<VwQbInvoiceChargesBind> VwQbInvoiceChargesBinds { get; set; }

    public virtual DbSet<VwQbInvoiceChargesBindFinal> VwQbInvoiceChargesBindFinals { get; set; }

    public virtual DbSet<VwQbInvoiceLineItem> VwQbInvoiceLineItems { get; set; }

    public virtual DbSet<VwQbInvoiceLineItemsFinal> VwQbInvoiceLineItemsFinals { get; set; }

    public virtual DbSet<VwQbInvoiceTaxChennai> VwQbInvoiceTaxChennais { get; set; }

    public virtual DbSet<VwQbInvoiceTaxFinal> VwQbInvoiceTaxFinals { get; set; }

    public virtual DbSet<VwQbTaxCode> VwQbTaxCodes { get; set; }

    public virtual DbSet<VwQbTaxCodesBillFinal> VwQbTaxCodesBillFinals { get; set; }

    public virtual DbSet<VwQbTaxCodesFinal> VwQbTaxCodesFinals { get; set; }

    public virtual DbSet<VwQbTdsline> VwQbTdslines { get; set; }

    public virtual DbSet<VwQbVendorBillDataFinal> VwQbVendorBillDataFinals { get; set; }

    public virtual DbSet<VwQbVendorBillLineItemsFinal> VwQbVendorBillLineItemsFinals { get; set; }

    public virtual DbSet<VwQbVendorBillTaxFinal> VwQbVendorBillTaxFinals { get; set; }

    public virtual DbSet<VwQbchargeUniqueMapping> VwQbchargeUniqueMappings { get; set; }

    public virtual DbSet<VwQbexpenseUniqueMapping> VwQbexpenseUniqueMappings { get; set; }

    public virtual DbSet<VwQbinvoiceDataFinal> VwQbinvoiceDataFinals { get; set; }

    public virtual DbSet<VwQbinvoiceDatum> VwQbinvoiceData { get; set; }

    public virtual DbSet<VwRedEpartsAirDsr> VwRedEpartsAirDsrs { get; set; }

    public virtual DbSet<VwRedEpartsAirDsrDaily> VwRedEpartsAirDsrDailies { get; set; }

    public virtual DbSet<VwRedEpartsOceanDsr> VwRedEpartsOceanDsrs { get; set; }

    public virtual DbSet<VwRedEpartsOceanDsrDaily> VwRedEpartsOceanDsrDailies { get; set; }

    public virtual DbSet<VwRingplusCharge> VwRingplusCharges { get; set; }

    public virtual DbSet<VwRingplusLineExRate> VwRingplusLineExRates { get; set; }

    public virtual DbSet<VwSalesQuoteStatus> VwSalesQuoteStatuses { get; set; }

    public virtual DbSet<VwSalesReport> VwSalesReports { get; set; }

    public virtual DbSet<VwSalesReportBase> VwSalesReportBases { get; set; }

    public virtual DbSet<VwSalesReportHiren> VwSalesReportHirens { get; set; }

    public virtual DbSet<VwSalesReportMeeting> VwSalesReportMeetings { get; set; }

    public virtual DbSet<VwSalesReportNonTax> VwSalesReportNonTaxes { get; set; }

    public virtual DbSet<VwSalesReportTurkey> VwSalesReportTurkeys { get; set; }

    public virtual DbSet<VwSalesquoteinfo> VwSalesquoteinfos { get; set; }

    public virtual DbSet<VwSalesquoteinfoList> VwSalesquoteinfoLists { get; set; }

    public virtual DbSet<VwShipmentInvoiceGeneration> VwShipmentInvoiceGenerations { get; set; }

    public virtual DbSet<VwShipmentInvoiceGenerationChn> VwShipmentInvoiceGenerationChns { get; set; }

    public virtual DbSet<VwShipmentOperationsReport> VwShipmentOperationsReports { get; set; }

    public virtual DbSet<VwShipmentOperationsReportFy20> VwShipmentOperationsReportFy20s { get; set; }

    public virtual DbSet<VwShipmentReportSagar> VwShipmentReportSagars { get; set; }

    public virtual DbSet<VwSopreport> VwSopreports { get; set; }

    public virtual DbSet<VwStagingCustContainer> VwStagingCustContainers { get; set; }

    public virtual DbSet<VwStagingCustWeight> VwStagingCustWeights { get; set; }

    public virtual DbSet<VwStatusAirExport> VwStatusAirExports { get; set; }

    public virtual DbSet<VwStatusAirImport> VwStatusAirImports { get; set; }

    public virtual DbSet<VwStatusOceanExport> VwStatusOceanExports { get; set; }

    public virtual DbSet<VwStatusOceanExportCc> VwStatusOceanExportCcs { get; set; }

    public virtual DbSet<VwStatusOceanImport> VwStatusOceanImports { get; set; }

    public virtual DbSet<VwStatusPendingVendorBill> VwStatusPendingVendorBills { get; set; }

    public virtual DbSet<VwStatusReportAir> VwStatusReportAirs { get; set; }

    public virtual DbSet<VwStatusReportAirChn> VwStatusReportAirChns { get; set; }

    public virtual DbSet<VwStatusReportOcean> VwStatusReportOceans { get; set; }

    public virtual DbSet<VwStatusReportOceanChn> VwStatusReportOceanChns { get; set; }

    public virtual DbSet<VwTaskList> VwTaskLists { get; set; }

    public virtual DbSet<VwTeu> VwTeus { get; set; }

    public virtual DbSet<VwTeuI> VwTeuIs { get; set; }

    public virtual DbSet<VwTotalContainersPerCargo> VwTotalContainersPerCargos { get; set; }

    public virtual DbSet<VwTotalTeu> VwTotalTeus { get; set; }

    public virtual DbSet<VwVendorBill> VwVendorBills { get; set; }

    public virtual DbSet<VwWebArkasHbl> VwWebArkasHbls { get; set; }

    public virtual DbSet<VwWebCargoDocument> VwWebCargoDocuments { get; set; }

    public virtual DbSet<VwWebCargoList> VwWebCargoLists { get; set; }

    public virtual DbSet<VwWebCargoListDelivered> VwWebCargoListDelivereds { get; set; }

    public virtual DbSet<VwWebCargoPackage> VwWebCargoPackages { get; set; }

    public virtual DbSet<VwWebCargoStatus> VwWebCargoStatuses { get; set; }

    public virtual DbSet<VwWebDoc> VwWebDocs { get; set; }

    public virtual DbSet<VwWebDocsRp> VwWebDocsRps { get; set; }

    public virtual DbSet<VwWebStatusRp> VwWebStatusRps { get; set; }

    public virtual DbSet<VwWildRepublicCharge> VwWildRepublicCharges { get; set; }

    public virtual DbSet<VwWildRepublicChargesDsr> VwWildRepublicChargesDsrs { get; set; }

    public virtual DbSet<VwWildRepublicDocument> VwWildRepublicDocuments { get; set; }

    public virtual DbSet<VwWildRepublicDsr1> VwWildRepublicDsr1s { get; set; }

    public virtual DbSet<VwWildRepublicDsr2> VwWildRepublicDsr2s { get; set; }

    public virtual DbSet<VwWildRepublicPartDetail> VwWildRepublicPartDetails { get; set; }

    public virtual DbSet<VwWildRepublicStatus> VwWildRepublicStatuses { get; set; }

    public virtual DbSet<VwWildRepublicWebDoc> VwWildRepublicWebDocs { get; set; }

    public virtual DbSet<VwXingdaReport> VwXingdaReports { get; set; }

    public virtual DbSet<VwXingdaReportMumbai> VwXingdaReportMumbais { get; set; }

    public virtual DbSet<VwXingdaReportNew> VwXingdaReportNews { get; set; }

    public virtual DbSet<VwXingdaReportNew2> VwXingdaReportNew2s { get; set; }

    public virtual DbSet<VwreportCustomerWiseProfitMonthly> VwreportCustomerWiseProfitMonthlies { get; set; }

    public virtual DbSet<VwreportTopCustomersByProfit> VwreportTopCustomersByProfits { get; set; }

    public virtual DbSet<WebReportAccess> WebReportAccesses { get; set; }

    public virtual DbSet<WebReportFilter> WebReportFilters { get; set; }

    public virtual DbSet<WebReportMaster> WebReportMasters { get; set; }

    public virtual DbSet<WebRpair> WebRpairs { get; set; }

    public virtual DbSet<WebRpsea> WebRpseas { get; set; }

    public virtual DbSet<WebUser> WebUsers { get; set; }

    public virtual DbSet<WebUserAccess> WebUserAccesses { get; set; }

    public virtual DbSet<WorldCity> WorldCities { get; set; }
    public virtual DbSet<VwCargoNew> VwCargoNews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=68.64.173.137;Database=FretCloudDev;User Id=pratiksha;Password=prat@2023x;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
          modelBuilder.Entity<VwCargoNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Cargo_new");

        });

        modelBuilder.Entity<Abc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ABC");

            entity.Property(e => e.ArrivedAtDestination)
                .HasColumnType("datetime")
                .HasColumnName("Arrived at Destination");
            entity.Property(e => e.BlFirstPrint)
                .HasColumnType("datetime")
                .HasColumnName("BL First Print");
            entity.Property(e => e.BlIssuedByLiner)
                .HasColumnType("datetime")
                .HasColumnName("BL Issued by Liner");
            entity.Property(e => e.BlIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BL Issued to Customer");
            entity.Property(e => e.BookingConfirmed)
                .HasColumnType("datetime")
                .HasColumnName("Booking Confirmed");
            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.BookingNumber).HasMaxLength(30);
            entity.Property(e => e.BookingRequestReceived)
                .HasColumnType("datetime")
                .HasColumnName("Booking Request Received");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ContainerPickedUp)
                .HasColumnType("datetime")
                .HasColumnName("Container Picked Up");
            entity.Property(e => e.CostSheetApproval)
                .HasColumnType("datetime")
                .HasColumnName("Cost Sheet Approval");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.CustomsDocumentHandover)
                .HasColumnType("datetime")
                .HasColumnName("Customs Document Handover");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Delivered).HasColumnType("datetime");
            entity.Property(e => e.DestinationAgent)
                .HasMaxLength(100)
                .HasColumnName("DESTINATION_AGENT");
            entity.Property(e => e.DestinationCustomsCleared)
                .HasColumnType("datetime")
                .HasColumnName("Destination Customs Cleared");
            entity.Property(e => e.DestinationCustomsHold)
                .HasColumnType("datetime")
                .HasColumnName("Destination Customs Hold");
            entity.Property(e => e.DoSent)
                .HasColumnType("datetime")
                .HasColumnName("DO Sent");
            entity.Property(e => e.DocumentHandover)
                .HasColumnType("datetime")
                .HasColumnName("Document Handover");
            entity.Property(e => e.Draft)
                .HasColumnType("datetime")
                .HasColumnName("DRAFT");
            entity.Property(e => e.EpCopyHandover)
                .HasColumnType("datetime")
                .HasColumnName("EP Copy Handover");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InTransitToOriginPort)
                .HasColumnType("datetime")
                .HasColumnName("In Transit to Origin Port");
            entity.Property(e => e.InvoiceGeneration)
                .HasColumnType("datetime")
                .HasColumnName("Invoice Generation");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("Invoice Issued to Customer");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LoadingList)
                .HasColumnType("datetime")
                .HasColumnName("Loading List");
            entity.Property(e => e.ManifestSubmitted)
                .HasColumnType("datetime")
                .HasColumnName("Manifest Submitted");
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OceanCarrierName).HasMaxLength(30);
            entity.Property(e => e.OriginAgent)
                .HasMaxLength(100)
                .HasColumnName("ORIGIN_AGENT");
            entity.Property(e => e.PickedUpByCustomerAgent)
                .HasColumnType("datetime")
                .HasColumnName("Picked up by Customer/Agent");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlertSent)
                .HasColumnType("datetime")
                .HasColumnName("Pre-Alert Sent");
            entity.Property(e => e.ShippedOnBoard)
                .HasColumnType("datetime")
                .HasColumnName("Shipped On Board");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.SiFormatReceiptFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("SI Format Receipt from Customer");
            entity.Property(e => e.SiSubmissionToLiner)
                .HasColumnType("datetime")
                .HasColumnName("SI Submission to Liner");
            entity.Property(e => e.TotalGrossWeightKgs)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalGrossWeightKGS");
            entity.Property(e => e.TotalNetWeightKgs)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalNetWeightKGS");
            entity.Property(e => e.TotalVolumeCbm)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalVolumeCBM");
            entity.Property(e => e.User)
                .HasMaxLength(100)
                .HasColumnName("USER");
            entity.Property(e => e.VesselDeparture)
                .HasColumnType("datetime")
                .HasColumnName("Vessel Departure");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
        });

        modelBuilder.Entity<AccReport2223v2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acc_report-2223v2");

            entity.Property(e => e.JobNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AdditionalDetailsJob>(entity =>
        {
            entity.HasKey(e => e.AdditionalDetailsId).HasName("PK__Addition__946FAD6104CEE6A7");

            entity.ToTable("AdditionalDetailsJob");

            entity.Property(e => e.AdditionalDetailsId).HasColumnName("AdditionalDetailsID");
            entity.Property(e => e.AdditionalInfoId).HasColumnName("AdditionalInfoID");
            entity.Property(e => e.AdditionalInfoName).HasMaxLength(100);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
        });

        modelBuilder.Entity<AdditionalDetailsMaster>(entity =>
        {
            entity.HasKey(e => e.AdditionalInfoId).HasName("PK__Addition__2C4B52A68A3348F0");

            entity.ToTable("AdditionalDetailsMaster");

            entity.Property(e => e.AdditionalInfoId).HasColumnName("AdditionalInfoID");
            entity.Property(e => e.AdditionalInfoName).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<AirShipmentRouting>(entity =>
        {
            entity.HasKey(e => e.AirRoutingId);

            entity.ToTable("AirShipmentRouting");

            entity.HasIndex(e => new { e.ShipmentId, e.IsDeleted }, "idx_noncls_airshipmentrouting_shipmentid_isdeleted");

            entity.Property(e => e.AirRoutingId).HasColumnName("AirRoutingID");
            entity.Property(e => e.AirCarrierId).HasColumnName("AirCarrierID");
            entity.Property(e => e.AirCarrierName).HasMaxLength(60);
            entity.Property(e => e.Ata)
                .HasColumnType("datetime")
                .HasColumnName("ATA");
            entity.Property(e => e.Atd)
                .HasColumnType("datetime")
                .HasColumnName("ATD");
            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.BookingNumber).HasMaxLength(60);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.FlightNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Igmno)
                .HasMaxLength(50)
                .HasColumnName("igmno");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsPot1).HasColumnName("isPOT1");
            entity.Property(e => e.IsPot2).HasColumnName("isPOT2");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Podid).HasColumnName("PODID");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Polid).HasColumnName("POLID");
            entity.Property(e => e.Pot1)
                .HasMaxLength(50)
                .HasColumnName("POT1");
            entity.Property(e => e.Pot1date)
                .HasColumnType("datetime")
                .HasColumnName("POT1Date");
            entity.Property(e => e.Pot1id).HasColumnName("POT1ID");
            entity.Property(e => e.Pot2)
                .HasMaxLength(50)
                .HasColumnName("POT2");
            entity.Property(e => e.Pot2date)
                .HasColumnType("datetime")
                .HasColumnName("POT2Date");
            entity.Property(e => e.Pot2id).HasColumnName("POT2ID");
            entity.Property(e => e.RoutingOrder).HasDefaultValueSql("((1))");
            entity.Property(e => e.ShipmentId).HasColumnName("ShipmentID");
        });

        modelBuilder.Entity<AirlineMaster>(entity =>
        {
            entity.HasKey(e => e.AirlineId);

            entity.ToTable("AirlineMaster");

            entity.Property(e => e.AirlineId).HasColumnName("AirlineID");
            entity.Property(e => e.A2code)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A2Code");
            entity.Property(e => e.A3code)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A3Code");
            entity.Property(e => e.AirlineName).HasMaxLength(30);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.N3code)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("N3Code");
        });

        modelBuilder.Entity<ApplyPerMaster>(entity =>
        {
            entity.HasKey(e => e.ApplyPerId).HasName("PK__ApplyPer__6E50D6DDED2A6348");

            entity.ToTable("ApplyPerMaster");

            entity.Property(e => e.ApplyPerId).HasColumnName("ApplyPerID");
            entity.Property(e => e.ApplyPerCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ApplyPerName).HasMaxLength(30);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.AppontmentType).HasMaxLength(20);
            entity.Property(e => e.CompanyAddressId).HasColumnName("companyAddressID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Modifiedby).HasColumnName("modifiedby");
            entity.Property(e => e.Modifieddate)
                .HasColumnType("datetime")
                .HasColumnName("modifieddate");
            entity.Property(e => e.Nextstep)
                .HasMaxLength(200)
                .HasColumnName("nextstep");
            entity.Property(e => e.Purpose)
                .HasMaxLength(50)
                .HasColumnName("purpose");
            entity.Property(e => e.ResourceId).HasColumnName("ResourceID");
            entity.Property(e => e.ResourceIds).HasColumnName("ResourceIDs");
            entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Subject).HasMaxLength(50);
        });

        modelBuilder.Entity<ApprovalHistory>(entity =>
        {
            entity.ToTable("ApprovalHistory");

            entity.Property(e => e.ApprovalHistoryId).HasColumnName("ApprovalHistoryID");
            entity.Property(e => e.ApprovalEntityId).HasColumnName("ApprovalEntityID");
            entity.Property(e => e.ApprovalEntityReference).HasMaxLength(50);
            entity.Property(e => e.ApprovalQueueId).HasColumnName("ApprovalQueueID");
            entity.Property(e => e.ApprovalType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ApproverId).HasColumnName("ApproverID");
            entity.Property(e => e.CompletedDate).HasColumnType("datetime");
            entity.Property(e => e.CurrentStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isDeleted");
            entity.Property(e => e.IsRejected).HasColumnName("isRejected");
            entity.Property(e => e.Remarks).HasMaxLength(100);
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.RequestorId).HasColumnName("RequestorID");
        });

        modelBuilder.Entity<ApprovalQueue>(entity =>
        {
            entity.ToTable("ApprovalQueue");

            entity.Property(e => e.ApprovalQueueId).HasColumnName("ApprovalQueueID");
            entity.Property(e => e.ApprovalEntityId).HasColumnName("ApprovalEntityID");
            entity.Property(e => e.ApprovalEntityReference).HasMaxLength(50);
            entity.Property(e => e.ApprovalType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ApproverId).HasColumnName("ApproverID");
            entity.Property(e => e.CurrentStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isDeleted");
            entity.Property(e => e.Remarks).HasMaxLength(100);
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.RequestorId).HasColumnName("RequestorID");
        });

        modelBuilder.Entity<AttributeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AttributeMaster");

            entity.Property(e => e.AttributeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AttributeID");
            entity.Property(e => e.AttributeName).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
        });

        modelBuilder.Entity<AvaryShipmentGroup>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ChildJobNos).HasMaxLength(30);
            entity.Property(e => e.ParentJobId).HasColumnName("ParentJobID");
            entity.Property(e => e.ParentJobNo).HasMaxLength(30);
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
        });

        modelBuilder.Entity<Awbcharge>(entity =>
        {
            entity.ToTable("AWBCharges");

            entity.Property(e => e.AwbchargeId).HasColumnName("AWBChargeID");
            entity.Property(e => e.ApplyPer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AwbchargeTypeId).HasColumnName("AWBChargeTypeID");
            entity.Property(e => e.Awbid).HasColumnName("AWBID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ChargeAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DueType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

            entity.HasOne(d => d.Awb).WithMany(p => p.Awbcharges)
                .HasForeignKey(d => d.Awbid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AWBCharges_CargoAWB");
        });

        modelBuilder.Entity<AwbchargeMaster>(entity =>
        {
            entity.HasKey(e => e.AwbchargeTypeId);

            entity.ToTable("AWBChargeMaster");

            entity.Property(e => e.AwbchargeTypeId).HasColumnName("AWBChargeTypeID");
            entity.Property(e => e.ApplyPer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AwbchargeCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AWBChargeCode");
            entity.Property(e => e.AwbchargeDescription)
                .HasMaxLength(50)
                .HasColumnName("AWBChargeDescription");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DueType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
        });

        modelBuilder.Entity<BulkJobsApr22Sep22>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bulk_jobs_apr22_sep22");

            entity.Property(e => e.HblNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HBL No ");
            entity.Property(e => e.Month)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MONTH");
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr No");
        });

        modelBuilder.Entity<BulkMissingVendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bulk_MissingVendors");

            entity.Property(e => e.Fy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FY");
            entity.Property(e => e.Jobno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JOBNO");
            entity.Property(e => e.Month)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MONTH");
            entity.Property(e => e.Sheet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHEET");
        });

        modelBuilder.Entity<BulkMissingVendorsCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bulk_MissingVendorsCategory");

            entity.Property(e => e.Jobno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JOBNO");
            entity.Property(e => e.Srno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRNO");
        });

        modelBuilder.Entity<BuyingRate>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("trgAfterInsert"));

            entity.Property(e => e.BuyingRateId).HasColumnName("BuyingRateID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Bulk)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("bulk");
            entity.Property(e => e.C20ft)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("C20FT");
            entity.Property(e => e.C20gp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("C20GP");
            entity.Property(e => e.C20hc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("C20HC");
            entity.Property(e => e.C20ot)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("C20OT");
            entity.Property(e => e.C20rf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("C20RF");
            entity.Property(e => e.C40ft)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("C40FT");
            entity.Property(e => e.C40gp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("C40GP");
            entity.Property(e => e.C40hc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("C40HC");
            entity.Property(e => e.C40ot)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("C40OT");
            entity.Property(e => e.C40rf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("C40RF");
            entity.Property(e => e.CarrierId).HasColumnName("carrierID");
            entity.Property(e => e.CarrierName)
                .HasMaxLength(200)
                .HasColumnName("carrierName");
            entity.Property(e => e.Commodity).HasMaxLength(200);
            entity.Property(e => e.Contact).HasMaxLength(100);
            entity.Property(e => e.ContainerType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.Frequency)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsLcl).HasColumnName("isLCL");
            entity.Property(e => e.Lcl)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("LCL");
            entity.Property(e => e.Lclrate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("LCLRate");
            entity.Property(e => e.Minimum).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Notes).HasMaxLength(200);
            entity.Property(e => e.OfferDate).HasColumnType("datetime");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Podid).HasColumnName("PODID");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Polid).HasColumnName("POLID");
            entity.Property(e => e.Pot1)
                .HasMaxLength(50)
                .HasColumnName("POT1");
            entity.Property(e => e.Pot1id).HasColumnName("POT1ID");
            entity.Property(e => e.Pot2)
                .HasMaxLength(50)
                .HasColumnName("POT2");
            entity.Property(e => e.Pot2id).HasColumnName("POT2ID");
            entity.Property(e => e.Pot3)
                .HasMaxLength(50)
                .HasColumnName("POT3");
            entity.Property(e => e.Pot3id).HasColumnName("POT3ID");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.TaxName).HasMaxLength(50);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Terms).HasMaxLength(100);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TransitTime)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Campaign>(entity =>
        {
            entity.Property(e => e.CampaignId).HasColumnName("CampaignID");
            entity.Property(e => e.ActualCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActualResponse).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BudgetedCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CampaignDescription).HasMaxLength(200);
            entity.Property(e => e.CampaignName).HasMaxLength(50);
            entity.Property(e => e.CampaignOwnerId).HasColumnName("CampaignOwnerID");
            entity.Property(e => e.CampaignStatus)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CampaignTypeId).HasColumnName("CampaignTypeID");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ExpectedResponse).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExpectedRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.ParentCampaignId).HasColumnName("ParentCampaignID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.CampaignOwner).WithMany(p => p.Campaigns)
                .HasForeignKey(d => d.CampaignOwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Campaigns_UserMaster");

            entity.HasOne(d => d.CampaignType).WithMany(p => p.Campaigns)
                .HasForeignKey(d => d.CampaignTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Campaigns_CampaignTypeMaster");
        });

        modelBuilder.Entity<CampaignTargetList>(entity =>
        {
            entity.HasKey(e => e.CampaignTargetId);

            entity.ToTable("CampaignTargetList");

            entity.Property(e => e.CampaignTargetId).HasColumnName("CampaignTargetID");
            entity.Property(e => e.CampaignId).HasColumnName("CampaignID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsResponded).HasColumnName("isResponded");
            entity.Property(e => e.IsSent).HasColumnName("isSent");
            entity.Property(e => e.LeadId).HasColumnName("LeadID");
            entity.Property(e => e.RespondedDate).HasColumnType("datetime");
            entity.Property(e => e.ResponseLog).HasMaxLength(100);
            entity.Property(e => e.SentDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CampaignTypeMaster>(entity =>
        {
            entity.HasKey(e => e.CampaignTypeId);

            entity.ToTable("CampaignTypeMaster");

            entity.Property(e => e.CampaignTypeId).HasColumnName("CampaignTypeID");
            entity.Property(e => e.CampaignTypeName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.CargoId).HasName("PK_Table_2");

            entity.ToTable("Cargo");

            entity.HasIndex(e => new { e.TransportDirection, e.ModeOfTransport, e.DateCreated, e.IsDeleted, e.DestinationAgentId, e.CargoId, e.OpportunityId, e.CreatedBy }, "_dta_index_Cargo_7_1321771766__K7_K6_K40_K45_K36_K1_K13_K39_3_4_5_16_18_19_20_21_23_24_26_42_49");

            entity.HasIndex(e => new { e.IsDeleted, e.CustomerId, e.DateCreated }, "idx_Cargo_isDel_CustID_DateCreated");

            entity.HasIndex(e => new { e.IsDeleted, e.DateCreated }, "idx_noncls_Cargo_DateCreated_isdeleted");

            entity.HasIndex(e => new { e.ModeOfTransport, e.IsDeleted, e.DateCreated }, "idx_noncls_cargo_moed_isdel>");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoApprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CargoSopapprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CargoSOPApprovalStatus");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ConsigneeAddressId).HasColumnName("ConsigneeAddressID");
            entity.Property(e => e.ConsigneeId).HasColumnName("ConsigneeID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerReference).HasMaxLength(50);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddressId).HasColumnName("DeliveryAddressID");
            entity.Property(e => e.DestinationAgentAddressId).HasColumnName("DestinationAgentAddressID");
            entity.Property(e => e.DestinationAgentId).HasColumnName("DestinationAgentID");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.ForwardedAddressId).HasColumnName("ForwardedAddressID");
            entity.Property(e => e.ForwarderId).HasColumnName("ForwarderID");
            entity.Property(e => e.FreeDays).HasMaxLength(20);
            entity.Property(e => e.FreightStatus).HasMaxLength(30);
            entity.Property(e => e.HblStatus).HasMaxLength(20);
            entity.Property(e => e.HblTerm).HasMaxLength(20);
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.IncoTermId).HasColumnName("IncoTermID");
            entity.Property(e => e.IsConsolidation).HasColumnName("isConsolidation");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsGstJob).HasColumnName("isGstJob");
            entity.Property(e => e.IsHblnoautogenerate).HasColumnName("isHBLNOautogenerate");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LockedDate).HasColumnType("datetime");
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MblStatus).HasMaxLength(20);
            entity.Property(e => e.MblTerm).HasMaxLength(20);
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Notes).HasMaxLength(200);
            entity.Property(e => e.NotifyParty1).HasMaxLength(100);
            entity.Property(e => e.NotifyParty1AddressId).HasColumnName("NotifyParty1AddressID");
            entity.Property(e => e.NotifyParty1Id).HasColumnName("NotifyParty1ID");
            entity.Property(e => e.NotifyParty2AddressId).HasColumnName("NotifyParty2AddressID");
            entity.Property(e => e.NotifyParty2Id).HasColumnName("NotifyParty2ID");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");
            entity.Property(e => e.OriginAgentAddressId).HasColumnName("OriginAgentAddressID");
            entity.Property(e => e.OriginAgentId).HasColumnName("OriginAgentID");
            entity.Property(e => e.PaymentTerms).HasMaxLength(100);
            entity.Property(e => e.PickupAddressId).HasColumnName("PickupAddressID");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Podid).HasColumnName("PODID");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Polid).HasColumnName("POLID");
            entity.Property(e => e.Por)
                .HasMaxLength(100)
                .HasColumnName("POR");
            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.ShipperAddressId).HasColumnName("ShipperAddressID");
            entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfMoveId).HasColumnName("TypeOfMoveID");
        });

        modelBuilder.Entity<CargoAdditionalDetail>(entity =>
        {
            entity.HasKey(e => e.CargoAdditionalInfoId).HasName("PK__CargoAdd__5628BB219E924915");

            entity.Property(e => e.CargoAdditionalInfoId).HasColumnName("CargoAdditionalInfoID");
            entity.Property(e => e.ArrivalNoticeTo).HasMaxLength(100);
            entity.Property(e => e.BookingBlcost)
                .HasMaxLength(50)
                .HasColumnName("BookingBLCost");
            entity.Property(e => e.BookingCommodity).HasMaxLength(100);
            entity.Property(e => e.BookingContainerCount).HasMaxLength(100);
            entity.Property(e => e.BookingLcno)
                .HasMaxLength(100)
                .HasColumnName("BookingLCNo");
            entity.Property(e => e.BookingLoadingPlace).HasMaxLength(100);
            entity.Property(e => e.BookingOceanFreight).HasMaxLength(50);
            entity.Property(e => e.BookingOrderNo).HasMaxLength(100);
            entity.Property(e => e.BookingPayableAt).HasMaxLength(100);
            entity.Property(e => e.BookingPortCharges).HasMaxLength(50);
            entity.Property(e => e.BookingTo).HasMaxLength(100);
            entity.Property(e => e.BookingTrucking).HasMaxLength(100);
            entity.Property(e => e.BookingTruckingCost).HasMaxLength(50);
            entity.Property(e => e.BookingWarehousePickupDate).HasColumnType("datetime");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ContainerDepoAddress).HasMaxLength(1000);
            entity.Property(e => e.ContainerDepoPickupDate).HasColumnType("datetime");
            entity.Property(e => e.CustomsArea).HasMaxLength(200);
            entity.Property(e => e.CustomsBroker).HasMaxLength(200);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DocumentDeliveryAddress).HasMaxLength(500);
            entity.Property(e => e.Hsno)
                .HasMaxLength(100)
                .HasColumnName("HSNO");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isDeleted");
            entity.Property(e => e.Ktnotes).HasColumnName("KTNotes");
            entity.Property(e => e.TruckPlate).HasMaxLength(50);
            entity.Property(e => e.TruckerMobile).HasMaxLength(50);
        });

        modelBuilder.Entity<CargoAwb>(entity =>
        {
            entity.HasKey(e => e.Awbid);

            entity.ToTable("CargoAWB");

            entity.Property(e => e.Awbid).HasColumnName("AWBID");
            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.AccountingInformation).HasMaxLength(400);
            entity.Property(e => e.AgentsIatacode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AgentsIATACode");
            entity.Property(e => e.AirportOfDeparture).HasMaxLength(100);
            entity.Property(e => e.AirportOfDestination).HasMaxLength(100);
            entity.Property(e => e.AwbissuedBy)
                .HasMaxLength(200)
                .HasColumnName("AWBIssuedBy");
            entity.Property(e => e.By2).HasMaxLength(10);
            entity.Property(e => e.By3).HasMaxLength(10);
            entity.Property(e => e.ByFirstCarrier).HasMaxLength(50);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CcdestCurrency)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CCDestCurrency");
            entity.Property(e => e.Cghscode)
                .HasMaxLength(10)
                .HasColumnName("CGHSCode");
            entity.Property(e => e.ChargeableWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ChargesAtDestination).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ConsigneeAddress).HasMaxLength(300);
            entity.Property(e => e.ConsigneeAddressId).HasColumnName("ConsigneeAddressID");
            entity.Property(e => e.ConsigneeName).HasMaxLength(100);
            entity.Property(e => e.CurrencyCode).HasMaxLength(20);
            entity.Property(e => e.CurrencyConversionRates)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DeclaredValueForCarriage).HasMaxLength(50);
            entity.Property(e => e.DeclaredValueForCustoms).HasMaxLength(50);
            entity.Property(e => e.Description1).HasMaxLength(200);
            entity.Property(e => e.Description2).HasMaxLength(100);
            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.DueAgentColl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DueAgentCOLL");
            entity.Property(e => e.DueAgentPpd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DueAgentPPD");
            entity.Property(e => e.DueCarrierColl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DueCarrierCOLL");
            entity.Property(e => e.DueCarrierPpd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DueCarrierPPD");
            entity.Property(e => e.ExecutedOn).HasColumnType("datetime");
            entity.Property(e => e.ExecutedPlace).HasMaxLength(50);
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HandlingInformation).HasMaxLength(1000);
            entity.Property(e => e.HeadCenter)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HeadLeft)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HeadRight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HouseAwbnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HouseAWBNumber");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IssuingCarrierAddress).HasMaxLength(300);
            entity.Property(e => e.Kglb)
                .HasMaxLength(5)
                .HasColumnName("KGLB");
            entity.Property(e => e.MasterAwbnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MasterAWBNumber");
            entity.Property(e => e.NatureAndQuantityOfGoods).HasMaxLength(500);
            entity.Property(e => e.OtherCharges).HasMaxLength(500);
            entity.Property(e => e.OtherColl).HasColumnName("OtherCOLL");
            entity.Property(e => e.OtherPpd).HasColumnName("OtherPPD");
            entity.Property(e => e.RateCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RateClass).HasMaxLength(50);
            entity.Property(e => e.Reference1).HasMaxLength(50);
            entity.Property(e => e.Reference2).HasMaxLength(50);
            entity.Property(e => e.Reference3).HasMaxLength(50);
            entity.Property(e => e.RequestedFlight1).HasMaxLength(30);
            entity.Property(e => e.RequestedFlight2).HasMaxLength(30);
            entity.Property(e => e.RoutingTo1).HasMaxLength(10);
            entity.Property(e => e.Sci)
                .HasMaxLength(30)
                .HasColumnName("SCI");
            entity.Property(e => e.ShipperAddress).HasMaxLength(300);
            entity.Property(e => e.ShipperAddressId).HasColumnName("ShipperAddressID");
            entity.Property(e => e.ShipperName).HasMaxLength(100);
            entity.Property(e => e.SignatureOfIssuingCarrier).HasMaxLength(100);
            entity.Property(e => e.SignatureOfShipper).HasMaxLength(100);
            entity.Property(e => e.TaxColl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TaxCOLL");
            entity.Property(e => e.TaxPpd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TaxPPD");
            entity.Property(e => e.To2).HasMaxLength(10);
            entity.Property(e => e.To3).HasMaxLength(10);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalColl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalCOLL");
            entity.Property(e => e.TotalCollectCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPpd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalPPD");
            entity.Property(e => e.ValuationColl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValuationCOLL");
            entity.Property(e => e.ValuationPpd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValuationPPD");
            entity.Property(e => e.WeightChargeColl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WeightChargeCOLL");
            entity.Property(e => e.WeightChargePpd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WeightChargePPD");
            entity.Property(e => e.WeightUnitId).HasColumnName("WeightUnitID");
            entity.Property(e => e.WtvalColl).HasColumnName("WTValCOLL");
            entity.Property(e => e.WtvalPpd).HasColumnName("WTValPPD");
        });

        modelBuilder.Entity<CargoCan>(entity =>
        {
            entity.HasKey(e => e.Noticeid).HasName("PK__CargoCAN__4ED02246E58D4177");

            entity.ToTable("CargoCAN");

            entity.Property(e => e.Noticeid).HasColumnName("noticeid");
            entity.Property(e => e.Cargoid).HasColumnName("cargoid");
            entity.Property(e => e.Cargotype)
                .HasMaxLength(50)
                .HasColumnName("cargotype");
            entity.Property(e => e.Cfs)
                .HasMaxLength(100)
                .HasColumnName("CFS");
            entity.Property(e => e.Chaname)
                .HasMaxLength(200)
                .HasColumnName("CHAName");
            entity.Property(e => e.ConsigneeAddress).HasMaxLength(500);
            entity.Property(e => e.ConsigneeName).HasMaxLength(200);
            entity.Property(e => e.Containernos)
                .HasMaxLength(200)
                .HasColumnName("containernos");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DocumentType)
                .HasMaxLength(100)
                .HasColumnName("documentType");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.Finalagent)
                .HasMaxLength(100)
                .HasColumnName("finalagent");
            entity.Property(e => e.Hbldate)
                .HasColumnType("datetime")
                .HasColumnName("hbldate");
            entity.Property(e => e.Hblno)
                .HasMaxLength(100)
                .HasColumnName("HBLno");
            entity.Property(e => e.IgMsplitDate)
                .HasColumnType("datetime")
                .HasColumnName("IgMSplitDate");
            entity.Property(e => e.Imdate)
                .HasColumnType("datetime")
                .HasColumnName("imdate");
            entity.Property(e => e.Imno)
                .HasMaxLength(50)
                .HasColumnName("imno");
            entity.Property(e => e.Isdeleted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isdeleted");
            entity.Property(e => e.LineAddress).HasMaxLength(500);
            entity.Property(e => e.LineName).HasMaxLength(200);
            entity.Property(e => e.Lineno)
                .HasMaxLength(50)
                .HasColumnName("lineno");
            entity.Property(e => e.Mbldate)
                .HasColumnType("datetime")
                .HasColumnName("mbldate");
            entity.Property(e => e.Mblno)
                .HasMaxLength(100)
                .HasColumnName("MBLno");
            entity.Property(e => e.NoticeNo)
                .HasMaxLength(50)
                .HasColumnName("noticeNo");
            entity.Property(e => e.OblDate).HasColumnType("datetime");
            entity.Property(e => e.OblNumber).HasMaxLength(50);
            entity.Property(e => e.PackageDesc).HasMaxLength(200);
            entity.Property(e => e.PkgsCont).HasMaxLength(100);
            entity.Property(e => e.Poa)
                .HasMaxLength(200)
                .HasColumnName("POA");
            entity.Property(e => e.Pol)
                .HasMaxLength(200)
                .HasColumnName("POL");
            entity.Property(e => e.ShipperAddress).HasMaxLength(500);
            entity.Property(e => e.ShipperName).HasMaxLength(200);
            entity.Property(e => e.UnstuffDate).HasColumnType("datetime");
            entity.Property(e => e.Vesselvoyage)
                .HasMaxLength(100)
                .HasColumnName("vesselvoyage");
            entity.Property(e => e.WeightCbm)
                .HasMaxLength(100)
                .HasColumnName("WeightCBM");
        });

        modelBuilder.Entity<CargoCharge>(entity =>
        {
            entity.HasKey(e => e.ChargeId);

            entity.Property(e => e.ChargeId).HasColumnName("ChargeID");
            entity.Property(e => e.ApplyPer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.BillNo).HasMaxLength(100);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.ChargeItemId).HasColumnName("ChargeItemID");
            entity.Property(e => e.CostSheetId).HasColumnName("CostSheetID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.ExRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IncomeExpense)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.PayingPartyId).HasColumnName("PayingPartyID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SalesQuoteChargeId).HasColumnName("SalesQuoteChargeID");
            entity.Property(e => e.SalesQuoteChargeItemId).HasColumnName("SalesQuoteChargeItemID");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalNonTaxableAmount).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CargoContainer>(entity =>
        {
            entity.HasKey(e => e.ContainerId);

            entity.HasIndex(e => new { e.IsDeleted, e.CargoId }, "_dta_index_CargoContainers_7_1867153697__K15_K3");

            entity.HasIndex(e => new { e.IsDeleted, e.CargoId, e.ContainerCode }, "_dta_index_CargoContainers_7_1867153697__K15_K3_K4_5");

            entity.HasIndex(e => new { e.IsDeleted, e.ContainerCode, e.CargoId }, "_dta_index_CargoContainers_7_1867153697__K15_K4_K3");

            entity.HasIndex(e => new { e.CargoId, e.IsDeleted, e.ContainerCode }, "_dta_index_CargoContainers_7_1867153697__K3_K15_K4");

            entity.Property(e => e.ContainerId).HasColumnName("ContainerID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ContainerNumber).HasMaxLength(15);
            entity.Property(e => e.ContainerTypeId).HasColumnName("ContainerTypeID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.Seal1).HasMaxLength(15);
            entity.Property(e => e.Seal2).HasMaxLength(15);
            entity.Property(e => e.Vgmweight)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VGMWeight");

            entity.HasOne(d => d.Cargo).WithMany(p => p.CargoContainers)
                .HasForeignKey(d => d.CargoId)
                .HasConstraintName("FK_CargoContainers_Cargo");

            entity.HasOne(d => d.ContainerType).WithMany(p => p.CargoContainers)
                .HasForeignKey(d => d.ContainerTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CargoContainers_PackageTypes");
        });

        modelBuilder.Entity<CargoDocument>(entity =>
        {
            entity.Property(e => e.CargoDocumentId).HasColumnName("CargoDocumentID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DocumentFileType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DocumentType).HasMaxLength(30);
            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.Ftplink)
                .HasMaxLength(200)
                .HasColumnName("FTPLink");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isDeleted");
            entity.Property(e => e.Remarks).HasMaxLength(100);
        });

        modelBuilder.Entity<CargoEntity>(entity =>
        {
            entity.Property(e => e.CargoEntityId).HasColumnName("CargoEntityID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.EntityAddressId).HasColumnName("EntityAddressID");
            entity.Property(e => e.EntityAddressLine1).HasMaxLength(300);
            entity.Property(e => e.EntityCity).HasMaxLength(30);
            entity.Property(e => e.EntityCityId).HasColumnName("EntityCityID");
            entity.Property(e => e.EntityCountry)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EntityCountryId).HasColumnName("EntityCountryID");
            entity.Property(e => e.EntityDisplayText).HasMaxLength(500);
            entity.Property(e => e.EntityName).HasMaxLength(100);
            entity.Property(e => e.EntityState).HasMaxLength(30);
            entity.Property(e => e.EntityStateId).HasColumnName("EntityStateID");
            entity.Property(e => e.EntityTypeId).HasColumnName("EntityTypeID");
            entity.Property(e => e.EntityZipCode).HasMaxLength(15);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsPayor).HasColumnName("isPayor");
        });

        modelBuilder.Entity<CargoHbl>(entity =>
        {
            entity.HasKey(e => e.Hblid);

            entity.ToTable("CargoHBL");

            entity.Property(e => e.Hblid).HasColumnName("HBLID");
            entity.Property(e => e.Blby)
                .HasMaxLength(100)
                .HasColumnName("BLby");
            entity.Property(e => e.ByAgentForCarrier).HasMaxLength(100);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ConsigneeAddress).HasMaxLength(400);
            entity.Property(e => e.ConsigneeAddressId).HasColumnName("ConsigneeAddressID");
            entity.Property(e => e.ConsigneeName).HasMaxLength(100);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DeclaredValue).HasMaxLength(100);
            entity.Property(e => e.DeliveryInstructions).HasMaxLength(500);
            entity.Property(e => e.Description1).HasMaxLength(200);
            entity.Property(e => e.Description2).HasMaxLength(200);
            entity.Property(e => e.DestinationIhc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DestinationIHC");
            entity.Property(e => e.DestinationThc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DestinationTHC");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.ExportReferences).HasMaxLength(300);
            entity.Property(e => e.ForeignPortUnloading).HasMaxLength(100);
            entity.Property(e => e.ForwardingAgent).HasMaxLength(100);
            entity.Property(e => e.ForwardingAgentAddress).HasMaxLength(300);
            entity.Property(e => e.ForwardingAgentAddressId).HasColumnName("ForwardingAgentAddressID");
            entity.Property(e => e.GrossWeight).HasMaxLength(300);
            entity.Property(e => e.Hbldate)
                .HasColumnType("datetime")
                .HasColumnName("HBLDate");
            entity.Property(e => e.Hblnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HBLNumber");
            entity.Property(e => e.Hblplace)
                .HasMaxLength(50)
                .HasColumnName("HBLPlace");
            entity.Property(e => e.IsContainerized).HasColumnName("isContainerized");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.LoadingTerminal).HasMaxLength(100);
            entity.Property(e => e.Mblnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MBLNumber");
            entity.Property(e => e.Measurement).HasMaxLength(300);
            entity.Property(e => e.Movement).HasMaxLength(100);
            entity.Property(e => e.NotifyAddress).HasMaxLength(400);
            entity.Property(e => e.NotifyAddressId).HasColumnName("NotifyAddressID");
            entity.Property(e => e.NotifyName).HasMaxLength(100);
            entity.Property(e => e.OceanFreight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OriginIhc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OriginIHC");
            entity.Property(e => e.OriginThc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OriginTHC");
            entity.Property(e => e.PlaceOfDelivery).HasMaxLength(100);
            entity.Property(e => e.PlaceOfReceipt).HasMaxLength(100);
            entity.Property(e => e.PointOfOriginFtz)
                .HasMaxLength(100)
                .HasColumnName("PointOfOriginFTZ");
            entity.Property(e => e.PortOfDischarge).HasMaxLength(100);
            entity.Property(e => e.PortOfLoading).HasMaxLength(100);
            entity.Property(e => e.PreCarriageBy).HasMaxLength(100);
            entity.Property(e => e.ShipperAddress).HasMaxLength(400);
            entity.Property(e => e.ShipperAddressId).HasColumnName("ShipperAddressID");
            entity.Property(e => e.ShipperName).HasMaxLength(100);
            entity.Property(e => e.TotalCp)
                .HasMaxLength(100)
                .HasColumnName("TotalCP");
            entity.Property(e => e.TypeOfMove).HasMaxLength(100);
            entity.Property(e => e.VesselVoyage).HasMaxLength(100);
        });

        modelBuilder.Entity<CargoPackage>(entity =>
        {
            entity.HasKey(e => e.CargoPackId);

            entity.Property(e => e.CargoPackId).HasColumnName("CargoPackID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoPackName).HasMaxLength(30);
            entity.Property(e => e.CargoPackTypeId).HasColumnName("CargoPackTypeID");
            entity.Property(e => e.ContainerId).HasColumnName("ContainerID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(30);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsPerPackage)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isPerPackage");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MarksAndNumbers).HasMaxLength(100);
            entity.Property(e => e.NetWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PackageDescription).HasMaxLength(100);
            entity.Property(e => e.ParentPackageId).HasColumnName("ParentPackageID");
            entity.Property(e => e.Sbdate)
                .HasColumnType("datetime")
                .HasColumnName("SBDate");
            entity.Property(e => e.Sbno)
                .HasMaxLength(30)
                .HasColumnName("SBNo");
            entity.Property(e => e.SizeId).HasColumnName("SizeID");
            entity.Property(e => e.TotalGrossWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalNetWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalVolume).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TotalVolumeWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Volume).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.VolumeCbm)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("VolumeCBM");
            entity.Property(e => e.VolumeFt3)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VolumeFT3");
            entity.Property(e => e.VolumeUnitId).HasColumnName("VolumeUnitID");
            entity.Property(e => e.VolumeWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WeightKgs)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("WeightKGS");
            entity.Property(e => e.WeightLbs)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("WeightLBS");
            entity.Property(e => e.WeightUnitId).HasColumnName("WeightUnitID");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Cargo).WithMany(p => p.CargoPackages)
                .HasForeignKey(d => d.CargoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CargoPackages_Cargo");

            entity.HasOne(d => d.CargoPackType).WithMany(p => p.CargoPackages)
                .HasForeignKey(d => d.CargoPackTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CargoPackages_PackageTypes");

            entity.HasOne(d => d.Container).WithMany(p => p.CargoPackages)
                .HasForeignKey(d => d.ContainerId)
                .HasConstraintName("FK_CargoPackages_CargoContainers");
        });

        modelBuilder.Entity<CargoStatus>(entity =>
        {
            entity.HasKey(e => e.CargoStatusId).HasName("PK_CargoStatus");

            entity.HasIndex(e => new { e.CargoId, e.IsDeleted }, "idx_noncls_cargostatus_statusname_statusdate");

            entity.Property(e => e.CargoStatusId).HasColumnName("CargoStatusID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoStatusDate).HasColumnType("datetime");
            entity.Property(e => e.CargoStatusName).HasMaxLength(50);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModifed).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsExpected).HasColumnName("isExpected");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StatusRemarks).HasMaxLength(100);

            entity.HasOne(d => d.Cargo).WithMany(p => p.CargoStatuses)
                .HasForeignKey(d => d.CargoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CargoStatus_Cargo");

            entity.HasOne(d => d.Status).WithMany(p => p.CargoStatuses)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_CargoStatus_CargoStatusMaster");
        });

        modelBuilder.Entity<CargoStatusMaster>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("CargoStatusMaster");

            entity.Property(e => e.StatusId)
                .ValueGeneratedNever()
                .HasColumnName("StatusID");
            entity.Property(e => e.AutoTaskTemplateId).HasColumnName("AutoTaskTemplateID");
            entity.Property(e => e.IsCompulsary)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isCompulsary");
            entity.Property(e => e.IsSystemGenerated).HasColumnName("isSystemGenerated");
            entity.Property(e => e.IsWebTracking).HasColumnName("isWebTracking");
            entity.Property(e => e.RelatedCargoDocumentId).HasColumnName("RelatedCargoDocumentID");
            entity.Property(e => e.StatusName).HasMaxLength(50);
            entity.Property(e => e.StatusReferenceNumber).HasMaxLength(50);
            entity.Property(e => e.StatusServiceType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CargoTask>(entity =>
        {
            entity.HasKey(e => e.TaskId);

            entity.Property(e => e.TaskId)
                .ValueGeneratedNever()
                .HasColumnName("TaskID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");

            entity.HasOne(d => d.Cargo).WithMany(p => p.CargoTasks)
                .HasForeignKey(d => d.CargoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CargoTasks_Cargo");

            entity.HasOne(d => d.Task).WithOne(p => p.CargoTask)
                .HasForeignKey<CargoTask>(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CargoTasks_Tasks");
        });

        modelBuilder.Entity<Cargochargestemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CARGOCHARGESTEMP");

            entity.Property(e => e.ApplyPer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.ChargeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ChargeID");
            entity.Property(e => e.ChargeItemId).HasColumnName("ChargeItemID");
            entity.Property(e => e.CostSheetId).HasColumnName("CostSheetID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.ExRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IncomeExpense)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.PayingPartyId).HasColumnName("PayingPartyID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SalesQuoteChargeId).HasColumnName("SalesQuoteChargeID");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalNonTaxableAmount).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Cargochargestemp1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cargochargestemp1");

            entity.Property(e => e.ApplyPer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.ChargeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ChargeID");
            entity.Property(e => e.ChargeItemId).HasColumnName("ChargeItemID");
            entity.Property(e => e.CostSheetId).HasColumnName("CostSheetID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.ExRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IncomeExpense)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.PayingPartyId).HasColumnName("PayingPartyID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SalesQuoteChargeId).HasColumnName("SalesQuoteChargeID");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalNonTaxableAmount).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<ChargeAttribute>(entity =>
        {
            entity.Property(e => e.ChargeAttributeId).HasColumnName("ChargeAttributeID");
            entity.Property(e => e.ChargeAmount).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.EndRange).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.MaximumAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MinimumAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SalesQuoteChargeId).HasColumnName("SalesQuoteChargeID");
            entity.Property(e => e.StartRange).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");

            entity.HasOne(d => d.Currency).WithMany(p => p.ChargeAttributes)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("FK_ChargeAttributes_CurrencyMaster");

            entity.HasOne(d => d.SalesQuoteCharge).WithMany(p => p.ChargeAttributes)
                .HasForeignKey(d => d.SalesQuoteChargeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChargeAttributes_SalesQuoteCharges");
        });

        modelBuilder.Entity<ChargeGroupMaster>(entity =>
        {
            entity.HasKey(e => e.ChargeGroupId);

            entity.ToTable("ChargeGroupMaster");

            entity.Property(e => e.ChargeGroupId).HasColumnName("ChargeGroupID");
            entity.Property(e => e.ChargeGroupCode)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ChargeGroupDescription).HasMaxLength(100);
            entity.Property(e => e.ChargeGroupName).HasMaxLength(30);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.IsAir).HasColumnName("isAir");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsExpense).HasColumnName("isExpense");
            entity.Property(e => e.IsIncome).HasColumnName("isIncome");
            entity.Property(e => e.IsOcean).HasColumnName("isOcean");
            entity.Property(e => e.IsSurface).HasColumnName("isSurface");
            entity.Property(e => e.ParentChargeGroupId).HasColumnName("ParentChargeGroupID");
        });

        modelBuilder.Entity<ChargeHead>(entity =>
        {
            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeGroupId).HasColumnName("ChargeGroupID");
            entity.Property(e => e.ChargeGroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChargeHeadName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IncomeExpense)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.TaxName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<ChargeItemMaster>(entity =>
        {
            entity.HasKey(e => e.ChargeItemId);

            entity.ToTable("ChargeItemMaster");

            entity.Property(e => e.ChargeItemId).HasColumnName("ChargeItemID");
            entity.Property(e => e.ChargeDescription).HasMaxLength(100);
            entity.Property(e => e.ChargeItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ChargeItemName).HasMaxLength(50);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.ExpenseAccountHead)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpenseAccountHeadId).HasColumnName("ExpenseAccountHeadID");
            entity.Property(e => e.IncomeAccountHead)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IncomeAccountHeadId).HasColumnName("IncomeAccountHeadID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsExpense).HasColumnName("isExpense");
            entity.Property(e => e.OperationsGroup)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.TaxName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TransportationDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TransportationMethod)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ChargeMasterAbt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChargeMasterABT");

            entity.Property(e => e.ChargeId).HasColumnName("ChargeID");
            entity.Property(e => e.ChargePercent).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ChargeheadsIst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CHARGEHEADS_IST");

            entity.Property(e => e.ChargeGroupId).HasColumnName("ChargeGroupID");
            entity.Property(e => e.ChargeGroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChargeHeadId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IncomeExpense)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.TaxName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CityMaster>(entity =>
        {
            entity.HasKey(e => e.CityId);

            entity.ToTable("CityMaster");

            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.StateId).HasColumnName("StateID");

            entity.HasOne(d => d.State).WithMany(p => p.CityMasters)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CityMaster_CountryStateMaster");
        });

        modelBuilder.Entity<CldocsAttached>(entity =>
        {
            entity.HasKey(e => e.CourierDocDetailId).HasName("PK__CLDocsAt__010A48CBE4136A68");

            entity.ToTable("CLDocsAttached");

            entity.Property(e => e.IsAttached).HasColumnName("isAttached");
        });

        modelBuilder.Entity<CommodityMaster>(entity =>
        {
            entity.HasKey(e => e.CommodityId);

            entity.ToTable("CommodityMaster");

            entity.Property(e => e.CommodityId).HasColumnName("CommodityID");
            entity.Property(e => e.CommodityName).HasMaxLength(50);
            entity.Property(e => e.CommodityType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Hscode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("HSCode");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsHazardous).HasColumnName("isHazardous");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasIndex(e => new { e.CompanyId, e.CompanyName }, "_dta_index_Companies_7_1422628111__K1_K2");

            entity.HasIndex(e => e.IsDeleted, "idx_noncls_Companies_isDeleted");

            entity.HasIndex(e => new { e.IsDeleted, e.OwnerId }, "idx_noncls_Companies_isDeleted_ownerID");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CafReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.CompanyApprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");
            entity.Property(e => e.CompanyTypeName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreditDays).HasMaxLength(20);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gstin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GSTIN");
            entity.Property(e => e.GsttypeId).HasColumnName("GSTTypeID");
            entity.Property(e => e.GsttypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GSTTypeName");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.MepzCode).HasMaxLength(20);
            entity.Property(e => e.Notes).HasMaxLength(200);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OwnerId).HasColumnName("ownerID");
            entity.Property(e => e.Pan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAN");
            entity.Property(e => e.Pannumber)
                .HasMaxLength(100)
                .HasColumnName("PANnumber");
            entity.Property(e => e.ParentCompanyId).HasColumnName("ParentCompanyID");
            entity.Property(e => e.PaymentTermId).HasColumnName("PaymentTermID");
            entity.Property(e => e.PaymentTermLabel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CompanyType).WithMany(p => p.Companies)
                .HasForeignKey(d => d.CompanyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Companies_CompanyTypes");
        });

        modelBuilder.Entity<CompanyAddress>(entity =>
        {
            entity.ToTable("CompanyAddress");

            entity.HasIndex(e => e.AddressTypeNick, "idx_noncls_CompanyAddress_atn_incl_compid_formattedaddr");

            entity.Property(e => e.CompanyAddressId).HasColumnName("CompanyAddressID");
            entity.Property(e => e.AddressLine1).HasMaxLength(100);
            entity.Property(e => e.AddressLine2).HasMaxLength(100);
            entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");
            entity.Property(e => e.AddressTypeNick).HasMaxLength(30);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Faxnumber)
                .HasMaxLength(30)
                .HasColumnName("FAxnumber");
            entity.Property(e => e.FormattedAddress).HasMaxLength(500);
            entity.Property(e => e.Gstnumber)
                .HasMaxLength(100)
                .HasColumnName("GSTnumber");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.Phone1).HasMaxLength(15);
            entity.Property(e => e.Phone2).HasMaxLength(15);
            entity.Property(e => e.RelatedAirportId).HasColumnName("RelatedAirportID");
            entity.Property(e => e.RelatedPortId).HasColumnName("RelatedPortID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.StateName).HasMaxLength(50);
            entity.Property(e => e.Zipcode)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.City).WithMany(p => p.CompanyAddresses)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_CompanyAddress_CityMaster");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyAddresses)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyAddress_Companies");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.CompanyAddresses)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyAddress_CountryMaster");

            entity.HasOne(d => d.RelatedAirport).WithMany(p => p.CompanyAddressRelatedAirports)
                .HasForeignKey(d => d.RelatedAirportId)
                .HasConstraintName("FK_CompanyAddress_LocationMaster_Airports");

            entity.HasOne(d => d.RelatedPort).WithMany(p => p.CompanyAddressRelatedPorts)
                .HasForeignKey(d => d.RelatedPortId)
                .HasConstraintName("FK_CompanyAddress_LocationMaster");

            entity.HasOne(d => d.State).WithMany(p => p.CompanyAddresses)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_CompanyAddress_CountryStateMaster");
        });

        modelBuilder.Entity<CompanyAttribute>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AttributeId).HasColumnName("AttributeID");
            entity.Property(e => e.CompanyAttributeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CompanyAttributeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.LeadId).HasColumnName("LeadID");
            entity.Property(e => e.ModeofTransport).HasMaxLength(30);
        });

        modelBuilder.Entity<CompanyBankAccount>(entity =>
        {
            entity.HasKey(e => e.BankAccountId);

            entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BankContactName).HasMaxLength(50);
            entity.Property(e => e.BankContactNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.Branch).HasMaxLength(30);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Iban)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IBAN");
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.Swift)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SWIFT");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyBankAccounts)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyBankAccounts_Companies");
        });

        modelBuilder.Entity<CompanyCaf>(entity =>
        {
            entity.HasKey(e => e.Cafid).HasName("PK__CompanyC__09921CC31C20358D");

            entity.ToTable("CompanyCAF");

            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Comments).HasMaxLength(200);
            entity.Property(e => e.Commodities).HasMaxLength(200);
            entity.Property(e => e.ContactPersonMob)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Contactpersonname)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreditLimitApplied)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreditTermApplied)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreditTermApproved)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DateofApplication).HasColumnType("datetime");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Gstno)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ImportexportDetails).HasMaxLength(200);
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pan)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PrsnApplyinCredit)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrsnDesignationApplyinCredit)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Regaddress).HasMaxLength(200);
            entity.Property(e => e.Regfax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("regfax");
            entity.Property(e => e.Regmobile)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Regtel)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Servicetaxno)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ShipmentsFrequency)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tan)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VolumePerShipment)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CompanyDocument>(entity =>
        {
            entity.HasKey(e => e.DocumentId);

            entity.ToTable("Company_Documents");

            entity.Property(e => e.DocumentId)
                .ValueGeneratedNever()
                .HasColumnName("DocumentID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyDocuments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Company_Documents_Documents");

            entity.HasOne(d => d.Document).WithOne(p => p.CompanyDocument)
                .HasForeignKey<CompanyDocument>(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Company_Documents_CompanyDocuments");
        });

        modelBuilder.Entity<CompanyDocument1>(entity =>
        {
            entity.HasKey(e => e.DocumentId);

            entity.ToTable("CompanyDocuments");

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentLink).HasMaxLength(300);
            entity.Property(e => e.DocumentType).HasMaxLength(30);
            entity.Property(e => e.FileExtension)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FileName).HasMaxLength(150);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyDocument1s)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyDocuments_Companies");
        });

        modelBuilder.Entity<CompanyPhone>(entity =>
        {
            entity.HasKey(e => e.PhoneId);

            entity.Property(e => e.PhoneId).HasColumnName("PhoneID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CountryName).HasMaxLength(50);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.Extension)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PhoneReference).HasMaxLength(30);
            entity.Property(e => e.PhoneTypeId).HasColumnName("PhoneTypeID");
            entity.Property(e => e.Stdcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STDCode");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyPhones)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyPhones_Companies");
        });

        modelBuilder.Entity<CompanyReportGrouping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyReportGrouping");

            entity.Property(e => e.ActualComanyId).HasColumnName("ActualComanyID");
            entity.Property(e => e.CompanyDisplayName).HasMaxLength(500);
            entity.Property(e => e.CompanyStartDate).HasColumnType("datetime");
            entity.Property(e => e.DuplicateCompanyId).HasColumnName("DuplicateCompanyID");
        });

        modelBuilder.Entity<CompanyType>(entity =>
        {
            entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");
            entity.Property(e => e.CompanyType1)
                .HasMaxLength(30)
                .HasColumnName("CompanyType");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsInternal).HasColumnName("isInternal");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Department)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName).HasMaxLength(120);
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(35);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.LastName).HasMaxLength(35);
            entity.Property(e => e.MiddleName).HasMaxLength(35);
            entity.Property(e => e.Mobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Notes).HasMaxLength(200);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Salutation).HasMaxLength(10);

            entity.HasOne(d => d.Company).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contacts_Companies");
        });

        modelBuilder.Entity<ContactType>(entity =>
        {
            entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");
            entity.Property(e => e.ContactTypeName).HasMaxLength(50);
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isActive");
        });

        modelBuilder.Entity<CostSheet>(entity =>
        {
            entity.ToTable("CostSheet");

            entity.Property(e => e.CostSheetId).HasColumnName("CostSheetID");
            entity.Property(e => e.BuyExRateEur)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BuyExRateEUR");
            entity.Property(e => e.BuyExRateInr)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BuyExRateINR");
            entity.Property(e => e.BuyExRateTl)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BuyExRateTL");
            entity.Property(e => e.BuyExRateUsd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BuyExRateUSD");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CostCategoryId).HasColumnName("CostCategoryID");
            entity.Property(e => e.CostSheetStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CostSheetType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRateDate).HasColumnType("datetime");
            entity.Property(e => e.SellExRateEur)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SellExRateEUR");
            entity.Property(e => e.SellExRateInr)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SellExRateINR");
            entity.Property(e => e.SellExRateTl)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SellExRateTL");
            entity.Property(e => e.SellExRateUsd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SellExRateUSD");
            entity.Property(e => e.VerifiedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<CounterMaster>(entity =>
        {
            entity.HasKey(e => e.CounterId);

            entity.ToTable("CounterMaster");

            entity.Property(e => e.CounterId).HasColumnName("CounterID");
            entity.Property(e => e.CounterName).HasMaxLength(50);
        });

        modelBuilder.Entity<CountryMaster>(entity =>
        {
            entity.HasKey(e => e.CountryId);

            entity.ToTable("CountryMaster");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.ContinentName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CountryName).HasMaxLength(50);
        });

        modelBuilder.Entity<CountryStateMaster>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.ToTable("CountryStateMaster");

            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.StateCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StateName).HasMaxLength(50);

            entity.HasOne(d => d.Country).WithMany(p => p.CountryStateMasters)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CountryStateMaster_CountryMaster");
        });

        modelBuilder.Entity<CourierCoveringLetter>(entity =>
        {
            entity.HasKey(e => e.CourierDocId).HasName("PK__CourierC__7C91840BB4695992");

            entity.ToTable("CourierCoveringLetter");

            entity.Property(e => e.Cargoid).HasColumnName("cargoid");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DocPreparedOn).HasColumnType("datetime");
            entity.Property(e => e.DocPreparedbyId).HasColumnName("DocPreparedbyID");
            entity.Property(e => e.DocPreparedbyName).HasMaxLength(100);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(100);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PicPersonName).HasMaxLength(100);
            entity.Property(e => e.PrintSq).HasColumnName("PrintSQ");
            entity.Property(e => e.Sqnumber)
                .HasMaxLength(20)
                .HasColumnName("SQnumber");
        });

        modelBuilder.Entity<CoveringLetterDocsMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CoveringLetterDocsMaster");

            entity.Property(e => e.Cargotype)
                .HasMaxLength(20)
                .HasColumnName("cargotype");
            entity.Property(e => e.DocumetId).ValueGeneratedOnAdd();
            entity.Property(e => e.DocumetName).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<CurrencyMaster>(entity =>
        {
            entity.HasKey(e => e.CurrencyId);

            entity.ToTable("CurrencyMaster");

            entity.Property(e => e.CurrencyId)
                .ValueGeneratedNever()
                .HasColumnName("CurrencyID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CurrencyName).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<CustomReport>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ReportId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ReportID");
            entity.Property(e => e.ReportName).HasMaxLength(100);
            entity.Property(e => e.ReportQuery).HasMaxLength(1000);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CUSTOMERS$");

            entity.Property(e => e.AccountOwner)
                .HasMaxLength(255)
                .HasColumnName("ACCOUNT OWNER");
            entity.Property(e => e.AccountOwnerId).HasColumnName("AccountOwnerID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .HasColumnName("COMPANY NAME");
            entity.Property(e => e.CompanyType)
                .HasMaxLength(255)
                .HasColumnName("COMPANY TYPE");
            entity.Property(e => e.Companystatus)
                .HasMaxLength(255)
                .HasColumnName("COMPANYSTATUS");
            entity.Property(e => e.Companytypeid).HasColumnName("COMPANYTYPEID");
            entity.Property(e => e.Office)
                .HasMaxLength(255)
                .HasColumnName("OFFICE");
            entity.Property(e => e.Officeid).HasColumnName("OFFICEID");
        });

        modelBuilder.Entity<CustomerAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CustomerAddresses");

            entity.Property(e => e.AddressTypeNick).HasMaxLength(30);
            entity.Property(e => e.CompanyAddressId).HasColumnName("CompanyAddressID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.FormattedAddress).HasMaxLength(500);
        });

        modelBuilder.Entity<DemoList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DemoList");

            entity.Property(e => e.Jobs)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DocumentFileType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DocumentFtplink).HasColumnName("DocumentFTPLink");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
        });

        modelBuilder.Entity<DocumentMaster>(entity =>
        {
            entity.HasKey(e => e.DocumentId);

            entity.ToTable("DocumentMaster");

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.DocumentName).HasMaxLength(200);
            entity.Property(e => e.DocumentType).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsVisibleToCustomer).HasColumnName("isVisibleToCustomer");
            entity.Property(e => e.ShipmentType).HasMaxLength(50);
        });

        modelBuilder.Entity<EmailHistory>(entity =>
        {
            entity.ToTable("EmailHistory");

            entity.Property(e => e.EmailHistoryId).HasColumnName("EmailHistoryID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.EmailBcc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EmailBCC");
            entity.Property(e => e.EmailBodyHtml).HasColumnName("EmailBodyHTML");
            entity.Property(e => e.EmailCc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("EmailCC");
            entity.Property(e => e.EmailFrom)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmailReference).HasMaxLength(100);
            entity.Property(e => e.EmailReferenceId).HasColumnName("EmailReferenceID");
            entity.Property(e => e.EmailSubject).HasMaxLength(500);
            entity.Property(e => e.EmailTo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmailType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsHtml).HasColumnName("isHTML");
            entity.Property(e => e.IsSent).HasColumnName("isSent");
            entity.Property(e => e.SendResponse).HasMaxLength(1000);
            entity.Property(e => e.SentDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmailResponse>(entity =>
        {
            entity.HasKey(e => e.ResponseId);

            entity.ToTable("EmailResponse");

            entity.Property(e => e.ResponseId)
                .ValueGeneratedNever()
                .HasColumnName("ResponseID");
            entity.Property(e => e.AttemptDate).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.EmailId).HasColumnName("EmailID");
            entity.Property(e => e.EmailResponse1).HasColumnName("EmailResponse");
            entity.Property(e => e.ResponseType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SourceType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Enquiry>(entity =>
        {
            entity.ToTable("Enquiry");

            entity.Property(e => e.EnquiryId).HasColumnName("EnquiryID");
            entity.Property(e => e.Commodity).HasMaxLength(50);
            entity.Property(e => e.CommodityId).HasColumnName("CommodityID");
            entity.Property(e => e.ContainerTypeId).HasColumnName("ContainerTypeID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.EnquiryDate).HasColumnType("datetime");
            entity.Property(e => e.EnquirySource)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EnquiryStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EnquirySubject).HasMaxLength(100);
            entity.Property(e => e.PackageTypeId).HasColumnName("PackageTypeID");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Podid).HasColumnName("PODID");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Polid).HasColumnName("POLID");
            entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");
            entity.Property(e => e.TotalCbm)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TotalCBM");
            entity.Property(e => e.TotalGrossWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WeightUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EntityTypeMaster>(entity =>
        {
            entity.HasKey(e => e.EntityTypeId);

            entity.ToTable("EntityTypeMaster");

            entity.Property(e => e.EntityTypeId)
                .ValueGeneratedNever()
                .HasColumnName("EntityTypeID");
            entity.Property(e => e.EntityTypeName).HasMaxLength(20);
            entity.Property(e => e.IsAir).HasColumnName("isAir");
            entity.Property(e => e.IsCompulsary).HasColumnName("isCompulsary");
            entity.Property(e => e.IsOcean).HasColumnName("isOcean");
            entity.Property(e => e.IsSurface).HasColumnName("isSurface");
        });

        modelBuilder.Entity<ExchangeRate>(entity =>
        {
            entity.Property(e => e.ExchangeRateId).HasColumnName("ExchangeRateID");
            entity.Property(e => e.BaseCurrencyId).HasColumnName("BaseCurrencyID");
            entity.Property(e => e.ConvertedCurrencyId).HasColumnName("ConvertedCurrencyID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.ExchangeBuyingRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExchangeBuyingRateInverse).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExchangeDateFrom).HasColumnType("datetime");
            entity.Property(e => e.ExchangeDateTo).HasColumnType("datetime");
            entity.Property(e => e.ExchangeSellingInverse).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExchangeSellingRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
        });

        modelBuilder.Entity<FinancialYearMaster>(entity =>
        {
            entity.HasKey(e => e.FinancialYearId);

            entity.ToTable("FinancialYearMaster");

            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FinancialYearName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<FormMaster>(entity =>
        {
            entity.HasKey(e => e.FormId);

            entity.ToTable("FormMaster");

            entity.Property(e => e.FormId)
                .ValueGeneratedNever()
                .HasColumnName("FormID");
            entity.Property(e => e.AllowApproval).HasColumnName("allowApproval");
            entity.Property(e => e.FormGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FormName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FundRequiremnt>(entity =>
        {
            entity.HasKey(e => e.Frid).HasName("PK__FundRequ__9D11117FEC2DDA70");

            entity.ToTable("FundRequiremnt");

            entity.Property(e => e.Frid).HasColumnName("FRID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AmtEur)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AmtEUR");
            entity.Property(e => e.AmtInr)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AmtINR");
            entity.Property(e => e.AmtSgd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AmtSGD");
            entity.Property(e => e.AmtUsd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AmtUSD");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CollectFromId).HasColumnName("CollectFromID");
            entity.Property(e => e.CollectFromName).HasMaxLength(200);
            entity.Property(e => e.CurrencyCode).HasMaxLength(10);
            entity.Property(e => e.CurrentStatus).HasMaxLength(50);
            entity.Property(e => e.CurrentStatusDate).HasMaxLength(50);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Datedeleted).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasColumnName("deletedBy");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.Jobtype)
                .HasMaxLength(50)
                .HasColumnName("jobtype");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.Podid).HasColumnName("PODID");
            entity.Property(e => e.Polid).HasColumnName("POLID");
            entity.Property(e => e.Remarks).HasMaxLength(100);
            entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            entity.Property(e => e.VendorId).HasColumnName("VendorID");
            entity.Property(e => e.VendorName).HasMaxLength(200);
            entity.Property(e => e.VendorType).HasMaxLength(50);
        });

        modelBuilder.Entity<GstTypeMaster>(entity =>
        {
            entity.HasKey(e => e.GsttypeId);

            entity.ToTable("GstTypeMaster");

            entity.Property(e => e.GsttypeId)
                .ValueGeneratedNever()
                .HasColumnName("GSTTypeID");
            entity.Property(e => e.GssttypeDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GSSTTypeDescription");
            entity.Property(e => e.GstregType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GSTRegType");
            entity.Property(e => e.QbGsttype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("QbGSTType");
            entity.Property(e => e.ZohoGsttype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ZohoGSTType");
        });

        modelBuilder.Entity<ImportCustomersaddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORT_CUSTOMERSADDRESS");

            entity.Property(e => e.AccountOwner)
                .HasMaxLength(255)
                .HasColumnName("ACCOUNT OWNER");
            entity.Property(e => e.BillingAddress)
                .HasMaxLength(255)
                .HasColumnName("Billing Address");
            entity.Property(e => e.BillingCity)
                .HasMaxLength(255)
                .HasColumnName("Billing City");
            entity.Property(e => e.BillingCountry)
                .HasMaxLength(255)
                .HasColumnName("Billing Country");
            entity.Property(e => e.BillingState)
                .HasMaxLength(255)
                .HasColumnName("Billing State");
            entity.Property(e => e.BillingZipcode)
                .HasMaxLength(255)
                .HasColumnName("Billing Zipcode");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .HasColumnName("COMPANY NAME");
            entity.Property(e => e.CompanyType)
                .HasMaxLength(255)
                .HasColumnName("COMPANY TYPE");
            entity.Property(e => e.Companystatus)
                .HasMaxLength(255)
                .HasColumnName("COMPANYSTATUS");
            entity.Property(e => e.Office)
                .HasMaxLength(255)
                .HasColumnName("OFFICE");
            entity.Property(e => e.PrimaryContact)
                .HasMaxLength(255)
                .HasColumnName("Primary Contact");
            entity.Property(e => e.PrimaryPhone)
                .HasMaxLength(255)
                .HasColumnName("Primary Phone");
            entity.Property(e => e.ShippingAddress)
                .HasMaxLength(255)
                .HasColumnName("Shipping Address");
            entity.Property(e => e.ShippingCity)
                .HasMaxLength(255)
                .HasColumnName("Shipping City");
            entity.Property(e => e.ShippingCountry)
                .HasMaxLength(255)
                .HasColumnName("Shipping Country");
            entity.Property(e => e.ShippingState)
                .HasMaxLength(255)
                .HasColumnName("Shipping State");
            entity.Property(e => e.ShippingZip)
                .HasMaxLength(255)
                .HasColumnName("Shipping Zip");
        });

        modelBuilder.Entity<IncoTerrmMaster>(entity =>
        {
            entity.HasKey(e => e.IncoTermId);

            entity.ToTable("IncoTerrmMaster");

            entity.Property(e => e.IncoTermId)
                .ValueGeneratedNever()
                .HasColumnName("IncoTermID");
            entity.Property(e => e.IncotermName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<IndustryMaster>(entity =>
        {
            entity.HasKey(e => e.IndustryId);

            entity.ToTable("IndustryMaster");

            entity.Property(e => e.IndustryId).HasColumnName("IndustryID");
            entity.Property(e => e.IndustryName).HasMaxLength(30);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ParentIndustryId).HasColumnName("ParentIndustryID");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasIndex(e => e.CargoId, "IDX_NONCLS_INVOICE_CARGOID");

            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CostSheetId).HasColumnName("CostSheetID");
            entity.Property(e => e.CreditDays).HasMaxLength(20);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.Cycle)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateLocked).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.EducationCess).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExchangeRateId).HasColumnName("ExchangeRateID");
            entity.Property(e => e.FinalDestination).HasMaxLength(50);
            entity.Property(e => e.FlightDetails).HasMaxLength(50);
            entity.Property(e => e.FreightStatus).HasMaxLength(20);
            entity.Property(e => e.HblHawb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL_HAWB");
            entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceAmountLocalCurrency).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceAmountWords).HasMaxLength(200);
            entity.Property(e => e.InvoiceApprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceTypeGst)
                .HasMaxLength(100)
                .HasColumnName("invoiceTypeGst");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isDeleted");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.IsSentToParty).HasColumnName("isSentToParty");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LocalCurrencyId).HasColumnName("LocalCurrencyID");
            entity.Property(e => e.MblMawb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL_MAWB");
            entity.Property(e => e.NonTaxableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Notes1).HasMaxLength(200);
            entity.Property(e => e.PayingParty).HasMaxLength(100);
            entity.Property(e => e.PayingPartyAddress).HasMaxLength(300);
            entity.Property(e => e.PayingPartyAddressId).HasColumnName("PayingPartyAddressID");
            entity.Property(e => e.PayingPartyId).HasColumnName("PayingPartyID");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shecess)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SHECess");
            entity.Property(e => e.ShipperInvoiceDetails).HasMaxLength(50);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxAmountLocalCurrency).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VesselVoyage).HasMaxLength(50);
        });

        modelBuilder.Entity<InvoiceEsync>(entity =>
        {
            entity.HasKey(e => e.SyncId).HasName("PK__InvoiceE__7E50DEA61E88BA6B");

            entity.ToTable("InvoiceESync");

            entity.Property(e => e.SyncId).HasColumnName("SyncID");
            entity.Property(e => e.AckDt).HasColumnType("datetime");
            entity.Property(e => e.AckNo).HasMaxLength(50);
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(30);
            entity.Property(e => e.IrnNo).HasMaxLength(100);
            entity.Property(e => e.SignedQrcode).HasColumnName("SignedQRCode");
            entity.Property(e => e.SyncDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<InvoiceLineItem>(entity =>
        {
            entity.HasIndex(e => e.InvoiceId, "idx_noncls_ILI_Invoiceid_Chargeitemid_taxableamount_isdeleted");

            entity.Property(e => e.InvoiceLineItemId).HasColumnName("InvoiceLineItemID");
            entity.Property(e => e.ApplyPer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.ChargeId).HasColumnName("ChargeID");
            entity.Property(e => e.ChargeItemId).HasColumnName("ChargeItemID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.ExRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExRateId).HasColumnName("ExRateID");
            entity.Property(e => e.ExpectedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.NonTaxableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RealizedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ServiceCode).HasMaxLength(100);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxAmountLocalCurrency).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.TaxableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmountLocalCurrency).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ChargeItem).WithMany(p => p.InvoiceLineItems)
                .HasForeignKey(d => d.ChargeItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceLineItems_ChargeItemMaster");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceLineItems)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceLineItems_Invoices");
        });

        modelBuilder.Entity<InvoiceListNewAge>(entity =>
        {
            entity.HasKey(e => e.InvoiceLineId).HasName("PK__InvoiceL__0D760AF9F4708EF9");

            entity.ToTable("InvoiceList_NewAge");

            entity.Property(e => e.InvoiceLineId).HasColumnName("InvoiceLineID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FilePath)
                .HasMaxLength(2000)
                .HasColumnName("filePath");
            entity.Property(e => e.ForeignAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.JobNumber).HasMaxLength(50);
            entity.Property(e => e.Memo).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PaymentReceivedOn).HasColumnType("datetime");
            entity.Property(e => e.TransactionType).HasMaxLength(50);
        });

        modelBuilder.Entity<JobTypeMaster>(entity =>
        {
            entity.HasKey(e => e.JobtypeId);

            entity.ToTable("JobTypeMaster");

            entity.Property(e => e.JobtypeId).HasColumnName("JOBTypeID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.JobtypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JOBTypeName");
        });

        modelBuilder.Entity<JobVendorDetail>(entity =>
        {
            entity.HasKey(e => e.JobVendorDetailId).HasName("PK__JobVendo__A566967629E9E56F");

            entity.Property(e => e.JobVendorDetailId).HasColumnName("JobVendorDetailID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.VendorBillAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VendorBillAmountText).HasMaxLength(100);
            entity.Property(e => e.VendorBillDate).HasColumnType("datetime");
            entity.Property(e => e.VendorBillNumber).HasMaxLength(50);
            entity.Property(e => e.VendorId).HasColumnName("VendorID");
            entity.Property(e => e.VendorName).HasMaxLength(200);
        });

        modelBuilder.Entity<Lcljob>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LCLJOBS");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Cbm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CBM");
            entity.Property(e => e.JobNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Lclrecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lclrecords");

            entity.Property(e => e.Column0)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 0");
            entity.Property(e => e.Column1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 1");
            entity.Property(e => e.Column2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 2");
        });

        modelBuilder.Entity<Lead>(entity =>
        {
            entity.Property(e => e.LeadId).HasColumnName("LeadID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CityName).HasMaxLength(30);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EnquiryReceivedOn).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(30);
            entity.Property(e => e.Followup1).HasColumnType("datetime");
            entity.Property(e => e.Followup2).HasColumnType("datetime");
            entity.Property(e => e.Followup3).HasColumnType("datetime");
            entity.Property(e => e.IndustryId).HasColumnName("IndustryID");
            entity.Property(e => e.IsCallingAllowed).HasColumnName("isCallingAllowed");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.LastName).HasMaxLength(30);
            entity.Property(e => e.LeadOwnerId).HasColumnName("LeadOwnerID");
            entity.Property(e => e.LeadSourceId).HasColumnName("LeadSourceID");
            entity.Property(e => e.LeadStatusId).HasColumnName("LeadStatusID");
            entity.Property(e => e.Meeting1).HasColumnType("datetime");
            entity.Property(e => e.Meeting2).HasColumnType("datetime");
            entity.Property(e => e.Meeting3).HasColumnType("datetime");
            entity.Property(e => e.MiddleName).HasMaxLength(30);
            entity.Property(e => e.Notes).HasMaxLength(200);
            entity.Property(e => e.Phone1)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Phone2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProfileSentOn).HasColumnType("datetime");
            entity.Property(e => e.QuoteSentOn).HasColumnType("datetime");
            entity.Property(e => e.ResonNotSecured).HasMaxLength(500);
            entity.Property(e => e.RevQuoteSentOn).HasColumnType("datetime");
            entity.Property(e => e.Salutation)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sector).HasMaxLength(500);
            entity.Property(e => e.ShipmentType).HasMaxLength(100);
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.Street).HasMaxLength(200);
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ZipCode)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Country).WithMany(p => p.Leads)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Leads_CountryMaster");

            entity.HasOne(d => d.Industry).WithMany(p => p.Leads)
                .HasForeignKey(d => d.IndustryId)
                .HasConstraintName("FK_Leads_IndustryMaster");

            entity.HasOne(d => d.LeadOwner).WithMany(p => p.Leads)
                .HasForeignKey(d => d.LeadOwnerId)
                .HasConstraintName("FK_Leads_UserMaster");

            entity.HasOne(d => d.LeadSource).WithMany(p => p.Leads)
                .HasForeignKey(d => d.LeadSourceId)
                .HasConstraintName("FK_Leads_MarketingSourceMaster");

            entity.HasOne(d => d.LeadStatus).WithMany(p => p.Leads)
                .HasForeignKey(d => d.LeadStatusId)
                .HasConstraintName("FK_Leads_MarketingStageMaster");
        });

        modelBuilder.Entity<LeadCampaign>(entity =>
        {
            entity.HasKey(e => e.CampaignId);

            entity.ToTable("LeadCampaign");

            entity.Property(e => e.CampaignId)
                .ValueGeneratedNever()
                .HasColumnName("CampaignID");
            entity.Property(e => e.LeadId).HasColumnName("LeadID");

            entity.HasOne(d => d.Campaign).WithOne(p => p.LeadCampaign)
                .HasForeignKey<LeadCampaign>(d => d.CampaignId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeadCampaign_LeadCampaign");

            entity.HasOne(d => d.Lead).WithMany(p => p.LeadCampaigns)
                .HasForeignKey(d => d.LeadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeadCampaign_Leads");
        });

        modelBuilder.Entity<LeadDocument>(entity =>
        {
            entity.HasKey(e => e.DocumentId);

            entity.Property(e => e.DocumentId)
                .ValueGeneratedNever()
                .HasColumnName("DocumentID");
            entity.Property(e => e.LeadId).HasColumnName("LeadID");

            entity.HasOne(d => d.Document).WithOne(p => p.LeadDocument)
                .HasForeignKey<LeadDocument>(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeadDocuments_LeadDocuments");

            entity.HasOne(d => d.Lead).WithMany(p => p.LeadDocuments)
                .HasForeignKey(d => d.LeadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeadDocuments_Leads");
        });

        modelBuilder.Entity<LeadTask>(entity =>
        {
            entity.HasKey(e => e.TaskId);

            entity.Property(e => e.TaskId)
                .ValueGeneratedNever()
                .HasColumnName("TaskID");
            entity.Property(e => e.LeadId).HasColumnName("LeadID");

            entity.HasOne(d => d.Lead).WithMany(p => p.LeadTasks)
                .HasForeignKey(d => d.LeadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeadTasks_Leads");

            entity.HasOne(d => d.Task).WithOne(p => p.LeadTask)
                .HasForeignKey<LeadTask>(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeadTasks_LeadTasks");
        });

        modelBuilder.Entity<LocalCharge>(entity =>
        {
            entity.Property(e => e.LocalChargeId).HasColumnName("LocalChargeID");
            entity.Property(e => e.ApplyPer).HasMaxLength(100);
            entity.Property(e => e.CarrierId).HasColumnName("carrierID");
            entity.Property(e => e.CarrierName)
                .HasMaxLength(200)
                .HasColumnName("carrierName");
            entity.Property(e => e.ChargeItemId).HasColumnName("chargeItemID");
            entity.Property(e => e.ContainerType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.LocalChargeName).HasMaxLength(200);
            entity.Property(e => e.Minimum).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Podid).HasColumnName("PODID");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Polid).HasColumnName("POLID");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RATE");
            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.TaxName).HasMaxLength(50);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            entity.Property(e => e.TerminalName).HasMaxLength(200);
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LocationMaster>(entity =>
        {
            entity.HasKey(e => e.LocationId);

            entity.ToTable("LocationMaster");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CountryName).HasMaxLength(50);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LocationLongName).HasMaxLength(100);
            entity.Property(e => e.LocationShortName).HasMaxLength(50);
            entity.Property(e => e.LocationType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ScheduleD).HasMaxLength(10);
            entity.Property(e => e.ScheduleK).HasMaxLength(10);
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.StateName).HasMaxLength(50);
        });

        modelBuilder.Entity<MarketingSourceMaster>(entity =>
        {
            entity.HasKey(e => e.MarketingSourceId);

            entity.ToTable("MarketingSourceMaster");

            entity.Property(e => e.MarketingSourceId).HasColumnName("MarketingSourceID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.MarketingSourceName).HasMaxLength(30);
        });

        modelBuilder.Entity<MarketingStageMaster>(entity =>
        {
            entity.HasKey(e => e.MarketingStageId);

            entity.ToTable("MarketingStageMaster");

            entity.Property(e => e.MarketingStageId)
                .ValueGeneratedNever()
                .HasColumnName("MarketingStageID");
            entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.MarketingStageName).HasMaxLength(30);
        });

        modelBuilder.Entity<MoveType>(entity =>
        {
            entity.HasKey(e => e.TypeOfMoveId);

            entity.Property(e => e.TypeOfMoveId).HasColumnName("TypeOfMoveID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDelivery).HasColumnName("isDelivery");
            entity.Property(e => e.IsPickup).HasColumnName("isPickup");
            entity.Property(e => e.TypeOfMove)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NewageInvoiceFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("newage_invoice_files");

            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FilesName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Files Name");
            entity.Property(e => e.FretrackFilesName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Fretrack Files Name");
            entity.Property(e => e.InvoiceAmount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Invoiceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("invoiceid");
            entity.Property(e => e.Invtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INVTYPE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Memo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PayingParty)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentReceivedOn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POD");
        });

        modelBuilder.Entity<NewageWeeklyReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NEWAGE_W__3214EC27D09642F7");

            entity.ToTable("NEWAGE_WEEKLY_REPORT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BookingIssueDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOOKING_ISSUE_DATE");
            entity.Property(e => e.BookingNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOOKING_NO");
            entity.Property(e => e.Container)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTAINER ");
            entity.Property(e => e.DeliveryDtMtyReturn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DELIVERY DT   MTY return ");
            entity.Property(e => e.EtaSavannah)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ETA_SAVANNAH");
            entity.Property(e => e.Etd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ETD");
            entity.Property(e => e.EtdSavannah)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ETD_SAVANNAH");
            entity.Property(e => e.GateOutFromTerminal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GATE_OUT_FROM_TERMINAL");
            entity.Property(e => e.HblNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HBL_NO");
            entity.Property(e => e.Jobno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JOBNO");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POD");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName(" Remark");
            entity.Property(e => e.Shipper)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIPPER ");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VESSEL_NAME ");
        });

        modelBuilder.Entity<NewageWeeklyReportBackup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NEWAGE_W__3214EC27475B96B2");

            entity.ToTable("NEWAGE_WEEKLY_REPORT_backup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BookingIssueDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOOKING_ISSUE_DATE");
            entity.Property(e => e.BookingNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOOKING_NO");
            entity.Property(e => e.Container)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTAINER ");
            entity.Property(e => e.DeliveryDtMtyReturn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DELIVERY DT   MTY return ");
            entity.Property(e => e.EtaSavannah)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ETA_SAVANNAH");
            entity.Property(e => e.Etd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ETD");
            entity.Property(e => e.EtdSavannah)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ETD_SAVANNAH");
            entity.Property(e => e.GateOutFromTerminal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GATE_OUT_FROM_TERMINAL");
            entity.Property(e => e.HblNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HBL_NO");
            entity.Property(e => e.Jobno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JOBNO");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POD");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName(" Remark");
            entity.Property(e => e.Shipper)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIPPER ");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VESSEL_NAME ");
        });

        modelBuilder.Entity<OceanLineMaster>(entity =>
        {
            entity.HasKey(e => e.OceanLineId);

            entity.ToTable("OceanLineMaster");

            entity.Property(e => e.OceanLineId).HasColumnName("OceanLineID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.LineCallSign).HasMaxLength(30);
            entity.Property(e => e.LineCompanyName).HasMaxLength(50);
            entity.Property(e => e.OceanLineCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Scaccode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SCACCode");
        });

        modelBuilder.Entity<OceanSchedule>(entity =>
        {
            entity.Property(e => e.OceanScheduleId).HasColumnName("OceanScheduleID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateDocumentCutoff).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DatePortCutoff).HasColumnType("datetime");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.Frequency)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.OceanLineId).HasColumnName("OceanLineID");
            entity.Property(e => e.Podid).HasColumnName("PODID");
            entity.Property(e => e.Polid).HasColumnName("POLID");
            entity.Property(e => e.VesselId).HasColumnName("VesselID");
            entity.Property(e => e.Voyage)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OceanShipmentRouting>(entity =>
        {
            entity.HasKey(e => e.OceanRoutingId);

            entity.ToTable("OceanShipmentRouting");

            entity.HasIndex(e => new { e.ShipmentId, e.CarrierAgent, e.OceanCarrierName, e.VesselName }, "_dta_index_OceanShipmentRouting_7_1876201734__K2_K47_K17_K20");

            entity.Property(e => e.OceanRoutingId).HasColumnName("OceanRoutingID");
            entity.Property(e => e.ArrivalNoticeTo).HasMaxLength(100);
            entity.Property(e => e.Ata)
                .HasColumnType("datetime")
                .HasColumnName("ATA");
            entity.Property(e => e.Atd)
                .HasColumnType("datetime")
                .HasColumnName("ATD");
            entity.Property(e => e.BlinstructionCutoff)
                .HasColumnType("datetime")
                .HasColumnName("BLInstructionCutoff");
            entity.Property(e => e.BookingBlcost)
                .HasMaxLength(50)
                .HasColumnName("BookingBLCost");
            entity.Property(e => e.BookingCommodity).HasMaxLength(100);
            entity.Property(e => e.BookingContainerCount).HasMaxLength(100);
            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.BookingLcno)
                .HasMaxLength(100)
                .HasColumnName("BookingLCNo");
            entity.Property(e => e.BookingLoadingPlace).HasMaxLength(100);
            entity.Property(e => e.BookingNumber).HasMaxLength(30);
            entity.Property(e => e.BookingOceanFreight).HasMaxLength(50);
            entity.Property(e => e.BookingOrderNo).HasMaxLength(100);
            entity.Property(e => e.BookingPayableAt).HasMaxLength(100);
            entity.Property(e => e.BookingPortCharges).HasMaxLength(50);
            entity.Property(e => e.BookingTo).HasMaxLength(100);
            entity.Property(e => e.BookingTrucking).HasMaxLength(100);
            entity.Property(e => e.BookingTruckingCost).HasMaxLength(50);
            entity.Property(e => e.BookingWarehousePickupDate).HasColumnType("datetime");
            entity.Property(e => e.BuiltYear)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CarrierAgent).HasMaxLength(200);
            entity.Property(e => e.CarrierAgentId).HasColumnName("CarrierAgentID");
            entity.Property(e => e.ContainerAgentId).HasColumnName("ContainerAgentID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DocumentCutoffDate).HasColumnType("datetime");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.GatesClosingDate).HasColumnType("datetime");
            entity.Property(e => e.Imonumber)
                .HasMaxLength(20)
                .HasColumnName("IMONumber");
            entity.Property(e => e.InttrarefNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INTTRARefNo");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isDeleted");
            entity.Property(e => e.IsPot1).HasColumnName("isPOT1");
            entity.Property(e => e.IsPot2).HasColumnName("isPOT2");
            entity.Property(e => e.LegNumber).HasDefaultValueSql("((1))");
            entity.Property(e => e.LlyodsCode).HasMaxLength(20);
            entity.Property(e => e.LoadingDate).HasColumnType("datetime");
            entity.Property(e => e.LoadingTerminalId).HasColumnName("LoadingTerminalID");
            entity.Property(e => e.LoadingTerminalName).HasMaxLength(50);
            entity.Property(e => e.OceanCarrierId).HasColumnName("OceanCarrierID");
            entity.Property(e => e.OceanCarrierName).HasMaxLength(30);
            entity.Property(e => e.PlaceOfFinalDestination).HasMaxLength(200);
            entity.Property(e => e.PlaceOfLoading).HasMaxLength(200);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Podid).HasColumnName("PODID");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Polid).HasColumnName("POLID");
            entity.Property(e => e.Pot1)
                .HasMaxLength(50)
                .HasColumnName("POT1");
            entity.Property(e => e.Pot1id).HasColumnName("POT1ID");
            entity.Property(e => e.Pot2)
                .HasMaxLength(50)
                .HasColumnName("POT2");
            entity.Property(e => e.Pot2id).HasColumnName("POT2ID");
            entity.Property(e => e.ShipmentId).HasColumnName("ShipmentID");
            entity.Property(e => e.Transhipment1Eta)
                .HasColumnType("datetime")
                .HasColumnName("Transhipment1ETA");
            entity.Property(e => e.Transhipment1Etd)
                .HasColumnType("datetime")
                .HasColumnName("Transhipment1ETD");
            entity.Property(e => e.Transhipment1Vessel).HasMaxLength(100);
            entity.Property(e => e.Transhipment2Eta)
                .HasColumnType("datetime")
                .HasColumnName("Transhipment2ETA");
            entity.Property(e => e.Transhipment2Etd)
                .HasColumnType("datetime")
                .HasColumnName("Transhipment2ETD");
            entity.Property(e => e.Transhipment2Vessel).HasMaxLength(100);
            entity.Property(e => e.UnloadingTerminalId).HasColumnName("UnloadingTerminalID");
            entity.Property(e => e.UnloadingTerminalName).HasMaxLength(50);
            entity.Property(e => e.VesselFlagId).HasColumnName("VesselFlagID");
            entity.Property(e => e.VesselFlagName).HasMaxLength(30);
            entity.Property(e => e.VesselId).HasColumnName("VesselID");
            entity.Property(e => e.VesselName).HasMaxLength(50);
            entity.Property(e => e.VoyageNumber).HasMaxLength(10);
        });

        modelBuilder.Entity<Opportunity>(entity =>
        {
            entity.HasIndex(e => new { e.IsDeleted, e.OpportunityId, e.AccountName }, "_dta_index_Opportunities_7_571149080__K23_K1_K4");

            entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");
            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ApprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AssociatedLeadId).HasColumnName("AssociatedLeadID");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DateClose).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.LeadSourceId).HasColumnName("LeadSourceID");
            entity.Property(e => e.NextStep).HasMaxLength(50);
            entity.Property(e => e.OpportunityName).HasMaxLength(50);
            entity.Property(e => e.OpportunityOwnerId).HasColumnName("OpportunityOwnerID");
            entity.Property(e => e.OpportunityStageId).HasColumnName("OpportunityStageID");
            entity.Property(e => e.OpportunityType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PrimaryCampaignId).HasColumnName("PrimaryCampaignID");

            entity.HasOne(d => d.Account).WithMany(p => p.Opportunities)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("FK_Opportunities_Companies");

            entity.HasOne(d => d.Currency).WithMany(p => p.Opportunities)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("FK_Opportunities_CurrencyMaster");

            entity.HasOne(d => d.OpportunityOwner).WithMany(p => p.Opportunities)
                .HasForeignKey(d => d.OpportunityOwnerId)
                .HasConstraintName("FK_Opportunities_UserMaster");

            entity.HasOne(d => d.OpportunityStage).WithMany(p => p.Opportunities)
                .HasForeignKey(d => d.OpportunityStageId)
                .HasConstraintName("FK_Opportunities_MarketingStageMaster");
        });

        modelBuilder.Entity<OpportunityAttribute>(entity =>
        {
            entity.Property(e => e.OpportunityAttributeId).HasColumnName("OpportunityAttributeID");
            entity.Property(e => e.CargoType).HasMaxLength(30);
            entity.Property(e => e.EquipmentType).HasMaxLength(50);
            entity.Property(e => e.Mode).HasMaxLength(30);
            entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Podid).HasColumnName("PODID");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Polid).HasColumnName("POLID");
            entity.Property(e => e.RequiredEquipment).HasMaxLength(2000);
            entity.Property(e => e.TotalVolumeCbm)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("TotalVolumeCBM");
            entity.Property(e => e.TotalWeightKgs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalWeightKGS");

            entity.HasOne(d => d.Opportunity).WithMany(p => p.OpportunityAttributes)
                .HasForeignKey(d => d.OpportunityId)
                .HasConstraintName("FK_OpportunityAttributes_Opportunities");
        });

        modelBuilder.Entity<OpportunityCampaign>(entity =>
        {
            entity.HasKey(e => e.CampaignId);

            entity.ToTable("OpportunityCampaign");

            entity.Property(e => e.CampaignId)
                .ValueGeneratedNever()
                .HasColumnName("CampaignID");
            entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");

            entity.HasOne(d => d.Campaign).WithOne(p => p.OpportunityCampaign)
                .HasForeignKey<OpportunityCampaign>(d => d.CampaignId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OpportunityCampaign_Campaigns");

            entity.HasOne(d => d.Opportunity).WithMany(p => p.OpportunityCampaigns)
                .HasForeignKey(d => d.OpportunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OpportunityCampaign_Opportunities");
        });

        modelBuilder.Entity<OpportunityDocument>(entity =>
        {
            entity.HasKey(e => e.DocumentId);

            entity.Property(e => e.DocumentId)
                .ValueGeneratedNever()
                .HasColumnName("DocumentID");
            entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");

            entity.HasOne(d => d.Document).WithOne(p => p.OpportunityDocument)
                .HasForeignKey<OpportunityDocument>(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OpportunityDocuments_Documents");

            entity.HasOne(d => d.Opportunity).WithMany(p => p.OpportunityDocuments)
                .HasForeignKey(d => d.OpportunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OpportunityDocuments_Opportunities");
        });

        modelBuilder.Entity<OpportunityTask>(entity =>
        {
            entity.HasKey(e => e.TaskId);

            entity.Property(e => e.TaskId)
                .ValueGeneratedNever()
                .HasColumnName("TaskID");
            entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");

            entity.HasOne(d => d.Opportunity).WithMany(p => p.OpportunityTasks)
                .HasForeignKey(d => d.OpportunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OpportunityTasks_Opportunities");

            entity.HasOne(d => d.Task).WithOne(p => p.OpportunityTask)
                .HasForeignKey<OpportunityTask>(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OpportunityTasks_Tasks");
        });

        modelBuilder.Entity<OtherCompanyType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'OTHER COMPANY TYPES$'");

            entity.Property(e => e.AccountOwner).HasColumnName("ACCOUNT OWNER");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .HasColumnName("COMPANY NAME");
            entity.Property(e => e.CompanyStatus)
                .HasMaxLength(255)
                .HasColumnName("COMPANY STATUS");
            entity.Property(e => e.CompanyType)
                .HasMaxLength(255)
                .HasColumnName("COMPANY TYPE");
            entity.Property(e => e.Companytypeid)
                .HasMaxLength(255)
                .HasColumnName("COMPANYTYPEID");
            entity.Property(e => e.Office)
                .HasMaxLength(255)
                .HasColumnName("OFFICE");
            entity.Property(e => e.Officeid).HasColumnName("OFFICEID");
        });

        modelBuilder.Entity<PackageGroup>(entity =>
        {
            entity.Property(e => e.PackageGroupId).HasColumnName("PackageGroupID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.PackageGroupName).HasMaxLength(50);
        });

        modelBuilder.Entity<PackageType>(entity =>
        {
            entity.Property(e => e.PackageTypeId).HasColumnName("PackageTypeID");
            entity.Property(e => e.ContainerIsocode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ContainerISOCode");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DefaultHeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultLength).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultWidth).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DimensionsUnitId).HasColumnName("DimensionsUnitID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsAir).HasColumnName("isAir");
            entity.Property(e => e.IsContainer).HasColumnName("isContainer");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsOcean).HasColumnName("isOcean");
            entity.Property(e => e.IsSurface).HasColumnName("isSurface");
            entity.Property(e => e.MaxWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PackageCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PackageGroupId).HasColumnName("PackageGroupID");
            entity.Property(e => e.PackageTypeName).HasMaxLength(50);
            entity.Property(e => e.PackageTypeShortName).HasMaxLength(20);
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WeightUnitId).HasColumnName("WeightUnitID");

            entity.HasOne(d => d.PackageGroup).WithMany(p => p.PackageTypes)
                .HasForeignKey(d => d.PackageGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PackageTypes_PackageGroups");
        });

        modelBuilder.Entity<PaymentTerm>(entity =>
        {
            entity.Property(e => e.PaymentTermId).HasColumnName("PaymentTermID");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.PaymentTerm1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PaymentTerm");
        });

        modelBuilder.Entity<ProfileMaster>(entity =>
        {
            entity.HasKey(e => e.ProfileId);

            entity.ToTable("ProfileMaster");

            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.AssociatedDesignation).HasMaxLength(30);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.ProfileName).HasMaxLength(30);
        });

        modelBuilder.Entity<ProfileRight>(entity =>
        {
            entity.Property(e => e.ProfileRightId).HasColumnName("ProfileRightID");
            entity.Property(e => e.AllowCreate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("allowCreate");
            entity.Property(e => e.AllowDelete)
                .HasDefaultValueSql("((0))")
                .HasColumnName("allowDelete");
            entity.Property(e => e.AllowModify)
                .HasDefaultValueSql("((0))")
                .HasColumnName("allowModify");
            entity.Property(e => e.AllowRead)
                .HasDefaultValueSql("((0))")
                .HasColumnName("allowRead");
            entity.Property(e => e.AllowView)
                .HasDefaultValueSql("((0))")
                .HasColumnName("allowView");
            entity.Property(e => e.ApprovalLevel).HasDefaultValueSql("((0))");
            entity.Property(e => e.ApprovalReq).HasDefaultValueSql("((0))");
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.IsApprover)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isApprover");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

            entity.HasOne(d => d.Form).WithMany(p => p.ProfileRights)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfileRights_FormMaster");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileRights)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfileRights_ProfileMaster");
        });

        modelBuilder.Entity<QbChargeItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbChargeItems");

            entity.Property(e => e.ChargeItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ChargeItemID");
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FullyQualifiedName).HasMaxLength(255);
            entity.Property(e => e.Id).HasMaxLength(255);
            entity.Property(e => e.IncomeAccountRefName).HasMaxLength(255);
            entity.Property(e => e.IncomeAccountRefValue).HasMaxLength(255);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.MetaDataCreateTime).HasMaxLength(255);
            entity.Property(e => e.MetaDataLastUpdatedTime).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.TaxClass).HasMaxLength(255);
            entity.Property(e => e.TaxClassificationRefName).HasMaxLength(255);
        });

        modelBuilder.Entity<QbChargeMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbChargeMappings");

            entity.Property(e => e.CargoType).HasMaxLength(255);
            entity.Property(e => e.ChargeDescription).HasMaxLength(2000);
            entity.Property(e => e.ChargeGroupName).HasMaxLength(255);
            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName).HasMaxLength(255);
            entity.Property(e => e.ChargeMappingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ChargeMappingID");
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.QbChargeId)
                .HasMaxLength(255)
                .HasColumnName("qbChargeID");
            entity.Property(e => e.QbChargeName)
                .HasMaxLength(255)
                .HasColumnName("qbChargeName");
            entity.Property(e => e.TaxCode).HasMaxLength(255);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<QbCurrencyRef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbCurrencyRef");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Qbcompid).HasColumnName("qbcompid");
            entity.Property(e => e.Value)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("value");
        });

        modelBuilder.Entity<QbCustomerMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbCustomerMapping");

            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.CustomerFullName).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FretrackId).HasColumnName("FretrackID");
            entity.Property(e => e.FretrackName).HasMaxLength(255);
            entity.Property(e => e.Gstin)
                .HasMaxLength(255)
                .HasColumnName("GSTIN");
            entity.Property(e => e.GstregistrationType)
                .HasMaxLength(255)
                .HasColumnName("GSTRegistrationType");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Qbcity)
                .HasMaxLength(255)
                .HasColumnName("QBCity");
            entity.Property(e => e.Qbcountry)
                .HasMaxLength(255)
                .HasColumnName("QBCountry");
            entity.Property(e => e.Qbid)
                .HasMaxLength(255)
                .HasColumnName("QBID");
            entity.Property(e => e.Qbname)
                .HasMaxLength(255)
                .HasColumnName("QBName");
            entity.Property(e => e.Qbpincode)
                .HasMaxLength(255)
                .HasColumnName("QBPINcode");
            entity.Property(e => e.Qbstate)
                .HasMaxLength(255)
                .HasColumnName("QBState");
            entity.Property(e => e.QbstreetAddress)
                .HasMaxLength(255)
                .HasColumnName("QBStreetAddress");
        });

        modelBuilder.Entity<QbCustomerMapping1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbCustomerMappings");

            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.CustomerFullName).HasMaxLength(255);
            entity.Property(e => e.CustomerMappingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CustomerMappingID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FretrackId).HasColumnName("FretrackID");
            entity.Property(e => e.FretrackName).HasMaxLength(255);
            entity.Property(e => e.Gstin)
                .HasMaxLength(255)
                .HasColumnName("GSTIN");
            entity.Property(e => e.GstregistrationType)
                .HasMaxLength(255)
                .HasColumnName("GSTRegistrationType");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Qbcity)
                .HasMaxLength(255)
                .HasColumnName("QBCity");
            entity.Property(e => e.Qbcountry)
                .HasMaxLength(255)
                .HasColumnName("QBCountry");
            entity.Property(e => e.Qbid)
                .HasMaxLength(255)
                .HasColumnName("QBID");
            entity.Property(e => e.Qbname)
                .HasMaxLength(255)
                .HasColumnName("QBName");
            entity.Property(e => e.Qbpincode)
                .HasMaxLength(255)
                .HasColumnName("QBPINcode");
            entity.Property(e => e.Qbstate)
                .HasMaxLength(255)
                .HasColumnName("QBState");
            entity.Property(e => e.QbstreetAddress)
                .HasMaxLength(255)
                .HasColumnName("QBStreetAddress");
        });

        modelBuilder.Entity<QbCustomerMappingMum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbCustomerMapping_Mum");

            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.CustomerFullName).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FretrackId).HasColumnName("FretrackID");
            entity.Property(e => e.FretrackName).HasMaxLength(255);
            entity.Property(e => e.Gstin)
                .HasMaxLength(255)
                .HasColumnName("GSTIN");
            entity.Property(e => e.GstregistrationType)
                .HasMaxLength(255)
                .HasColumnName("GSTRegistrationType");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Qbcity)
                .HasMaxLength(255)
                .HasColumnName("QBCity");
            entity.Property(e => e.Qbcountry)
                .HasMaxLength(255)
                .HasColumnName("QBCountry");
            entity.Property(e => e.Qbid).HasColumnName("QBID");
            entity.Property(e => e.Qbname)
                .HasMaxLength(255)
                .HasColumnName("QBName");
            entity.Property(e => e.Qbpincode)
                .HasMaxLength(255)
                .HasColumnName("QBPINcode");
            entity.Property(e => e.Qbstate)
                .HasMaxLength(255)
                .HasColumnName("QBState");
            entity.Property(e => e.QbstreetAddress)
                .HasMaxLength(255)
                .HasColumnName("QBStreetAddress");
        });

        modelBuilder.Entity<QbDepartmentRef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbDepartmentRef");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Qbcompid).HasColumnName("qbcompid");
            entity.Property(e => e.Value)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("value");
        });

        modelBuilder.Entity<QbExpenseItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbExpenseItems");

            entity.Property(e => e.AccountSubType).HasMaxLength(255);
            entity.Property(e => e.AccountType).HasMaxLength(255);
            entity.Property(e => e.Active).HasMaxLength(255);
            entity.Property(e => e.ChargeItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ChargeItemID");
            entity.Property(e => e.Classification).HasMaxLength(255);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FullyQualifiedName).HasMaxLength(255);
            entity.Property(e => e.Id).HasMaxLength(255);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.MetaDataCreateTime).HasMaxLength(255);
            entity.Property(e => e.MetaDataLastUpdatedTime).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ParentRefValue).HasMaxLength(255);
            entity.Property(e => e.TaxCodeRefValue).HasMaxLength(255);
        });

        modelBuilder.Entity<QbExpenseMapping>(entity =>
        {
            entity.HasKey(e => e.ChargeMappingId);

            entity.ToTable("qbExpenseMappings");

            entity.Property(e => e.ChargeMappingId).HasColumnName("ChargeMappingID");
            entity.Property(e => e.CargoType).HasMaxLength(255);
            entity.Property(e => e.ChargeDescription).HasMaxLength(2000);
            entity.Property(e => e.ChargeGroupName).HasMaxLength(255);
            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName).HasMaxLength(255);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.QbChargeId)
                .HasMaxLength(255)
                .HasColumnName("qbChargeID");
            entity.Property(e => e.QbChargeName)
                .HasMaxLength(255)
                .HasColumnName("qbChargeName");
            entity.Property(e => e.TaxCode).HasMaxLength(255);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<QbItemsChennai>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbItemsChennai");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FullyQualifiedName).HasMaxLength(255);
            entity.Property(e => e.Id).HasMaxLength(255);
            entity.Property(e => e.IncomeAccountRefName).HasMaxLength(255);
            entity.Property(e => e.IncomeAccountRefValue).HasMaxLength(255);
            entity.Property(e => e.MetaDataCreateTime)
                .HasMaxLength(255)
                .HasColumnName("MetaData/CreateTime");
            entity.Property(e => e.MetaDataLastUpdatedTime)
                .HasMaxLength(255)
                .HasColumnName("MetaData/LastUpdatedTime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.TaxClass).HasMaxLength(255);
            entity.Property(e => e.TaxClassificationRefName)
                .HasMaxLength(255)
                .HasColumnName("TaxClassificationRef/name");
        });

        modelBuilder.Entity<QbItemsMumbai>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbItemsMumbai");

            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FullyQualifiedName).HasMaxLength(255);
            entity.Property(e => e.Id).HasMaxLength(255);
            entity.Property(e => e.IncomeAccountRefName).HasMaxLength(255);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.MetaDataCreateTime).HasMaxLength(255);
            entity.Property(e => e.MetaDataLastUpdatedTime).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.TaxClassificationRefName).HasMaxLength(255);
        });

        modelBuilder.Entity<QbPaymentTermsRef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbPaymentTermsRef");

            entity.Property(e => e.Id).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Qbcompid).HasColumnName("qbcompid");
        });

        modelBuilder.Entity<QbStateMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbStateMaster");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.QbstateCode)
                .HasMaxLength(255)
                .HasColumnName("QBStateCode");
            entity.Property(e => e.QbstateName)
                .HasMaxLength(255)
                .HasColumnName("QBStateName");
            entity.Property(e => e.StateCode).HasMaxLength(255);
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.StateName).HasMaxLength(255);
        });

        modelBuilder.Entity<QbSyncHistory>(entity =>
        {
            entity.HasKey(e => e.SyncId);

            entity.ToTable("qbSyncHistory");

            entity.Property(e => e.FretrackInvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FretrackJobNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.QbinvoiceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("QBInvoiceId");
            entity.Property(e => e.SyncByName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SyncDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SyncStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SyncType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QbTaxMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbTaxMapping");

            entity.Property(e => e.ComponentId).HasColumnName("ComponentID");
            entity.Property(e => e.FretrackOfficeId).HasColumnName("FretrackOfficeID");
            entity.Property(e => e.InvoiceTypeGst)
                .HasMaxLength(255)
                .HasColumnName("invoiceTypeGST");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Percentage).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.QbcompanyId)
                .HasMaxLength(255)
                .HasColumnName("QBCompanyID");
            entity.Property(e => e.QbtaxCodeDescription)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeDescription");
            entity.Property(e => e.QbtaxCodeId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeID");
            entity.Property(e => e.QbtaxCodeName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeName");
            entity.Property(e => e.QbtaxRateId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateID");
            entity.Property(e => e.QbtaxRateName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateName");
            entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TotalPercentage).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<QbTaxMapping1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbTaxMappings");

            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.ComponentId).HasColumnName("ComponentID");
            entity.Property(e => e.FretrackOfficeId).HasColumnName("FretrackOfficeID");
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceTypeGst)
                .HasMaxLength(255)
                .HasColumnName("invoiceTypeGST");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Percentage).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.QbcompanyId)
                .HasMaxLength(255)
                .HasColumnName("QBCompanyID");
            entity.Property(e => e.QbtaxCodeDescription)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeDescription");
            entity.Property(e => e.QbtaxCodeId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeID");
            entity.Property(e => e.QbtaxCodeName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeName");
            entity.Property(e => e.QbtaxRateId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateID");
            entity.Property(e => e.QbtaxRateName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateName");
            entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");
            entity.Property(e => e.TaxMappingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TaxMappingID");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TotalPercentage).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<QbTaxMappingMum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbTaxMapping_Mum");

            entity.Property(e => e.ComponentId).HasColumnName("ComponentID");
            entity.Property(e => e.FretrackOfficeId).HasColumnName("FretrackOfficeID");
            entity.Property(e => e.InvoiceTypeGst)
                .HasMaxLength(255)
                .HasColumnName("invoiceTypeGST");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Percentage).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.QbcompanyId)
                .HasMaxLength(255)
                .HasColumnName("QBCompanyID");
            entity.Property(e => e.QbtaxCodeDescription)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeDescription");
            entity.Property(e => e.QbtaxCodeId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeID");
            entity.Property(e => e.QbtaxCodeName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeName");
            entity.Property(e => e.QbtaxRateId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateID");
            entity.Property(e => e.QbtaxRateName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateName");
            entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TotalPercentage).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<QbTaxMappingOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbTaxMappingOld");

            entity.Property(e => e.ComponentId).HasColumnName("ComponentID");
            entity.Property(e => e.FretrackOfficeId).HasColumnName("FretrackOfficeID");
            entity.Property(e => e.FretrackPercentage).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.InvoiceTypeGst)
                .HasMaxLength(255)
                .HasColumnName("invoiceTypeGST");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.QbcompanyId)
                .HasMaxLength(60)
                .HasColumnName("QBCompanyID");
            entity.Property(e => e.QbtaxCodeDescription)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeDescription");
            entity.Property(e => e.QbtaxCodeId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeID");
            entity.Property(e => e.QbtaxCodeName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeName");
            entity.Property(e => e.QbtaxRateId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateID");
            entity.Property(e => e.QbtaxRateName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateName");
            entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<QbVendorMapping>(entity =>
        {
            entity.HasKey(e => e.VendorMappingId);

            entity.ToTable("qbVendorMappings");

            entity.Property(e => e.VendorMappingId).HasColumnName("VendorMappingID");
            entity.Property(e => e.BillingAddressId)
                .HasMaxLength(255)
                .HasColumnName("BillingAddressID");
            entity.Property(e => e.BusinessNumber).HasMaxLength(255);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.DefaultTds)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DefaultTDS");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FretrackId).HasColumnName("FretrackID");
            entity.Property(e => e.FretrackName).HasMaxLength(255);
            entity.Property(e => e.Gstin)
                .HasMaxLength(255)
                .HasColumnName("GSTIN");
            entity.Property(e => e.GstregistrationType)
                .HasMaxLength(255)
                .HasColumnName("GSTRegistrationType");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("LOCATION");
            entity.Property(e => e.PaymentTermId)
                .HasMaxLength(255)
                .HasColumnName("PaymentTermID");
            entity.Property(e => e.PrintOnCheckName).HasMaxLength(255);
            entity.Property(e => e.Qbcity)
                .HasMaxLength(255)
                .HasColumnName("QBCity");
            entity.Property(e => e.Qbcountry)
                .HasMaxLength(255)
                .HasColumnName("QBCountry");
            entity.Property(e => e.Qbid)
                .HasMaxLength(255)
                .HasColumnName("QBID");
            entity.Property(e => e.Qbname)
                .HasMaxLength(255)
                .HasColumnName("QBName");
            entity.Property(e => e.Qbpincode)
                .HasMaxLength(255)
                .HasColumnName("QBPINcode");
            entity.Property(e => e.Qbstate)
                .HasMaxLength(255)
                .HasColumnName("QBState");
            entity.Property(e => e.QbstreetAddress)
                .HasMaxLength(255)
                .HasColumnName("QBStreetAddress");
            entity.Property(e => e.TaxIdentifier).HasMaxLength(255);
            entity.Property(e => e.VendorFullName).HasMaxLength(255);
        });

        modelBuilder.Entity<QbVendorMappingsTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbVendorMappings_TEMP");

            entity.Property(e => e.BillingAddressId)
                .HasMaxLength(255)
                .HasColumnName("BillingAddressID");
            entity.Property(e => e.BusinessNumber).HasMaxLength(255);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FretrackId).HasColumnName("FretrackID");
            entity.Property(e => e.FretrackName).HasMaxLength(255);
            entity.Property(e => e.Gstin)
                .HasMaxLength(255)
                .HasColumnName("GSTIN");
            entity.Property(e => e.GstregistrationType)
                .HasMaxLength(255)
                .HasColumnName("GSTRegistrationType");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("LOCATION");
            entity.Property(e => e.PaymentTermId)
                .HasMaxLength(255)
                .HasColumnName("PaymentTermID");
            entity.Property(e => e.PrintOnCheckName).HasMaxLength(255);
            entity.Property(e => e.Qbcity)
                .HasMaxLength(255)
                .HasColumnName("QBCity");
            entity.Property(e => e.Qbcountry)
                .HasMaxLength(255)
                .HasColumnName("QBCountry");
            entity.Property(e => e.Qbid)
                .HasMaxLength(255)
                .HasColumnName("QBID");
            entity.Property(e => e.Qbname)
                .HasMaxLength(255)
                .HasColumnName("QBName");
            entity.Property(e => e.Qbpincode)
                .HasMaxLength(255)
                .HasColumnName("QBPINcode");
            entity.Property(e => e.Qbstate)
                .HasMaxLength(255)
                .HasColumnName("QBState");
            entity.Property(e => e.QbstreetAddress)
                .HasMaxLength(255)
                .HasColumnName("QBStreetAddress");
            entity.Property(e => e.TaxIdentifier).HasMaxLength(255);
            entity.Property(e => e.VendorFullName).HasMaxLength(255);
            entity.Property(e => e.VendorMappingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("VendorMappingID");
        });

        modelBuilder.Entity<QbfChargeMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbfChargeMapping");

            entity.Property(e => e.ChargeDescription).HasMaxLength(2000);
            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName).HasMaxLength(255);
            entity.Property(e => e.QbchennaiId)
                .HasMaxLength(255)
                .HasColumnName("QBChennaiID");
            entity.Property(e => e.QbchennaiName)
                .HasMaxLength(255)
                .HasColumnName("QBChennaiName");
            entity.Property(e => e.TaxCode).HasMaxLength(255);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<QbfChargeMappingOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qbfChargeMappingOld");

            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName).HasMaxLength(255);
            entity.Property(e => e.QbchennaiId)
                .HasMaxLength(255)
                .HasColumnName("QBChennaiID");
            entity.Property(e => e.QbchennaiName)
                .HasMaxLength(255)
                .HasColumnName("QBChennaiName");
            entity.Property(e => e.TaxCode).HasMaxLength(255);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<R1ChargeGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("r1_ChargeGroup");

            entity.Property(e => e.Cdesc)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CDESC");
            entity.Property(e => e.Group)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GROUP");
            entity.Property(e => e.Incexp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INCEXP");
            entity.Property(e => e.Mode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODE");
        });

        modelBuilder.Entity<R2ChargeGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("r2_ChargeGroup");

            entity.Property(e => e.Cdesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CDESC");
            entity.Property(e => e.Group)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GROUP");
            entity.Property(e => e.Incexp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INCEXP");
            entity.Property(e => e.Mode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODE");
        });

        modelBuilder.Entity<R3ChargeGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("r3_ChargeGroup");

            entity.Property(e => e.Cdesc)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CDESC");
            entity.Property(e => e.Group)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GROUP");
            entity.Property(e => e.Incexp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INCEXP");
            entity.Property(e => e.Mode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODE");
        });

        modelBuilder.Entity<R5ChargeGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("r5_ChargeGroup");

            entity.Property(e => e.Cdesc)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CDESC");
            entity.Property(e => e.Group)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GROUP");
            entity.Property(e => e.Incexp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INCEXP");
            entity.Property(e => e.Mode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODE");
        });

        modelBuilder.Entity<RChargeGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("r_ChargeGroup");

            entity.Property(e => e.Cdesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CDESC");
            entity.Property(e => e.Group)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GROUP");
            entity.Property(e => e.Incexp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INCEXP");
            entity.Property(e => e.Mode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODE");
        });

        modelBuilder.Entity<ReportAcc1920>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("report_acc_1920");

            entity.Property(e => e.JobNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JobNumber ");
        });

        modelBuilder.Entity<ReportAcc2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("report_acc_2021");

            entity.Property(e => e.JobNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReportAcc202223V3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("report_acc_202223 v3");

            entity.Property(e => e.JobNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReportAcc2122>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("report_acc_2122");

            entity.Property(e => e.JobNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReportAcc2223>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("report_acc_2223");

            entity.Property(e => e.JobNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReportUser>(entity =>
        {
            entity.HasKey(e => e.ReportAccessId);

            entity.ToTable("ReportUser");

            entity.Property(e => e.ReportAccessId).HasColumnName("ReportAccessID");
            entity.Property(e => e.ReportId).HasColumnName("ReportID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Resource>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.Image).HasColumnType("image");
            entity.Property(e => e.ResourceId).HasColumnName("ResourceID");
            entity.Property(e => e.ResourceName).HasMaxLength(50);
        });

        modelBuilder.Entity<SaleQuoteDetailNewdisplayView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SaleQuoteDetailNewdisplayView");

            entity.Property(e => e.Carrier).HasMaxLength(200);
            entity.Property(e => e.CarrierId).HasColumnName("CarrierID");
            entity.Property(e => e.FreeTime).HasMaxLength(100);
            entity.Property(e => e.IncoTerm).HasMaxLength(150);
            entity.Property(e => e.LocationShortName).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.OceanLineCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PlaceOfDelivery).HasMaxLength(200);
            entity.Property(e => e.PlaceOfDeliveryId).HasColumnName("PlaceOfDeliveryID");
            entity.Property(e => e.PlaceOfOrigin).HasMaxLength(200);
            entity.Property(e => e.PlaceOfOriginId).HasColumnName("PlaceOfOriginID");
            entity.Property(e => e.Pod)
                .HasMaxLength(200)
                .HasColumnName("POD");
            entity.Property(e => e.Podid).HasColumnName("PODID");
            entity.Property(e => e.Pol)
                .HasMaxLength(200)
                .HasColumnName("POL");
            entity.Property(e => e.Polid).HasColumnName("POLID");
            entity.Property(e => e.Polname)
                .HasMaxLength(50)
                .HasColumnName("polname");
            entity.Property(e => e.Pot1)
                .HasMaxLength(200)
                .HasColumnName("POT1");
            entity.Property(e => e.Pot1id).HasColumnName("POT1ID");
            entity.Property(e => e.SalesQuoteDetailId).HasColumnName("SalesQuoteDetailID");
            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            entity.Property(e => e.TransitTime).HasMaxLength(100);
            entity.Property(e => e.TypeOfMove).HasMaxLength(50);
            entity.Property(e => e.VesselId).HasColumnName("VesselID");
            entity.Property(e => e.VesselName).HasMaxLength(200);
        });

        modelBuilder.Entity<SalesCostCategory>(entity =>
        {
            entity.HasKey(e => e.CostCategoryId).HasName("PK__SalesCos__ADD6906ABB6B46BE");

            entity.ToTable("SalesCostCategory");

            entity.Property(e => e.CostCategoryId).HasColumnName("CostCategoryID");
            entity.Property(e => e.BuyExRateEur)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BuyExRateEUR");
            entity.Property(e => e.BuyExRateInr)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BuyExRateINR");
            entity.Property(e => e.BuyExRateTl)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BuyExRateTL");
            entity.Property(e => e.BuyExRateUsd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BuyExRateUSD");
            entity.Property(e => e.CostCategoryStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CostCategoryType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRateDate).HasColumnType("datetime");
            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            entity.Property(e => e.SellExRateEur)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SellExRateEUR");
            entity.Property(e => e.SellExRateInr)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SellExRateINR");
            entity.Property(e => e.SellExRateTl)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SellExRateTL");
            entity.Property(e => e.SellExRateUsd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SellExRateUSD");
            entity.Property(e => e.VerifiedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<SalesQuote>(entity =>
        {
            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.Carrier).HasMaxLength(200);
            entity.Property(e => e.CarrierAgent).HasMaxLength(200);
            entity.Property(e => e.CarrierAgentId).HasColumnName("CarrierAgentID");
            entity.Property(e => e.CarrierId).HasColumnName("CarrierID");
            entity.Property(e => e.ChargeableWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Commodity).HasMaxLength(1000);
            entity.Property(e => e.CommodityValue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommodityValueCurrency).HasMaxLength(30);
            entity.Property(e => e.CommodityValueCurrencyId).HasColumnName("CommodityValueCurrencyID");
            entity.Property(e => e.CompanyDisplayName).HasMaxLength(250);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContactDisplayName).HasMaxLength(150);
            entity.Property(e => e.ContactEmail).HasMaxLength(1000);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactTelephone).HasMaxLength(100);
            entity.Property(e => e.ContractNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddress).HasMaxLength(1000);
            entity.Property(e => e.DeliveryAddressCity).HasMaxLength(150);
            entity.Property(e => e.DeliveryAddressCountry).HasMaxLength(150);
            entity.Property(e => e.DeliveryAddressId).HasColumnName("DeliveryAddressID");
            entity.Property(e => e.DeliveryAddressState).HasMaxLength(150);
            entity.Property(e => e.DeliveryAddressStreet).HasMaxLength(300);
            entity.Property(e => e.DeliveryAddressZip).HasMaxLength(20);
            entity.Property(e => e.EmailCc)
                .HasMaxLength(1000)
                .HasColumnName("EmailCC");
            entity.Property(e => e.EmailTo).HasMaxLength(1000);
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnName("FileID");
            entity.Property(e => e.Frequency).HasMaxLength(50);
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IncoTerm).HasMaxLength(150);
            entity.Property(e => e.IncoTermId).HasColumnName("IncoTermID");
            entity.Property(e => e.InternalNotes).HasMaxLength(1000);
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IsContract).HasColumnName("isContract");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsDraft).HasColumnName("isDraft");
            entity.Property(e => e.IsHazardous).HasColumnName("isHazardous");
            entity.Property(e => e.IsRejected).HasColumnName("isRejected");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OldSalesQuoteId).HasColumnName("OldSalesQuoteID");
            entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");
            entity.Property(e => e.PickupAddress).HasMaxLength(1000);
            entity.Property(e => e.PickupAddressCity).HasMaxLength(150);
            entity.Property(e => e.PickupAddressCountry).HasMaxLength(150);
            entity.Property(e => e.PickupAddressId).HasColumnName("PickupAddressID");
            entity.Property(e => e.PickupAddressState).HasMaxLength(150);
            entity.Property(e => e.PickupAddressStreet).HasMaxLength(300);
            entity.Property(e => e.PickupAddressZip).HasMaxLength(20);
            entity.Property(e => e.PlaceOfDelivery).HasMaxLength(200);
            entity.Property(e => e.PlaceOfDeliveryId).HasColumnName("PlaceOfDeliveryID");
            entity.Property(e => e.PlaceOfOrigin).HasMaxLength(200);
            entity.Property(e => e.PlaceOfOriginId).HasColumnName("PlaceOfOriginID");
            entity.Property(e => e.Pod)
                .HasMaxLength(200)
                .HasColumnName("POD");
            entity.Property(e => e.Podid).HasColumnName("PODID");
            entity.Property(e => e.Pol)
                .HasMaxLength(200)
                .HasColumnName("POL");
            entity.Property(e => e.Polid).HasColumnName("POLID");
            entity.Property(e => e.Pot1)
                .HasMaxLength(200)
                .HasColumnName("POT1");
            entity.Property(e => e.Pot1id).HasColumnName("POT1ID");
            entity.Property(e => e.Pot2)
                .HasMaxLength(200)
                .HasColumnName("POT2");
            entity.Property(e => e.Pot2id).HasColumnName("POT2ID");
            entity.Property(e => e.Pot3)
                .HasMaxLength(200)
                .HasColumnName("POT3");
            entity.Property(e => e.Pot3id).HasColumnName("POT3ID");
            entity.Property(e => e.PreparedByDislayName).HasMaxLength(150);
            entity.Property(e => e.RejectedDate).HasColumnType("datetime");
            entity.Property(e => e.RequiredEquipment).HasMaxLength(1000);
            entity.Property(e => e.RevisionId).HasColumnName("RevisionID");
            entity.Property(e => e.SalesPersonDisplayName).HasMaxLength(150);
            entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            entity.Property(e => e.SalesQuoteBaseCurrency)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SalesQuoteBaseCurrencyId).HasColumnName("SalesQuoteBaseCurrencyID");
            entity.Property(e => e.SalesQuoteCurrency)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SalesQuoteCurrencyId).HasColumnName("SalesQuoteCurrencyID");
            entity.Property(e => e.SalesQuoteDate).HasColumnType("date");
            entity.Property(e => e.SalesQuoteExRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SalesQuoteExRateInverse).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SalesQuoteNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SalesQuoteType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ShowAllIn).HasColumnName("showAllIn");
            entity.Property(e => e.ShowLiner).HasColumnName("showLiner");
            entity.Property(e => e.TypeOfMove).HasMaxLength(50);
            entity.Property(e => e.TypeOfMoveId).HasColumnName("TypeOfMoveID");
            entity.Property(e => e.Volume).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolumeWeight).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<SalesQuoteAdditionalDetail>(entity =>
        {
            entity.HasKey(e => e.SalesQuoteId);

            entity.Property(e => e.SalesQuoteId)
                .ValueGeneratedNever()
                .HasColumnName("SalesQuoteID");

            entity.HasOne(d => d.SalesQuote).WithOne(p => p.SalesQuoteAdditionalDetail)
                .HasForeignKey<SalesQuoteAdditionalDetail>(d => d.SalesQuoteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesQuoteAdditionalDetails_SalesQuotes");
        });

        modelBuilder.Entity<SalesQuoteCharge>(entity =>
        {
            entity.Property(e => e.SalesQuoteChargeId)
                .ValueGeneratedNever()
                .HasColumnName("SalesQuoteChargeID");
            entity.Property(e => e.ApplicableToCompanyId).HasColumnName("ApplicableToCompanyID");
            entity.Property(e => e.ChargeDescription)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ChargeGroupId).HasColumnName("ChargeGroupID");
            entity.Property(e => e.ChargeItemId).HasColumnName("ChargeItemID");
            entity.Property(e => e.ChargePer)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsExpense).HasColumnName("isExpense");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            entity.Property(e => e.SalesQuoteServiceId).HasColumnName("SalesQuoteServiceID");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");

            entity.HasOne(d => d.ChargeItem).WithMany(p => p.SalesQuoteCharges)
                .HasForeignKey(d => d.ChargeItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesQuoteCharges_ChargeItemMaster");

            entity.HasOne(d => d.SalesQuoteService).WithMany(p => p.SalesQuoteCharges)
                .HasForeignKey(d => d.SalesQuoteServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesQuoteCharges_SalesQuoteServices");
        });

        modelBuilder.Entity<SalesQuoteChargeItem>(entity =>
        {
            entity.HasKey(e => e.SalesQuoteChargeItemId).HasName("PK__SalesQuo__F228B23AF9B99895");

            entity.Property(e => e.SalesQuoteChargeItemId).HasColumnName("SalesQuoteChargeItemID");
            entity.Property(e => e.ApplyPer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ChargeDescription).HasMaxLength(150);
            entity.Property(e => e.ChargeItemId).HasColumnName("ChargeItemID");
            entity.Property(e => e.CostCategoryId).HasColumnName("CostCategoryID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.ExRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IncomeExpense)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.PayingPartyId).HasColumnName("PayingPartyID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SalesQuoteChargeId).HasColumnName("SalesQuoteChargeID");
            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalNonTaxableAmount).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<SalesQuoteChargesNew>(entity =>
        {
            entity.HasKey(e => e.SqchargeId).HasName("PK__SalesQuo__5B932A976CA51649");

            entity.ToTable("SalesQuoteCharges_New");

            entity.Property(e => e.SqchargeId).HasColumnName("SQChargeID");
            entity.Property(e => e.ApplyPer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.ChargeItemId).HasColumnName("ChargeItemID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.ExRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IncomeExpense)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.PayingPartyId).HasColumnName("PayingPartyID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SalesQuoteChargeId).HasColumnName("SalesQuoteChargeID");
            entity.Property(e => e.SqdetailRowId).HasColumnName("SQDetailRowID");
            entity.Property(e => e.Sqid).HasColumnName("SQID");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalNonTaxableAmount).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<SalesQuoteCommodity>(entity =>
        {
            entity.Property(e => e.SalesQuoteCommodityId)
                .ValueGeneratedNever()
                .HasColumnName("SalesQuoteCommodityID");
            entity.Property(e => e.CommodityDescription).HasMaxLength(100);
            entity.Property(e => e.CommodityId).HasColumnName("CommodityID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PackageTypeId).HasColumnName("PackageTypeID");
            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            entity.Property(e => e.SizeUnitId).HasColumnName("SizeUnitID");
            entity.Property(e => e.Volume).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.VolumeUnitId).HasColumnName("VolumeUnitID");
            entity.Property(e => e.WeightUnitId).HasColumnName("WeightUnitID");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.SalesQuote).WithMany(p => p.SalesQuoteCommodities)
                .HasForeignKey(d => d.SalesQuoteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesQuoteCommodities_SalesQuotes");
        });

        modelBuilder.Entity<SalesQuoteDetailsNew>(entity =>
        {
            entity.HasKey(e => e.SalesQuoteDetailId).HasName("PK__SalesQuo__FCC79280958DA478");

            entity.ToTable("SalesQuoteDetails_New");

            entity.Property(e => e.SalesQuoteDetailId).HasColumnName("SalesQuoteDetailID");
            entity.Property(e => e.Carrier).HasMaxLength(200);
            entity.Property(e => e.CarrierId).HasColumnName("CarrierID");
            entity.Property(e => e.FreeTime).HasMaxLength(100);
            entity.Property(e => e.IncoTerm).HasMaxLength(150);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.PlaceOfDelivery).HasMaxLength(200);
            entity.Property(e => e.PlaceOfDeliveryId).HasColumnName("PlaceOfDeliveryID");
            entity.Property(e => e.PlaceOfOrigin).HasMaxLength(200);
            entity.Property(e => e.PlaceOfOriginId).HasColumnName("PlaceOfOriginID");
            entity.Property(e => e.Pod)
                .HasMaxLength(200)
                .HasColumnName("POD");
            entity.Property(e => e.Podid).HasColumnName("PODID");
            entity.Property(e => e.Pol)
                .HasMaxLength(200)
                .HasColumnName("POL");
            entity.Property(e => e.Polid).HasColumnName("POLID");
            entity.Property(e => e.Pot1)
                .HasMaxLength(200)
                .HasColumnName("POT1");
            entity.Property(e => e.Pot1id).HasColumnName("POT1ID");
            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            entity.Property(e => e.TransitTime).HasMaxLength(100);
            entity.Property(e => e.TypeOfMove).HasMaxLength(50);
            entity.Property(e => e.VesselId).HasColumnName("VesselID");
            entity.Property(e => e.VesselName).HasMaxLength(200);
        });

        modelBuilder.Entity<SalesQuoteFile>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.EmailCc).HasColumnName("EmailCC");
            entity.Property(e => e.EmailSubject).HasMaxLength(300);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.RevisionId).HasColumnName("RevisionID");
            entity.Property(e => e.SalesQuoteFileId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SalesQuoteFileID");
            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
        });

        modelBuilder.Entity<SalesQuoteHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesQuoteHistory");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.RevisionId).HasColumnName("RevisionID");
            entity.Property(e => e.SalesQuoteHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SalesQuoteHistoryID");
            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            entity.Property(e => e.SalesQuoteStatus).HasMaxLength(200);
            entity.Property(e => e.TaskId).HasColumnName("TaskID");
        });

        modelBuilder.Entity<SalesQuoteNew>(entity =>
        {
            entity.HasKey(e => e.SalesQuoteId).HasName("PK__SalesQuo__6CB310C91BAB7E77");

            entity.ToTable("SalesQuote_New");

            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.ChargeableWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Commodity).HasMaxLength(1000);
            entity.Property(e => e.CommodityValue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommodityValueCurrency).HasMaxLength(30);
            entity.Property(e => e.CommodityValueCurrencyId).HasColumnName("CommodityValueCurrencyID");
            entity.Property(e => e.CompanyAddress).HasMaxLength(1000);
            entity.Property(e => e.CompanyAddressId).HasColumnName("CompanyAddressID");
            entity.Property(e => e.CompanyDisplayName).HasMaxLength(250);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContactDisplayName).HasMaxLength(150);
            entity.Property(e => e.ContactEmail).HasMaxLength(1000);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactTelephone).HasMaxLength(100);
            entity.Property(e => e.ContractNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddress).HasMaxLength(1000);
            entity.Property(e => e.DeliveryAddressId).HasColumnName("DeliveryAddressID");
            entity.Property(e => e.Direction).HasMaxLength(20);
            entity.Property(e => e.EmailCc)
                .HasMaxLength(1000)
                .HasColumnName("EmailCC");
            entity.Property(e => e.EmailTo).HasMaxLength(1000);
            entity.Property(e => e.EnqReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnName("FileID");
            entity.Property(e => e.FollowUp1).HasColumnType("datetime");
            entity.Property(e => e.FollowUp1Remarks).HasMaxLength(200);
            entity.Property(e => e.FollowUp2).HasColumnType("datetime");
            entity.Property(e => e.FollowUp2Remarks).HasMaxLength(200);
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IncoTermId).HasColumnName("IncoTermID");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IsContract).HasColumnName("isContract");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsDraft).HasColumnName("isDraft");
            entity.Property(e => e.IsHazardous).HasColumnName("isHazardous");
            entity.Property(e => e.IsRejected).HasColumnName("isRejected");
            entity.Property(e => e.Modeoftransport).HasMaxLength(20);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OldSalesQuoteId).HasColumnName("OldSalesQuoteID");
            entity.Property(e => e.PickupAddress).HasMaxLength(1000);
            entity.Property(e => e.PickupAddressId).HasColumnName("PickupAddressID");
            entity.Property(e => e.PreparedByDislayName).HasMaxLength(150);
            entity.Property(e => e.RejectedDate).HasColumnType("datetime");
            entity.Property(e => e.RequiredEquipment).HasMaxLength(1000);
            entity.Property(e => e.RevisionId).HasColumnName("RevisionID");
            entity.Property(e => e.SalesPersonDisplayName).HasMaxLength(150);
            entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            entity.Property(e => e.SalesQuoteCurrency)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SalesQuoteCurrencyId).HasColumnName("SalesQuoteCurrencyID");
            entity.Property(e => e.SalesQuoteDate).HasColumnType("date");
            entity.Property(e => e.SalesQuoteNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SalesQuoteStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SalesQuoteType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ShowCarrier).HasColumnName("showCarrier");
            entity.Property(e => e.ShowTax).HasColumnName("showTax");
            entity.Property(e => e.ShowTotal).HasColumnName("showTotal");
            entity.Property(e => e.TypeOfMoveId).HasColumnName("TypeOfMoveID");
            entity.Property(e => e.Volume).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolumeWeight).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<SalesQuoteService>(entity =>
        {
            entity.Property(e => e.SalesQuoteServiceId)
                .ValueGeneratedNever()
                .HasColumnName("SalesQuoteServiceID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DestinationLocationId).HasColumnName("DestinationLocationID");
            entity.Property(e => e.DestinationPoint).HasMaxLength(30);
            entity.Property(e => e.FrequencyId).HasColumnName("FrequencyID");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.OriginLocationId).HasColumnName("OriginLocationID");
            entity.Property(e => e.OriginPoint).HasMaxLength(30);
            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");

            entity.HasOne(d => d.SalesQuote).WithMany(p => p.SalesQuoteServices)
                .HasForeignKey(d => d.SalesQuoteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesQuoteServices_SalesQuotes");
        });

        modelBuilder.Entity<SalesQuoteTypeMaster>(entity =>
        {
            entity.HasKey(e => e.SalesQuoteTypeId);

            entity.ToTable("SalesQuoteTypeMaster");

            entity.Property(e => e.SalesQuoteTypeId)
                .ValueGeneratedNever()
                .HasColumnName("SalesQuoteTypeID");
            entity.Property(e => e.AssociatedShipmentTypeId).HasColumnName("AssociatedShipmentTypeID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.SalesQuoteType).HasMaxLength(30);
        });

        modelBuilder.Entity<SalesQuotesDetailView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesQuotesDetailView");

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.ChargeableWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Commodity).HasMaxLength(1000);
            entity.Property(e => e.CommodityValue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommodityValueCurrency).HasMaxLength(30);
            entity.Property(e => e.CommodityValueCurrencyId).HasColumnName("CommodityValueCurrencyID");
            entity.Property(e => e.CompanyAddress).HasMaxLength(1000);
            entity.Property(e => e.CompanyAddressId).HasColumnName("CompanyAddressID");
            entity.Property(e => e.CompanyDisplayName).HasMaxLength(250);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.ContactDisplayName).HasMaxLength(150);
            entity.Property(e => e.ContactEmail).HasMaxLength(1000);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactTelephone).HasMaxLength(100);
            entity.Property(e => e.ContractNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddress).HasMaxLength(1000);
            entity.Property(e => e.DeliveryAddressId).HasColumnName("DeliveryAddressID");
            entity.Property(e => e.Direction).HasMaxLength(20);
            entity.Property(e => e.DisplayName).HasMaxLength(120);
            entity.Property(e => e.EmailCc)
                .HasMaxLength(1000)
                .HasColumnName("EmailCC");
            entity.Property(e => e.EmailTo).HasMaxLength(1000);
            entity.Property(e => e.EnqReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnName("FileID");
            entity.Property(e => e.FollowUp1).HasColumnType("datetime");
            entity.Property(e => e.FollowUp1Remarks).HasMaxLength(200);
            entity.Property(e => e.FollowUp2).HasColumnType("datetime");
            entity.Property(e => e.FollowUp2Remarks).HasMaxLength(200);
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IncoTermId).HasColumnName("IncoTermID");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IsContract).HasColumnName("isContract");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsDraft).HasColumnName("isDraft");
            entity.Property(e => e.IsHazardous).HasColumnName("isHazardous");
            entity.Property(e => e.IsRejected).HasColumnName("isRejected");
            entity.Property(e => e.Modeoftransport).HasMaxLength(20);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OldSalesQuoteId).HasColumnName("OldSalesQuoteID");
            entity.Property(e => e.PickupAddress).HasMaxLength(1000);
            entity.Property(e => e.PickupAddressId).HasColumnName("PickupAddressID");
            entity.Property(e => e.PreparedByDislayName).HasMaxLength(150);
            entity.Property(e => e.RejectedDate).HasColumnType("datetime");
            entity.Property(e => e.RequiredEquipment).HasMaxLength(1000);
            entity.Property(e => e.RevisionId).HasColumnName("RevisionID");
            entity.Property(e => e.SalesPersonDisplayName).HasMaxLength(150);
            entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            entity.Property(e => e.SalesQuoteCurrency)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SalesQuoteCurrencyId).HasColumnName("SalesQuoteCurrencyID");
            entity.Property(e => e.SalesQuoteDate).HasColumnType("date");
            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            entity.Property(e => e.SalesQuoteNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SalesQuoteStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SalesQuoteType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ShowCarrier).HasColumnName("showCarrier");
            entity.Property(e => e.ShowTax).HasColumnName("showTax");
            entity.Property(e => e.ShowTotal).HasColumnName("showTotal");
            entity.Property(e => e.TypeOfMoveId).HasColumnName("TypeOfMoveID");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Volume).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolumeWeight).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<SerialNumberFormat>(entity =>
        {
            entity.HasKey(e => e.SerialFormatId);

            entity.Property(e => e.SerialFormatId).HasColumnName("SerialFormatID");
            entity.Property(e => e.CounterId).HasColumnName("CounterID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.NextReset).HasColumnType("datetime");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.ResetEvery)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SerialFormat)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SerialFormatDescription).HasMaxLength(50);

            entity.HasOne(d => d.Counter).WithMany(p => p.SerialNumberFormats)
                .HasForeignKey(d => d.CounterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SerialNumberFormats_CounterMaster");
        });

        modelBuilder.Entity<SubdivisionCode>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Sucode)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("SUCode");
            entity.Property(e => e.Sucountry)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("SUCountry");
            entity.Property(e => e.Suname)
                .HasMaxLength(150)
                .HasColumnName("SUName");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.Comments).HasMaxLength(200);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.Location).HasMaxLength(30);
            entity.Property(e => e.Priority)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(100);
            entity.Property(e => e.TaskStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaskTypeId).HasColumnName("TaskTypeID");
        });

        modelBuilder.Entity<TaskTypeMaster>(entity =>
        {
            entity.HasKey(e => e.TaskTypeId);

            entity.ToTable("TaskTypeMaster");

            entity.Property(e => e.TaskTypeId)
                .ValueGeneratedNever()
                .HasColumnName("TaskTypeID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.TaskTypeName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TaxComponent>(entity =>
        {
            entity.Property(e => e.TaxComponentId).HasColumnName("TaxComponentID");
            entity.Property(e => e.ComponentName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ComponentPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.InvoiceType).HasMaxLength(50);
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
        });

        modelBuilder.Entity<TaxManual>(entity =>
        {
            entity.HasKey(e => e.TaxManualId).HasName("PK__TaxManua__C70BEA85A7B38E65");

            entity.ToTable("TaxManual");

            entity.Property(e => e.TaxManualId).HasColumnName("TaxManualID");
            entity.Property(e => e.ChargeItemId).HasColumnName("ChargeItemID");
        });

        modelBuilder.Entity<TaxMaster>(entity =>
        {
            entity.HasKey(e => e.TaxId);

            entity.ToTable("TaxMaster");

            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.TaxCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TaxName).HasMaxLength(30);
        });

        modelBuilder.Entity<TaxRate>(entity =>
        {
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");
            entity.Property(e => e.EffectiveTaxPercentage).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TaxCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.TaxName).HasMaxLength(30);
        });

        modelBuilder.Entity<TempqbCustomersMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempqbCustomersMapping");

            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.CustomerFullName).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FretrackId).HasColumnName("FretrackID");
            entity.Property(e => e.FretrackName).HasMaxLength(255);
            entity.Property(e => e.Gstin)
                .HasMaxLength(255)
                .HasColumnName("GSTIN");
            entity.Property(e => e.GstregistrationType)
                .HasMaxLength(255)
                .HasColumnName("GSTRegistrationType");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Qbcity)
                .HasMaxLength(255)
                .HasColumnName("QBCity");
            entity.Property(e => e.Qbcountry)
                .HasMaxLength(255)
                .HasColumnName("QBCountry");
            entity.Property(e => e.Qbid)
                .HasMaxLength(255)
                .HasColumnName("QBID");
            entity.Property(e => e.Qbname)
                .HasMaxLength(255)
                .HasColumnName("QBName");
            entity.Property(e => e.Qbpincode)
                .HasMaxLength(255)
                .HasColumnName("QBPINcode");
            entity.Property(e => e.Qbstate)
                .HasMaxLength(255)
                .HasColumnName("QBState");
            entity.Property(e => e.QbstreetAddress)
                .HasMaxLength(255)
                .HasColumnName("QBStreetAddress");
        });

        modelBuilder.Entity<TerminalMaster>(entity =>
        {
            entity.HasKey(e => e.TerminalId);

            entity.ToTable("TerminalMaster");

            entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.TerminalName).HasMaxLength(50);
        });

        modelBuilder.Entity<TrackingAirCarrier>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AirCarrierId).HasColumnName("AirCarrierID");
            entity.Property(e => e.AirCarrierLink).HasMaxLength(1000);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.SearchType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrackingOceanCarrier>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.OceanCarrierId).HasColumnName("OceanCarrierID");
            entity.Property(e => e.SearchType).HasMaxLength(50);
        });

        modelBuilder.Entity<UniqueCustomer>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AirExport).HasColumnName("AIR-EXPORT");
            entity.Property(e => e.AirImport).HasColumnName("AIR-IMPORT");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Customer)
                .HasMaxLength(100)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.FirstShipmentDate)
                .HasColumnType("datetime")
                .HasColumnName("FIRST SHIPMENT DATE");
            entity.Property(e => e.LastShipmentDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST SHIPMENT DATE");
            entity.Property(e => e.OceanExport).HasColumnName("OCEAN-EXPORT");
            entity.Property(e => e.OceanImport).HasColumnName("OCEAN-IMPORT");
            entity.Property(e => e.ParentCompanyId).HasColumnName("ParentCompanyID");
            entity.Property(e => e.Salesperson)
                .HasMaxLength(100)
                .HasColumnName("SALESPERSON");
        });

        modelBuilder.Entity<UnitConversionSetting>(entity =>
        {
            entity.HasKey(e => e.UnitConversionId);

            entity.Property(e => e.UnitConversionId).HasColumnName("UnitConversionID");
            entity.Property(e => e.BaseUnitId).HasColumnName("BaseUnitID");
            entity.Property(e => e.ConversionFactor).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ConvertedUnitId).HasColumnName("ConvertedUnitID");
            entity.Property(e => e.InverseConversionFactor)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.BaseUnit).WithMany(p => p.UnitConversionSettingBaseUnits)
                .HasForeignKey(d => d.BaseUnitId)
                .HasConstraintName("FK_UnitConversionSettings_UnitMaster");

            entity.HasOne(d => d.ConvertedUnit).WithMany(p => p.UnitConversionSettingConvertedUnits)
                .HasForeignKey(d => d.ConvertedUnitId)
                .HasConstraintName("FK_UnitConversionSettings_UnitMaster1");
        });

        modelBuilder.Entity<UnitMaster>(entity =>
        {
            entity.HasKey(e => e.UnitId);

            entity.ToTable("UnitMaster");

            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.UnitDisplayLongName).HasMaxLength(30);
            entity.Property(e => e.UnitDisplayShortName).HasMaxLength(10);
            entity.Property(e => e.UnitName).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UnitTypeName).HasMaxLength(50);

            entity.HasOne(d => d.UnitType).WithMany(p => p.UnitMasters)
                .HasForeignKey(d => d.UnitTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnitMaster_UnitTypeMaster");
        });

        modelBuilder.Entity<UnitTypeMaster>(entity =>
        {
            entity.HasKey(e => e.UnitTypeId);

            entity.ToTable("UnitTypeMaster");

            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.UnitTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UploadedFile>(entity =>
        {
            entity.HasKey(e => e.FileId);

            entity.Property(e => e.FileId).HasColumnName("FileID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.FileLink).HasMaxLength(500);
            entity.Property(e => e.FileName).HasMaxLength(200);
            entity.Property(e => e.FileType).HasMaxLength(20);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(20)
                .HasColumnName("IPAddress");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.Pcname)
                .HasMaxLength(30)
                .HasColumnName("PCName");
            entity.Property(e => e.ProtocolUsed)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UsedAirline>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.A2code)
                .HasMaxLength(2)
                .HasColumnName("A2Code");
            entity.Property(e => e.A3code)
                .HasMaxLength(3)
                .HasColumnName("A3Code");
            entity.Property(e => e.AirlineId).HasColumnName("airlineID");
            entity.Property(e => e.AirlineName).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.N3code)
                .HasMaxLength(3)
                .HasColumnName("N3Code");
        });

        modelBuilder.Entity<UsedAirport>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AirportLongName).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(5);
            entity.Property(e => e.CountryName).HasMaxLength(150);
            entity.Property(e => e.Location).HasMaxLength(30);
            entity.Property(e => e.NameWoDiacritics).HasMaxLength(150);
            entity.Property(e => e.ScheduleD).HasMaxLength(5);
            entity.Property(e => e.ScheduleK).HasMaxLength(5);
            entity.Property(e => e.StateCode).HasMaxLength(50);
            entity.Property(e => e.StateName).HasMaxLength(150);
        });

        modelBuilder.Entity<UsedOceanLine>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LineCallSign)
                .HasMaxLength(250)
                .HasColumnName("lineCallSign");
            entity.Property(e => e.LineCompanyName)
                .HasMaxLength(500)
                .HasColumnName("lineCompanyName");
            entity.Property(e => e.LineCountry)
                .HasMaxLength(150)
                .HasColumnName("lineCountry");
            entity.Property(e => e.LineOwnerCountry)
                .HasMaxLength(150)
                .HasColumnName("lineOwnerCountry");
            entity.Property(e => e.LineOwnerName)
                .HasMaxLength(500)
                .HasColumnName("lineOwnerName");
            entity.Property(e => e.LinersId).HasColumnName("linersID");
            entity.Property(e => e.Scac)
                .HasMaxLength(100)
                .HasColumnName("SCAC");
        });

        modelBuilder.Entity<UsedOceanPort>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Country).HasMaxLength(5);
            entity.Property(e => e.CountryName).HasMaxLength(150);
            entity.Property(e => e.Location).HasMaxLength(30);
            entity.Property(e => e.NameWoDiacritics).HasMaxLength(150);
            entity.Property(e => e.OceanPortLongName).HasMaxLength(500);
            entity.Property(e => e.ScheduleD).HasMaxLength(5);
            entity.Property(e => e.ScheduleK).HasMaxLength(5);
            entity.Property(e => e.StateCode).HasMaxLength(50);
            entity.Property(e => e.StateName).HasMaxLength(150);
            entity.Property(e => e.Unececode)
                .HasMaxLength(12)
                .HasColumnName("UNECECode");
        });

        modelBuilder.Entity<UserMaster>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("UserMaster");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateLocked).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.PrimaryOfficeId).HasColumnName("PrimaryOfficeID");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.UserDisplayName).HasMaxLength(100);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword).HasMaxLength(500);

            entity.HasOne(d => d.Contact).WithMany(p => p.UserMasters)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_UserMaster_Contacts");

            entity.HasOne(d => d.PrimaryOffice).WithMany(p => p.UserMasters)
                .HasForeignKey(d => d.PrimaryOfficeId)
                .HasConstraintName("FK_UserMaster_Companies");

            entity.HasOne(d => d.Profile).WithMany(p => p.UserMasters)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("FK_UserMaster_ProfileMaster");
        });

        modelBuilder.Entity<UserOfficeAccess>(entity =>
        {
            entity.ToTable("UserOfficeAccess");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Office).WithMany(p => p.UserOfficeAccesses)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserOfficeAccess_Companies");

            entity.HasOne(d => d.User).WithMany(p => p.UserOfficeAccesses)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserOfficeAccess_UserMaster");
        });

        modelBuilder.Entity<UserShowCalendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserShow__3214EC27E1DBF190");

            entity.ToTable("UserShowCalendar");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserShowCalendarIdPk).HasColumnName("UserShowCalendar_ID_PK");

            entity.HasOne(d => d.User).WithMany(p => p.UserShowCalendars)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserShowC__UserI__3694540E");
        });

        modelBuilder.Entity<VariableMaster>(entity =>
        {
            entity.HasKey(e => e.VariableId);

            entity.ToTable("VariableMaster");

            entity.Property(e => e.VariableId)
                .ValueGeneratedNever()
                .HasColumnName("VariableID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.VariableCalculationFormula).HasMaxLength(500);
            entity.Property(e => e.VariableField)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VariableModuleId).HasColumnName("VariableModuleID");
            entity.Property(e => e.VariableName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VariableTable)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VendorBill>(entity =>
        {
            entity.HasKey(e => e.VendorBillId).HasName("PK__VendorBi__4B18444972C27F07");

            entity.ToTable("VendorBill");

            entity.Property(e => e.VendorBillId).HasColumnName("VendorBillID");
            entity.Property(e => e.ActualAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BillStatus).HasMaxLength(100);
            entity.Property(e => e.CargoDocumentId).HasColumnName("CargoDocumentID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CostSheetId).HasColumnName("CostSheetID");
            entity.Property(e => e.CreditDays).HasMaxLength(20);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.Cycle)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateLocked).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.EducationCess).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExchangeRateId).HasColumnName("ExchangeRateID");
            entity.Property(e => e.FinalDestination).HasMaxLength(50);
            entity.Property(e => e.FlightDetails).HasMaxLength(50);
            entity.Property(e => e.FreightStatus).HasMaxLength(20);
            entity.Property(e => e.HblHawb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL_HAWB");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.IsSentToParty).HasColumnName("isSentToParty");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LocalCurrencyId).HasColumnName("LocalCurrencyID");
            entity.Property(e => e.MblMawb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL_MAWB");
            entity.Property(e => e.NonTaxableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Notes1).HasMaxLength(200);
            entity.Property(e => e.PayingParty).HasMaxLength(100);
            entity.Property(e => e.PayingPartyAddress).HasMaxLength(300);
            entity.Property(e => e.PayingPartyAddressId).HasColumnName("PayingPartyAddressID");
            entity.Property(e => e.PayingPartyId).HasColumnName("PayingPartyID");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Remarks).HasMaxLength(100);
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shecess)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SHECess");
            entity.Property(e => e.ShipperVendorBillDetails).HasMaxLength(50);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxAmountLocalCurrency).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VendorBillAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VendorBillAmountLocalCurrency).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VendorBillAmountWords).HasMaxLength(200);
            entity.Property(e => e.VendorBillApprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorBillDate).HasColumnType("datetime");
            entity.Property(e => e.VendorBillNumber).HasMaxLength(20);
            entity.Property(e => e.VendorBillType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorBillTypeGst).HasMaxLength(100);
            entity.Property(e => e.VesselVoyage).HasMaxLength(50);
        });

        modelBuilder.Entity<VendorBillLineItem>(entity =>
        {
            entity.HasKey(e => e.VendorBillLineItemId).HasName("PK__VendorBi__12D3959CFD184611");

            entity.Property(e => e.VendorBillLineItemId).HasColumnName("VendorBillLineItemID");
            entity.Property(e => e.ApplyPer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.ChargeId).HasColumnName("ChargeID");
            entity.Property(e => e.ChargeItemId).HasColumnName("ChargeItemID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.ExRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExRateId).HasColumnName("ExRateID");
            entity.Property(e => e.ExpectedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.NonTaxableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RealizedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ServiceCode).HasMaxLength(100);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxAmountLocalCurrency).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.TaxableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmountLocalCurrency).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VendorBillId).HasColumnName("VendorBillID");
        });

        modelBuilder.Entity<VesselMaster>(entity =>
        {
            entity.HasKey(e => e.VesselId);

            entity.ToTable("VesselMaster");

            entity.Property(e => e.VesselId).HasColumnName("VesselID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.OceanLineId).HasColumnName("OceanLineID");
            entity.Property(e => e.VesselName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwAccountStatstemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAccountStatstemp");

            entity.Property(e => e.AmountInr)
                .HasColumnType("decimal(34, 12)")
                .HasColumnName("AMOUNT_INR");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAccountsActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AccountsActivity");

            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.Agent)
                .HasMaxLength(100)
                .HasColumnName("AGENT");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.CostsheetStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COSTSHEET_STATUS");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.Expense)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("EXPENSE");
            entity.Property(e => e.ExpenseNontax)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("EXPENSE_NONTAX");
            entity.Property(e => e.Income)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("INCOME");
            entity.Property(e => e.IncomeNontax)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("INCOME_NONTAX");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.JobMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("JOB_MONTH");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Officename)
                .HasMaxLength(100)
                .HasColumnName("OFFICENAME");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.ProfitOnJob)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("PROFIT_ON_JOB");
            entity.Property(e => e.ProfitOnJobNontax)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("PROFIT_ON_JOB_NONTAX");
            entity.Property(e => e.ProfitValueAge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ProfitValue %age");
            entity.Property(e => e.ProfitValueNontaxAge)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ProfitValue_NONTAX %age");
            entity.Property(e => e.SalesPerson)
                .HasMaxLength(100)
                .HasColumnName("Sales_Person");
            entity.Property(e => e.Shipper).HasMaxLength(100);
        });

        modelBuilder.Entity<VwAccountsActivityReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AccountsActivity_REPORT");

            entity.Property(e => e.Agent)
                .HasMaxLength(100)
                .HasColumnName("AGENT");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("COST");
            entity.Property(e => e.CostNontax)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("COST_NONTAX");
            entity.Property(e => e.CostsheetStatus)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("COSTSHEET_STATUS");
            entity.Property(e => e.Customer)
                .HasMaxLength(100)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.GrossProfit)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("GROSS PROFIT");
            entity.Property(e => e.GrossProfitNontax)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("GROSS PROFIT_NONTAX");
            entity.Property(e => e.InvDate)
                .HasColumnType("date")
                .HasColumnName("INV DATE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.Month)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("MONTH");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Profit)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PROFIT%");
            entity.Property(e => e.ProfitNontax)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PROFIT%_NONTAX");
            entity.Property(e => e.Revenue)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("REVENUE");
            entity.Property(e => e.RevenueNontax)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("REVENUE_NONTAX");
            entity.Property(e => e.SalesExecutive)
                .HasMaxLength(100)
                .HasColumnName("SALES EXECUTIVE");
            entity.Property(e => e.Shipper).HasMaxLength(100);
        });

        modelBuilder.Entity<VwAccountsExpenseGroupBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Accounts_ExpenseGroupBase");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ChargeAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CHARGE_AMOUNT");
            entity.Property(e => e.Group)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GROUP");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Month)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MONTH");
            entity.Property(e => e.SrNo).HasColumnName("SR_NO");
        });

        modelBuilder.Entity<VwAccountsExpenseGroupBase2122>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Accounts_ExpenseGroupBase_2122");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ChargeAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CHARGE_AMOUNT");
            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.ChargeId).HasColumnName("ChargeID");
            entity.Property(e => e.Group)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GROUP");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAccountsGstAvary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Accounts_GST_AVARY");

            entity.Property(e => e.CentralTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Central Tax");
            entity.Property(e => e.Gstnumber)
                .HasMaxLength(100)
                .HasColumnName("GSTnumber");
            entity.Property(e => e.Igst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IGST");
            entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceTypeGst)
                .HasMaxLength(100)
                .HasColumnName("invoiceTypeGst");
            entity.Property(e => e.PayingParty).HasMaxLength(100);
            entity.Property(e => e.PayingPartyId).HasColumnName("PayingPartyID");
            entity.Property(e => e.StateName).HasMaxLength(50);
            entity.Property(e => e.StateTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("State Tax");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TaxableValue)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("Taxable value");
        });

        modelBuilder.Entity<VwAccountsGstBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Accounts_GST_Base");

            entity.Property(e => e.CentralTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Central Tax");
            entity.Property(e => e.Gstnumber)
                .HasMaxLength(100)
                .HasColumnName("GSTnumber");
            entity.Property(e => e.Igst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IGST");
            entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceTypeGst)
                .HasMaxLength(100)
                .HasColumnName("invoiceTypeGst");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PayingParty).HasMaxLength(100);
            entity.Property(e => e.PayingPartyId).HasColumnName("PayingPartyID");
            entity.Property(e => e.StateName).HasMaxLength(50);
            entity.Property(e => e.StateTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("State Tax");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.TaxableValue)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("Taxable value");
        });

        modelBuilder.Entity<VwAccountsGstMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Accounts_GST_Main");

            entity.Property(e => e.CentralTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Central Tax");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .HasColumnName("Customer Name");
            entity.Property(e => e.Gstin)
                .HasMaxLength(100)
                .HasColumnName("GSTIN");
            entity.Property(e => e.Igst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IGST");
            entity.Property(e => e.InvoiceDate)
                .HasColumnType("date")
                .HasColumnName("Invoice Date");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(20)
                .HasColumnName("Invoice No");
            entity.Property(e => e.InvoiceValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Invoice Value");
            entity.Property(e => e.Irn)
                .HasMaxLength(100)
                .HasColumnName("IRN #");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StateName).HasMaxLength(50);
            entity.Property(e => e.StateOfSupply)
                .HasMaxLength(100)
                .HasColumnName("State of supply");
            entity.Property(e => e.StateTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("State Tax");
            entity.Property(e => e.TaxRate)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("Tax Rate(%)");
            entity.Property(e => e.TaxableValue)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("Taxable value");
        });

        modelBuilder.Entity<VwAccountsIncomeGroupBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Accounts_IncomeGroupBase");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ChargeAmount)
                .HasColumnType("decimal(20, 4)")
                .HasColumnName("CHARGE_AMOUNT");
            entity.Property(e => e.Group)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GROUP");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Month)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MONTH");
            entity.Property(e => e.SrNo).HasColumnName("SR_NO");
        });

        modelBuilder.Entity<VwAccountsIncomeGroupBase2122>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Accounts_IncomeGroupBase_2122");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ChargeAmount)
                .HasColumnType("decimal(20, 4)")
                .HasColumnName("CHARGE_AMOUNT");
            entity.Property(e => e.Group)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GROUP");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAccountsShipmentList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AccountsShipmentList");

            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.DestinationAgent)
                .HasMaxLength(100)
                .HasColumnName("DESTINATION AGENT");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.JobMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Job_Month");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JobType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JOB TYPE");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Office)
                .HasMaxLength(100)
                .HasColumnName("OFFICE");
            entity.Property(e => e.OriginAgent)
                .HasMaxLength(100)
                .HasColumnName("ORIGIN AGENT");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAccountsTaxbreakupBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Accounts_taxbreakup_base");

            entity.Property(e => e.ComponentName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ComponentPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.Nontaxable)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("NONTAXABLE");
            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Taxable)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("TAXABLE");
            entity.Property(e => e.Taxamt)
                .HasColumnType("decimal(38, 10)")
                .HasColumnName("TAXAMT");
            entity.Property(e => e.Taxgroup)
                .HasMaxLength(84)
                .IsUnicode(false)
                .HasColumnName("TAXGROUP");
        });

        modelBuilder.Entity<VwAgentwiseReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AgentwiseReport");

            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .HasColumnName("Agent Name");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.DateCreated).HasColumnType("date");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.ShipmentMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SHIPMENT MONTH");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.TotalChargeable).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalNetWeightKgs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalNetWeightKGS");
            entity.Property(e => e.TotalVolumeCbm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalVolumeCBM");
            entity.Property(e => e.TypeOfShipment)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TYPE OF SHIPMENT");
        });

        modelBuilder.Entity<VwAirDocumentsStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AirDocumentsStatus");

            entity.Property(e => e.AgentHawb)
                .HasMaxLength(20)
                .HasColumnName("AGENT HAWB");
            entity.Property(e => e.AgentMawb)
                .HasMaxLength(20)
                .HasColumnName("AGENT MAWB");
            entity.Property(e => e.Are1)
                .HasMaxLength(20)
                .HasColumnName("ARE1");
            entity.Property(e => e.Awb)
                .HasMaxLength(20)
                .HasColumnName("AWB");
            entity.Property(e => e.Can)
                .HasMaxLength(20)
                .HasColumnName("CAN");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoManifest)
                .HasMaxLength(20)
                .HasColumnName("CARGO-MANIFEST");
            entity.Property(e => e.CertificateOfOrigin)
                .HasMaxLength(20)
                .HasColumnName("CERTIFICATE OF ORIGIN");
            entity.Property(e => e.CommercialInvoice)
                .HasMaxLength(20)
                .HasColumnName("COMMERCIAL INVOICE");
            entity.Property(e => e.CustomInvoice)
                .HasMaxLength(20)
                .HasColumnName("CUSTOM INVOICE");
            entity.Property(e => e.DgDeclaration)
                .HasMaxLength(20)
                .HasColumnName("DG DECLARATION");
            entity.Property(e => e.Do)
                .HasMaxLength(20)
                .HasColumnName("DO");
            entity.Property(e => e.EnsDeclaration)
                .HasMaxLength(20)
                .HasColumnName("ENS DECLARATION");
            entity.Property(e => e.ExportValueDeclaration)
                .HasMaxLength(20)
                .HasColumnName("EXPORT VALUE DECLARATION");
            entity.Property(e => e.FormSdf)
                .HasMaxLength(20)
                .HasColumnName("FORM SDF");
            entity.Property(e => e.FreightInvoice)
                .HasMaxLength(20)
                .HasColumnName("FREIGHT INVOICE");
            entity.Property(e => e.GatePass)
                .HasMaxLength(20)
                .HasColumnName("GATE PASS");
            entity.Property(e => e.Hawb)
                .HasMaxLength(20)
                .HasColumnName("HAWB");
            entity.Property(e => e.Invoice)
                .HasMaxLength(20)
                .HasColumnName("INVOICE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LcCopy)
                .HasMaxLength(20)
                .HasColumnName("LC COPY");
            entity.Property(e => e.NForm)
                .HasMaxLength(20)
                .HasColumnName("N-FORM");
            entity.Property(e => e.PreAlert)
                .HasMaxLength(20)
                .HasColumnName("PRE ALERT");
            entity.Property(e => e.ShippingBill)
                .HasMaxLength(20)
                .HasColumnName("SHIPPING BILL");
            entity.Property(e => e.Sop)
                .HasMaxLength(20)
                .HasColumnName("SOP");
            entity.Property(e => e.VendorInvoice)
                .HasMaxLength(20)
                .HasColumnName("VENDOR INVOICE");
        });

        modelBuilder.Entity<VwAirstatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AIRStatus");

            entity.Property(e => e.AwbDraft)
                .HasColumnType("datetime")
                .HasColumnName("AWB Draft");
            entity.Property(e => e.AwbIssuedByLiner)
                .HasColumnType("datetime")
                .HasColumnName("AWB Issued by Liner");
            entity.Property(e => e.AwbIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("AWB Issued to Customer");
            entity.Property(e => e.BookingIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("Booking Issued to Customer");
            entity.Property(e => e.BookingRequestReceived)
                .HasColumnType("datetime")
                .HasColumnName("Booking Request Received");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CostSheetApproval)
                .HasColumnType("datetime")
                .HasColumnName("Cost Sheet Approval");
            entity.Property(e => e.CustomDocumentsHandover)
                .HasColumnType("datetime")
                .HasColumnName("Custom Documents HAndover");
            entity.Property(e => e.Delivered).HasColumnType("datetime");
            entity.Property(e => e.DocumentHandover)
                .HasColumnType("datetime")
                .HasColumnName("Document Handover");
            entity.Property(e => e.Draft)
                .HasColumnType("datetime")
                .HasColumnName("DRAFT");
            entity.Property(e => e.EpCopyHandover)
                .HasColumnType("datetime")
                .HasColumnName("EP Copy Handover");
            entity.Property(e => e.FlightDeparture)
                .HasColumnType("datetime")
                .HasColumnName("Flight Departure");
            entity.Property(e => e.InvoiceGeneration)
                .HasColumnType("datetime")
                .HasColumnName("Invoice Generation");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("Invoice Issued to Customer");
            entity.Property(e => e.InvoiceSentToAgent)
                .HasColumnType("datetime")
                .HasColumnName("Invoice Sent to Agent");
            entity.Property(e => e.PreAlertSent)
                .HasColumnType("datetime")
                .HasColumnName("Pre-Alert Sent");
        });

        modelBuilder.Entity<VwAllCargoList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AllCargoList");

            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.BookingNumber).HasMaxLength(60);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ConsigneeId).HasColumnName("ConsigneeID");
            entity.Property(e => e.CreatedBys)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.Cycle)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("CYCLE");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DestinationAgent).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNumber).HasColumnName("INVOICE_NUMBER");
            entity.Property(e => e.Invoiceno)
                .HasMaxLength(50)
                .HasColumnName("invoiceno");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBys)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OceanLine).HasMaxLength(200);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OriginAgent).HasMaxLength(200);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Vessel).HasMaxLength(63);
            entity.Property(e => e.WebJob)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
        });

        modelBuilder.Entity<VwAllCargoList1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AllCargoList1");

            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.BookingNumber).HasMaxLength(60);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ConsigneeId).HasColumnName("ConsigneeID");
            entity.Property(e => e.CreatedBys)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.Cycle)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("CYCLE");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DestinationAgent).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNumber).HasColumnName("INVOICE_NUMBER");
            entity.Property(e => e.Invoiceno).HasColumnName("invoiceno");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBys)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OceanLine).HasMaxLength(200);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OriginAgent).HasMaxLength(200);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Vessel).HasMaxLength(50);
            entity.Property(e => e.WebJob)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
        });

        modelBuilder.Entity<VwAllHbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AllHbl");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ConsigneeName).HasMaxLength(400);
            entity.Property(e => e.DateCreated).HasColumnType("date");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hblid)
                .ValueGeneratedOnAdd()
                .HasColumnName("HBLID");
            entity.Property(e => e.Hblnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HBLNumber");
            entity.Property(e => e.Mblnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MBLNumber");
            entity.Property(e => e.ShipperName).HasMaxLength(400);
        });

        modelBuilder.Entity<VwAppointment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Appointments");

            entity.Property(e => e.AppontmentType).HasMaxLength(20);
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .HasColumnName("AREA");
            entity.Property(e => e.Comments).HasColumnName("COMMENTS");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.Createdby).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Purpose)
                .HasMaxLength(50)
                .HasColumnName("purpose");
            entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("TYPE");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<VwBasicDsrFormat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_BasicDSR_Format");

            entity.Property(e => e.ApproxEta)
                .HasMaxLength(24)
                .HasColumnName("APPROX ETA");
            entity.Property(e => e.Ata)
                .HasColumnType("datetime")
                .HasColumnName("ATA");
            entity.Property(e => e.Atd)
                .HasColumnType("datetime")
                .HasColumnName("ATD");
            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.BookingNo)
                .HasMaxLength(60)
                .HasColumnName("BOOKING NO");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.Container).HasColumnName("CONTAINER");
            entity.Property(e => e.ContainerPickedUpByCustomer)
                .HasMaxLength(40)
                .HasColumnName("CONTAINER PICKED UP BY CUSTOMER");
            entity.Property(e => e.Containertext)
                .HasMaxLength(396)
                .HasColumnName("CONTAINERTEXT");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.CustomerReference).HasMaxLength(50);
            entity.Property(e => e.DeliveryDt)
                .HasMaxLength(20)
                .HasColumnName("DELIVERY DT");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.HblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL NO");
            entity.Property(e => e.IncoTermId).HasColumnName("IncoTermID");
            entity.Property(e => e.IncotermName)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.MblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL NO");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlert)
                .HasMaxLength(20)
                .HasColumnName("PRE ALERT");
            entity.Property(e => e.Remark)
                .HasMaxLength(66)
                .HasColumnName("REMARK");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .HasColumnName("REMARKS");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.ShipperInvoiceNo).HasColumnName("SHIPPER INVOICE NO");
            entity.Property(e => e.ShippingLine)
                .HasMaxLength(200)
                .HasColumnName("SHIPPING LINE");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TransitTime)
                .HasMaxLength(15)
                .HasColumnName("TRANSIT TIME");
            entity.Property(e => e.VesselName)
                .HasMaxLength(63)
                .HasColumnName("VESSEL NAME");
        });

        modelBuilder.Entity<VwBasicDsrFormatChn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_BasicDSR_Format_CHN");

            entity.Property(e => e.ApproxEta)
                .HasMaxLength(24)
                .HasColumnName("APPROX ETA");
            entity.Property(e => e.BookingNo)
                .HasMaxLength(60)
                .HasColumnName("BOOKING NO");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Cargotype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CARGOTYPE");
            entity.Property(e => e.Cbm)
                .HasMaxLength(25)
                .HasColumnName("CBM");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.Container).HasColumnName("CONTAINER");
            entity.Property(e => e.CurrentStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CURRENT STATUS");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.CutOff)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CUT OFF");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DeliveryDt)
                .HasMaxLength(20)
                .HasColumnName("DELIVERY DT");
            entity.Property(e => e.DestinationAgent).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasMaxLength(20)
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasMaxLength(40)
                .HasColumnName("ETD");
            entity.Property(e => e.GrossWeight)
                .HasMaxLength(27)
                .HasColumnName("Gross Weight");
            entity.Property(e => e.HblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL NO");
            entity.Property(e => e.IncotermName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.MblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL NO");
            entity.Property(e => e.NoPkgs)
                .HasMaxLength(28)
                .HasColumnName("NO. PKGS");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlert)
                .HasMaxLength(20)
                .HasColumnName("PRE ALERT");
            entity.Property(e => e.Product)
                .HasMaxLength(41)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(66)
                .HasColumnName("REMARK");
            entity.Property(e => e.ShipmentStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SHIPMENT STATUS");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.ShipperInvoiceNo).HasColumnName("SHIPPER INVOICE NO");
            entity.Property(e => e.ShippingLine)
                .HasMaxLength(200)
                .HasColumnName("SHIPPING LINE");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.VesselName)
                .HasMaxLength(63)
                .HasColumnName("VESSEL NAME");
        });

        modelBuilder.Entity<VwBasicDsrFormatChnInvno>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_BasicDSR_Format_CHN_INVNO");

            entity.Property(e => e.ApproxEta)
                .HasMaxLength(24)
                .HasColumnName("APPROX ETA");
            entity.Property(e => e.BookingNo)
                .HasMaxLength(60)
                .HasColumnName("BOOKING NO");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Cargotype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CARGOTYPE");
            entity.Property(e => e.Cbm)
                .HasMaxLength(25)
                .HasColumnName("CBM");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.Container).HasColumnName("CONTAINER");
            entity.Property(e => e.CurrentStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CURRENT STATUS");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.CutOff)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CUT OFF");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DeliveryDt)
                .HasMaxLength(20)
                .HasColumnName("DELIVERY DT");
            entity.Property(e => e.DestinationAgent).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasMaxLength(20)
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasMaxLength(40)
                .HasColumnName("ETD");
            entity.Property(e => e.GrossWeight)
                .HasMaxLength(27)
                .HasColumnName("Gross Weight");
            entity.Property(e => e.HblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL NO");
            entity.Property(e => e.IncotermName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.MblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL NO");
            entity.Property(e => e.NoPkgs)
                .HasMaxLength(28)
                .HasColumnName("NO. PKGS");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlert)
                .HasMaxLength(20)
                .HasColumnName("PRE ALERT");
            entity.Property(e => e.Product)
                .HasMaxLength(41)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(66)
                .HasColumnName("REMARK");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.ShipperInvoiceDate)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPER INVOICE DATE");
            entity.Property(e => e.ShipperInvoiceNo)
                .HasMaxLength(20)
                .HasColumnName("SHIPPER INVOICE NO");
            entity.Property(e => e.ShippingLine)
                .HasMaxLength(200)
                .HasColumnName("SHIPPING LINE");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.VesselName)
                .HasMaxLength(63)
                .HasColumnName("VESSEL NAME");
        });

        modelBuilder.Entity<VwBasicDsrFormatFy1819>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_BasicDSR_Format_fy1819");

            entity.Property(e => e.ApproxEta)
                .HasMaxLength(24)
                .HasColumnName("APPROX ETA");
            entity.Property(e => e.BookingNo)
                .HasMaxLength(60)
                .HasColumnName("BOOKING NO");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.Container).HasColumnName("CONTAINER");
            entity.Property(e => e.ContainerPickedUpByCustomer)
                .HasMaxLength(40)
                .HasColumnName("CONTAINER PICKED UP BY CUSTOMER");
            entity.Property(e => e.CustomerRef).HasMaxLength(50);
            entity.Property(e => e.DeliveryDt)
                .HasMaxLength(20)
                .HasColumnName("DELIVERY DT");
            entity.Property(e => e.Eta)
                .HasMaxLength(40)
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasMaxLength(40)
                .HasColumnName("ETD");
            entity.Property(e => e.HblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL NO");
            entity.Property(e => e.Invno)
                .HasMaxLength(50)
                .HasColumnName("INVNO");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.MblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL NO");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlert)
                .HasMaxLength(20)
                .HasColumnName("PRE ALERT");
            entity.Property(e => e.Remark)
                .HasMaxLength(66)
                .HasColumnName("REMARK");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .HasColumnName("REMARKS");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.ShipperInvoiceNo).HasColumnName("SHIPPER INVOICE NO");
            entity.Property(e => e.ShippingLine)
                .HasMaxLength(200)
                .HasColumnName("SHIPPING LINE");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.VesselName)
                .HasMaxLength(63)
                .HasColumnName("VESSEL NAME");
        });

        modelBuilder.Entity<VwBasicDsrFormatPune>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_BasicDSR_Format_PUNE");

            entity.Property(e => e.Agent)
                .HasMaxLength(200)
                .HasColumnName("AGENT");
            entity.Property(e => e.ApproxEta)
                .HasMaxLength(24)
                .HasColumnName("APPROX ETA");
            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.BookingNo)
                .HasMaxLength(60)
                .HasColumnName("BOOKING NO");
            entity.Property(e => e.Cbm)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("CBM");
            entity.Property(e => e.CommOutput).HasColumnName("COMM_Output");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.Container).HasColumnName("CONTAINER");
            entity.Property(e => e.ContainerPickedUpByCustomer)
                .HasMaxLength(40)
                .HasColumnName("CONTAINER PICKED UP BY CUSTOMER");
            entity.Property(e => e.Containertext)
                .HasMaxLength(396)
                .HasColumnName("CONTAINERTEXT");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.CustomerReference).HasMaxLength(50);
            entity.Property(e => e.DeliveryDt)
                .HasMaxLength(20)
                .HasColumnName("DELIVERY DT");
            entity.Property(e => e.Eta)
                .HasMaxLength(40)
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasMaxLength(40)
                .HasColumnName("ETD");
            entity.Property(e => e.GrossWeight)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("Gross Weight");
            entity.Property(e => e.HblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL NO");
            entity.Property(e => e.IncotermName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.MblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL NO");
            entity.Property(e => e.NoPkgs).HasColumnName("NO. PKGS");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlert)
                .HasMaxLength(20)
                .HasColumnName("PRE ALERT");
            entity.Property(e => e.Remark)
                .HasMaxLength(66)
                .HasColumnName("REMARK");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .HasColumnName("REMARKS");
            entity.Property(e => e.SbDate).HasColumnName("SB DATE");
            entity.Property(e => e.SbNo).HasColumnName("SB NO");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.ShipperInvoiceNo).HasColumnName("SHIPPER INVOICE NO");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.VesselName)
                .HasMaxLength(63)
                .HasColumnName("VESSEL NAME");
            entity.Property(e => e.YourFreightBillDate).HasColumnName("Your Freight Bill Date");
            entity.Property(e => e.YourFreightBillNo).HasColumnName("Your Freight Bill No.");
        });

        modelBuilder.Entity<VwBasicDsrFormatRingplu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_BasicDSR_Format_RINGPLUS");

            entity.Property(e => e.BookingNo)
                .HasMaxLength(60)
                .HasColumnName("BOOKING NO");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.Container).HasColumnName("CONTAINER");
            entity.Property(e => e.EtaAtPod)
                .HasColumnType("date")
                .HasColumnName("ETA AT POD");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.FinalDeliveryDt)
                .HasMaxLength(20)
                .HasColumnName("FINAL DELIVERY DT");
            entity.Property(e => e.HblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL NO");
            entity.Property(e => e.IncotermName)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.MblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL NO");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlert)
                .HasMaxLength(20)
                .HasColumnName("PRE ALERT");
            entity.Property(e => e.Remark)
                .HasMaxLength(66)
                .HasColumnName("REMARK");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.ShipperInvoiceNo).HasColumnName("SHIPPER INVOICE NO");
            entity.Property(e => e.ShippingLine)
                .HasMaxLength(200)
                .HasColumnName("SHIPPING LINE");
            entity.Property(e => e.Status)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.VesselName)
                .HasMaxLength(63)
                .HasColumnName("VESSEL NAME");
        });

        modelBuilder.Entity<VwBillList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_BillList");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CostSheetId).HasColumnName("CostSheetID");
            entity.Property(e => e.CreditDays).HasMaxLength(20);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.Cycle)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateLocked).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.EducationCess).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExchangeRateId).HasColumnName("ExchangeRateID");
            entity.Property(e => e.FinalDestination).HasMaxLength(50);
            entity.Property(e => e.FlightDetails).HasMaxLength(50);
            entity.Property(e => e.FreightStatus).HasMaxLength(20);
            entity.Property(e => e.HblHawb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL_HAWB");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.IsSentToParty).HasColumnName("isSentToParty");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LocalCurrencyId).HasColumnName("LocalCurrencyID");
            entity.Property(e => e.MblMawb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL_MAWB");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NonTaxableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Notes1).HasMaxLength(200);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.PayingParty).HasMaxLength(100);
            entity.Property(e => e.PayingPartyAddress).HasMaxLength(300);
            entity.Property(e => e.PayingPartyAddressId).HasColumnName("PayingPartyAddressID");
            entity.Property(e => e.PayingPartyId).HasColumnName("PayingPartyID");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shecess)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SHECess");
            entity.Property(e => e.ShipperVendorBillDetails).HasMaxLength(50);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxAmountLocalCurrency).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorBillAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VendorBillAmountLocalCurrency).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VendorBillAmountWords).HasMaxLength(200);
            entity.Property(e => e.VendorBillApprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorBillDate).HasColumnType("datetime");
            entity.Property(e => e.VendorBillId).HasColumnName("VendorBillID");
            entity.Property(e => e.VendorBillNumber).HasMaxLength(20);
            entity.Property(e => e.VendorBillType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorBillTypeGst).HasMaxLength(100);
            entity.Property(e => e.VesselVoyage).HasMaxLength(50);
        });

        modelBuilder.Entity<VwCampaignList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CampaignList");

            entity.Property(e => e.CampaignDescription).HasMaxLength(200);
            entity.Property(e => e.CampaignId).HasColumnName("CampaignID");
            entity.Property(e => e.CampaignName).HasMaxLength(50);
            entity.Property(e => e.CampaignOwnerId).HasColumnName("CampaignOwnerID");
            entity.Property(e => e.CampaignStatus)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCargoPackageDetailsText>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CargoPackageDetails_TEXT");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CommOutput).HasColumnName("COMM_Output");
            entity.Property(e => e.InvdtOutput).HasColumnName("INVDT_Output");
            entity.Property(e => e.InvnoOutput).HasColumnName("INVNO_Output");
            entity.Property(e => e.SbdateOutput).HasColumnName("SBDate_Output");
            entity.Property(e => e.SbnoOutput).HasColumnName("SBNO_Output");
        });

        modelBuilder.Entity<VwCargoPackageSpool>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CargoPackageSpools");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(30);
            entity.Property(e => e.MarksAndNumbers).HasMaxLength(100);
            entity.Property(e => e.Pallet).HasColumnName("PALLET");
            entity.Property(e => e.Seperator).HasColumnName("SEPERATOR");
            entity.Property(e => e.Spools).HasColumnName("SPOOLS");
        });

        modelBuilder.Entity<VwCargoType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CargoType");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCargoWeightInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CargoWeightInformation");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.TotalChargeable).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TotalGrossWeightKgs)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalGrossWeightKGS");
            entity.Property(e => e.TotalNetWeightKgs)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalNetWeightKGS");
            entity.Property(e => e.TotalVolWeight).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TotalVolumeCbm)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalVolumeCBM");
        });

        modelBuilder.Entity<VwCbmreport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCBMReport");

            entity.Property(e => e.Customer)
                .HasMaxLength(100)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.ParentCompanyId).HasColumnName("parentCompanyID");
            entity.Property(e => e._2018oe)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("2018OE");
            entity.Property(e => e._2018oi)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("2018OI");
            entity.Property(e => e._2019oe)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("2019OE");
            entity.Property(e => e._2019oi)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("2019OI");
        });

        modelBuilder.Entity<VwChennaiDsrAi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Chennai_DSR_AI");

            entity.Property(e => e.BookingConfirmationDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMATION DATE");
            entity.Property(e => e.BookingReceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING RECEIVED DATE");
            entity.Property(e => e.Carrier)
                .HasMaxLength(60)
                .HasColumnName("CARRIER");
            entity.Property(e => e.Cfs).HasColumnName("CFS");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.ContainerNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CONTAINER NO");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created Date");
            entity.Property(e => e.CurrentStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CURRENT STATUS");
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("DESTINATION");
            entity.Property(e => e.Eta)
                .HasMaxLength(20)
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasMaxLength(40)
                .HasColumnName("ETD");
            entity.Property(e => e.FinalMawbNo).HasColumnName("FINAL MAWB NO");
            entity.Property(e => e.FlightNo)
                .HasMaxLength(63)
                .HasColumnName("FLIGHT NO");
            entity.Property(e => e.HawbNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HAWB No");
            entity.Property(e => e.IgmNoSublineNo).HasColumnName("IGM NO/ SUBLINE NO");
            entity.Property(e => e.IgmSentOn).HasColumnName("IGM SENT ON");
            entity.Property(e => e.InvoicesSentDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICES SENT DATE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.ManifestSent)
                .HasColumnType("datetime")
                .HasColumnName("MANIFEST SENT");
            entity.Property(e => e.MawbNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MAWB No");
            entity.Property(e => e.NoPkgsGrsWtCbm)
                .HasMaxLength(80)
                .HasColumnName("NO.PKGS/GRS.WT/CBM");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.PreAlertReceived)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT RECEIVED");
            entity.Property(e => e.PreAlertSentToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO CONSIGNEE");
            entity.Property(e => e.Remarks).HasColumnName("REMARKS");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.SurrenderblReceived)
                .HasColumnType("datetime")
                .HasColumnName("SURRENDERBL RECEIVED");
            entity.Property(e => e.TransitStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TRANSIT STATUS");
            entity.Property(e => e.TypeOfShipment)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TYPE OF SHIPMENT");
        });

        modelBuilder.Entity<VwChennaiDsrAiCando>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Chennai_DSR_AI_CANDO");

            entity.Property(e => e.BookingConfirmationDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMATION DATE");
            entity.Property(e => e.BookingReceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING RECEIVED DATE");
            entity.Property(e => e.Carrier)
                .HasMaxLength(60)
                .HasColumnName("CARRIER");
            entity.Property(e => e.Cfs).HasColumnName("CFS");
            entity.Property(e => e.Chaname)
                .HasMaxLength(200)
                .HasColumnName("CHAName");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.ContainerNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CONTAINER NO");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created Date");
            entity.Property(e => e.CurrentStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CURRENT STATUS");
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("DESTINATION");
            entity.Property(e => e.Eta)
                .HasMaxLength(20)
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasMaxLength(40)
                .HasColumnName("ETD");
            entity.Property(e => e.FinalMawbNo).HasColumnName("FINAL MAWB NO");
            entity.Property(e => e.FlightNo)
                .HasMaxLength(63)
                .HasColumnName("FLIGHT NO");
            entity.Property(e => e.HawbNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HAWB No");
            entity.Property(e => e.IgmNoSublineNo).HasColumnName("IGM NO/ SUBLINE NO");
            entity.Property(e => e.IgmSentOn).HasColumnName("IGM SENT ON");
            entity.Property(e => e.InvoiceNumber).HasColumnName("INVOICE_NUMBER");
            entity.Property(e => e.InvoicesSentDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICES SENT DATE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.ManifestSent)
                .HasColumnType("datetime")
                .HasColumnName("MANIFEST SENT");
            entity.Property(e => e.MawbNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MAWB No");
            entity.Property(e => e.NoPkgsGrsWtCbm)
                .HasMaxLength(80)
                .HasColumnName("NO.PKGS/GRS.WT/CBM");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.PreAlertReceived)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT RECEIVED");
            entity.Property(e => e.PreAlertSentToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO CONSIGNEE");
            entity.Property(e => e.Remarks).HasColumnName("REMARKS");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.SurrenderblReceived)
                .HasColumnType("datetime")
                .HasColumnName("SURRENDERBL RECEIVED");
            entity.Property(e => e.TransitStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TRANSIT STATUS");
            entity.Property(e => e.TypeOfShipment)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TYPE OF SHIPMENT");
        });

        modelBuilder.Entity<VwChennaiDsrOi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Chennai_DSR_OI");

            entity.Property(e => e.BookingConfirmationDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMATION DATE");
            entity.Property(e => e.Cbm)
                .HasMaxLength(4000)
                .HasColumnName("CBM");
            entity.Property(e => e.Cfs).HasColumnName("CFS");
            entity.Property(e => e.Cha).HasColumnName("CHA");
            entity.Property(e => e.CoLoader)
                .HasMaxLength(200)
                .HasColumnName("CO-LOADER");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.ContainerNo).HasColumnName("CONTAINER NO");
            entity.Property(e => e.CourierMailSentDate)
                .HasColumnType("datetime")
                .HasColumnName("COURIER / MAIL SENT DATE ");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created Date");
            entity.Property(e => e.CurrentStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CURRENT STATUS");
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("DESTINATION");
            entity.Property(e => e.Eta)
                .HasMaxLength(20)
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasMaxLength(40)
                .HasColumnName("ETD");
            entity.Property(e => e.FinalMblNo).HasColumnName("FINAL MBL NO");
            entity.Property(e => e.GrossWeight)
                .HasMaxLength(4000)
                .HasColumnName("Gross Weight");
            entity.Property(e => e.HblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL No");
            entity.Property(e => e.IgmNoSublineNo).HasColumnName("IGM NO/ SUBLINE NO");
            entity.Property(e => e.IgmSentOn).HasColumnName("IGM SENT ON");
            entity.Property(e => e.InvoiceNumber).HasColumnName("INVOICE_NUMBER");
            entity.Property(e => e.InvoicesSentDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICES SENT DATE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.Liner)
                .HasMaxLength(30)
                .HasColumnName("LINER");
            entity.Property(e => e.ManifestSent)
                .HasColumnType("datetime")
                .HasColumnName("MANIFEST SENT");
            entity.Property(e => e.MblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL No");
            entity.Property(e => e.NoPkgs)
                .HasMaxLength(4000)
                .HasColumnName("NO. PKGS");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.OverseasAgent)
                .HasMaxLength(100)
                .HasColumnName("OVERSEAS AGENT");
            entity.Property(e => e.PreAlertReceived)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT RECEIVED");
            entity.Property(e => e.PreAlertSentToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO CONSIGNEE");
            entity.Property(e => e.Remarks).HasColumnName("REMARKS");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.SurrenderBlReceived).HasColumnName("SURRENDER BL RECEIVED");
            entity.Property(e => e.TransitStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TRANSIT STATUS");
            entity.Property(e => e.TypeOfShipment)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TYPE OF SHIPMENT");
            entity.Property(e => e.VesselName)
                .HasMaxLength(63)
                .HasColumnName("VESSEL NAME");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
        });

        modelBuilder.Entity<VwChennaiDsrOiCando>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Chennai_DSR_OI_CANDO");

            entity.Property(e => e.BookingConfirmationDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMATION DATE");
            entity.Property(e => e.Cbm)
                .HasMaxLength(4000)
                .HasColumnName("CBM");
            entity.Property(e => e.Cfs)
                .HasMaxLength(100)
                .HasColumnName("CFS");
            entity.Property(e => e.Chaname)
                .HasMaxLength(200)
                .HasColumnName("CHAName");
            entity.Property(e => e.CoLoader)
                .HasMaxLength(200)
                .HasColumnName("CO-LOADER");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.ContainerNo).HasColumnName("CONTAINER NO");
            entity.Property(e => e.CourierMailSentDate)
                .HasColumnType("datetime")
                .HasColumnName("COURIER / MAIL SENT DATE ");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created Date");
            entity.Property(e => e.CurrentStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CURRENT STATUS");
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("DESTINATION");
            entity.Property(e => e.Eta)
                .HasMaxLength(20)
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasMaxLength(40)
                .HasColumnName("ETD");
            entity.Property(e => e.FinalMblNo).HasColumnName("FINAL MBL NO");
            entity.Property(e => e.GrossWeight)
                .HasMaxLength(4000)
                .HasColumnName("Gross Weight");
            entity.Property(e => e.HblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL No");
            entity.Property(e => e.IgmNoSublineNo)
                .HasMaxLength(500)
                .HasColumnName("IGM NO/ SUBLINE NO");
            entity.Property(e => e.IgmSentOn).HasColumnName("IGM SENT ON");
            entity.Property(e => e.InvoiceNumber).HasColumnName("INVOICE_NUMBER");
            entity.Property(e => e.InvoicesSentDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICES SENT DATE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.Liner)
                .HasMaxLength(30)
                .HasColumnName("LINER");
            entity.Property(e => e.ManifestSent)
                .HasColumnType("datetime")
                .HasColumnName("MANIFEST SENT");
            entity.Property(e => e.MblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL No");
            entity.Property(e => e.NoPkgs)
                .HasMaxLength(4000)
                .HasColumnName("NO. PKGS");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.OverseasAgent)
                .HasMaxLength(100)
                .HasColumnName("OVERSEAS AGENT");
            entity.Property(e => e.PreAlertReceived)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT RECEIVED");
            entity.Property(e => e.PreAlertSentToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO CONSIGNEE");
            entity.Property(e => e.Remarks).HasColumnName("REMARKS");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.SurrenderBlReceived).HasColumnName("SURRENDER BL RECEIVED");
            entity.Property(e => e.TypeOfShipment)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TYPE OF SHIPMENT");
            entity.Property(e => e.VesselName)
                .HasMaxLength(63)
                .HasColumnName("VESSEL NAME");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
        });

        modelBuilder.Entity<VwChennaiDsrOiInvno>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Chennai_DSR_OI_INVNO");

            entity.Property(e => e.BookingConfirmationDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMATION DATE");
            entity.Property(e => e.Cbm)
                .HasMaxLength(4000)
                .HasColumnName("CBM");
            entity.Property(e => e.Cfs).HasColumnName("CFS");
            entity.Property(e => e.Cha).HasColumnName("CHA");
            entity.Property(e => e.CoLoader)
                .HasMaxLength(200)
                .HasColumnName("CO-LOADER");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.ContainerNo).HasColumnName("CONTAINER NO");
            entity.Property(e => e.CourierMailSentDate)
                .HasColumnType("datetime")
                .HasColumnName("COURIER / MAIL SENT DATE ");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created Date");
            entity.Property(e => e.CurrentStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CURRENT STATUS");
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("DESTINATION");
            entity.Property(e => e.Eta)
                .HasMaxLength(20)
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasMaxLength(40)
                .HasColumnName("ETD");
            entity.Property(e => e.FinalMblNo).HasColumnName("FINAL MBL NO");
            entity.Property(e => e.GrossWeight)
                .HasMaxLength(4000)
                .HasColumnName("Gross Weight");
            entity.Property(e => e.HblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL No");
            entity.Property(e => e.IgmNoSublineNo).HasColumnName("IGM NO/ SUBLINE NO");
            entity.Property(e => e.IgmSentOn).HasColumnName("IGM SENT ON");
            entity.Property(e => e.InvoicesSentDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICES SENT DATE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.Liner)
                .HasMaxLength(30)
                .HasColumnName("LINER");
            entity.Property(e => e.ManifestSent)
                .HasColumnType("datetime")
                .HasColumnName("MANIFEST SENT");
            entity.Property(e => e.MblNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL No");
            entity.Property(e => e.NoPkgs)
                .HasMaxLength(4000)
                .HasColumnName("NO. PKGS");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.OverseasAgent)
                .HasMaxLength(100)
                .HasColumnName("OVERSEAS AGENT");
            entity.Property(e => e.PreAlertReceived)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT RECEIVED");
            entity.Property(e => e.PreAlertSentToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO CONSIGNEE");
            entity.Property(e => e.Remarks).HasColumnName("REMARKS");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.ShipperInvoiceDate)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPER INVOICE DATE");
            entity.Property(e => e.ShipperInvoiceNo)
                .HasMaxLength(30)
                .HasColumnName("SHIPPER INVOICE NO");
            entity.Property(e => e.SurrenderBlReceived).HasColumnName("SURRENDER BL RECEIVED");
            entity.Property(e => e.TypeOfShipment)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TYPE OF SHIPMENT");
            entity.Property(e => e.VesselName)
                .HasMaxLength(63)
                .HasColumnName("VESSEL NAME");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
        });

        modelBuilder.Entity<VwChennaiSalesJob>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ChennaiSalesJobs");

            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Salesperson)
                .HasMaxLength(100)
                .HasColumnName("SALESPERSON");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
        });

        modelBuilder.Entity<VwChnDsrAe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CHN_DSR_AE");

            entity.Property(e => e.ChWt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CH.WT");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("DESTINATION");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.FlightNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FLIGHT NO.");
            entity.Property(e => e.HawbNo)
                .HasMaxLength(100)
                .HasColumnName("HAWB NO.");
            entity.Property(e => e.JobDate)
                .HasColumnType("date")
                .HasColumnName("JOB DATE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO.");
            entity.Property(e => e.MawbNo)
                .HasMaxLength(100)
                .HasColumnName("MAWB NO.");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.Pkg).HasColumnName("PKG");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<VwChnDsrAi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CHN_DSR_AI");

            entity.Property(e => e.ChWt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CH.WT");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("DESTINATION");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.FlightNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FLIGHT NO.");
            entity.Property(e => e.HawbNo)
                .HasMaxLength(100)
                .HasColumnName("HAWB NO.");
            entity.Property(e => e.IgmInwardDate)
                .HasColumnType("date")
                .HasColumnName("IGM INWARD DATE");
            entity.Property(e => e.IgmNoSublineNo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IGM NO / SUBLINE NO.");
            entity.Property(e => e.JobDate)
                .HasColumnType("date")
                .HasColumnName("JOB DATE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO.");
            entity.Property(e => e.MawbNo)
                .HasMaxLength(100)
                .HasColumnName("MAWB NO.");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.Pkg).HasColumnName("PKG");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<VwChnDsrOi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CHN_DSR_OI");

            entity.Property(e => e.Carrier)
                .HasMaxLength(200)
                .HasColumnName("CARRIER");
            entity.Property(e => e.Cbm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CBM");
            entity.Property(e => e.Cfs)
                .HasMaxLength(100)
                .HasColumnName("CFS");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.ContainerNo).HasColumnName("CONTAINER NO");
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("DESTINATION");
            entity.Property(e => e.Destuffing)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DESTUFFING");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.FinalMblNo)
                .HasMaxLength(100)
                .HasColumnName("FINAL MBL NO.");
            entity.Property(e => e.HblNo)
                .HasMaxLength(100)
                .HasColumnName("HBL NO.");
            entity.Property(e => e.IgmInwardDate)
                .HasColumnType("date")
                .HasColumnName("IGM INWARD DATE");
            entity.Property(e => e.IgmNoSublineNo)
                .HasMaxLength(500)
                .HasColumnName("IGM NO / SUBLINE NO.");
            entity.Property(e => e.IgmSplitDate)
                .HasColumnType("date")
                .HasColumnName("IGM SPLIT DATE");
            entity.Property(e => e.JobDate)
                .HasColumnType("date")
                .HasColumnName("JOB DATE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.MblNo)
                .HasMaxLength(100)
                .HasColumnName("MBL NO.");
            entity.Property(e => e.Note)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NOTE");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.Pkg).HasColumnName("PKG");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.TypeOfShipment)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TYPE OF SHIPMENT");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .HasColumnName("VESSEL NAME");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<VwCompanyAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CompanyAddress");

            entity.Property(e => e.AddressTypeNick).HasMaxLength(30);
            entity.Property(e => e.CompanyAddressId).HasColumnName("CompanyAddressID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");
            entity.Property(e => e.FormattedAddress).HasMaxLength(500);
            entity.Property(e => e.Gstnumber)
                .HasMaxLength(100)
                .HasColumnName("GSTnumber");
            entity.Property(e => e.Phone1).HasMaxLength(15);
            entity.Property(e => e.Phone2)
                .HasMaxLength(15)
                .HasColumnName("phone2");
        });

        modelBuilder.Entity<VwCompanyDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CompanyDetails");

            entity.Property(e => e.CafReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.CompanyApprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CompanyType).HasMaxLength(30);
            entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");
            entity.Property(e => e.CompanyTypeName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreditDays).HasMaxLength(20);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gstin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GSTIN");
            entity.Property(e => e.GstregType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GSTRegType");
            entity.Property(e => e.GsttypeId).HasColumnName("GSTTypeID");
            entity.Property(e => e.GsttypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GSTTypeName");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.MepzCode).HasMaxLength(20);
            entity.Property(e => e.Notes).HasMaxLength(200);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OwnerId).HasColumnName("ownerID");
            entity.Property(e => e.Pan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAN");
            entity.Property(e => e.Pannumber)
                .HasMaxLength(100)
                .HasColumnName("PANnumber");
            entity.Property(e => e.ParentCompanyId).HasColumnName("ParentCompanyID");
            entity.Property(e => e.PaymentTerm)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PaymentTermId).HasColumnName("PaymentTermID");
            entity.Property(e => e.PaymentTermLabel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserDisplayName).HasMaxLength(100);
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCompanyGst>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_companyGST");

            entity.Property(e => e.AddressTypeNick).HasMaxLength(30);
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CompanyAddressId).HasColumnName("CompanyAddressID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CompanyNameAddress).HasMaxLength(100);
            entity.Property(e => e.CompanyTypeName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.DateCreated).HasColumnType("date");
            entity.Property(e => e.DateModified).HasColumnType("date");
            entity.Property(e => e.FormattedAddress).HasMaxLength(500);
            entity.Property(e => e.Gstnumber)
                .HasMaxLength(100)
                .HasColumnName("GSTnumber");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.Pannumber)
                .HasMaxLength(100)
                .HasColumnName("PANnumber");
            entity.Property(e => e.Phone1).HasMaxLength(15);
            entity.Property(e => e.Phone2)
                .HasMaxLength(15)
                .HasColumnName("phone2");
            entity.Property(e => e.StateCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StateName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwCompanyShipmentCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCompanyShipmentCount");

            entity.Property(e => e.Air).HasColumnName("AIR");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Customer)
                .HasMaxLength(100)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.FirstShipmentDate)
                .HasColumnType("datetime")
                .HasColumnName("FIRST SHIPMENT DATE");
            entity.Property(e => e.LastShipmentDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST SHIPMENT DATE");
            entity.Property(e => e.Ocean).HasColumnName("OCEAN");
            entity.Property(e => e.Salesperson)
                .HasMaxLength(100)
                .HasColumnName("SALESPERSON");
        });

        modelBuilder.Entity<VwContainerCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_ContainerCount");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40ot).HasColumnName("40OT");
        });

        modelBuilder.Entity<VwContainerCount2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_ContainerCount2");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._20rf).HasColumnName("20RF");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40hcrf).HasColumnName("40HCRF");
            entity.Property(e => e._40ot).HasColumnName("40OT");
            entity.Property(e => e._40rf).HasColumnName("40RF");
        });

        modelBuilder.Entity<VwContainerCountNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_ContainerCountNEW");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._20rf).HasColumnName("20RF");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40ot).HasColumnName("40OT");
            entity.Property(e => e._40rf).HasColumnName("40RF");
            entity.Property(e => e._45gp).HasColumnName("45GP");
        });

        modelBuilder.Entity<VwContainersPerCargoText>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ContainersPerCargoText");

            entity.Property(e => e.Cargoid).HasColumnName("cargoid");
            entity.Property(e => e.Totalcont)
                .HasMaxLength(396)
                .HasColumnName("totalcont");
        });

        modelBuilder.Entity<VwCsairExportDashboard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CSAirExportDashboard");

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.AirLine).HasMaxLength(60);
            entity.Property(e => e.Awbhandover)
                .HasColumnType("datetime")
                .HasColumnName("AWBHandover");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoSopapprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CargoSOPApprovalStatus");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Cycle)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("CYCLE");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.FlightNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceHandover).HasColumnType("datetime");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OriginAgent).HasMaxLength(100);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlertDate).HasColumnType("datetime");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.TotalGrossWeightKgs)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalGrossWeightKGS");
            entity.Property(e => e.TotalVolWeight).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<VwCsairImportDashboard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CSAirImportDashboard");

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.AirLine).HasMaxLength(60);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoSopapprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CargoSOPApprovalStatus");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Cycle)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("CYCLE");
            entity.Property(e => e.Dosent)
                .HasColumnType("datetime")
                .HasColumnName("DOSent");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.FlightNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceHandover).HasColumnType("datetime");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OriginAgent).HasMaxLength(100);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlertDate).HasColumnType("datetime");
            entity.Property(e => e.Shipper).HasMaxLength(100);
        });

        modelBuilder.Entity<VwCsoceanExportDashboard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CSOceanExportDashboard");

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.Blhandover)
                .HasColumnType("datetime")
                .HasColumnName("BLHandover");
            entity.Property(e => e.BookingNumber).HasMaxLength(30);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoSopapprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CargoSOPApprovalStatus");
            entity.Property(e => e.CargoType)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Cycle)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("CYCLE");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceHandover).HasColumnType("datetime");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OceanLine).HasMaxLength(30);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlertDate).HasColumnType("datetime");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.Sisubmission)
                .HasColumnType("datetime")
                .HasColumnName("SISubmission");
            entity.Property(e => e.Vessel).HasMaxLength(50);
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
        });

        modelBuilder.Entity<VwCsoceanImportDashboard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CSOceanImportDashboard");

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoSopapprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CargoSOPApprovalStatus");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Cycle)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("CYCLE");
            entity.Property(e => e.Dosent)
                .HasColumnType("datetime")
                .HasColumnName("DOSent");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceHandover).HasColumnType("datetime");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ManifestSubmission).HasColumnType("datetime");
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OceanLine).HasMaxLength(30);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OriginAgent).HasMaxLength(100);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlertDate).HasColumnType("datetime");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.Vessel).HasMaxLength(50);
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
        });

        modelBuilder.Entity<VwCustReportAug2020>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CustReport_Aug2020");

            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.JobMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("JOB_MONTH");
            entity.Property(e => e.Jobtype)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("jobtype");
            entity.Property(e => e.OfShipments).HasColumnName("# OF SHIPMENTS");
        });

        modelBuilder.Entity<VwCustomerOwnerList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_customerOwnerList");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.PrimaryOfficeId).HasColumnName("PrimaryOfficeID");
            entity.Property(e => e.UserDisplayName).HasMaxLength(100);
        });

        modelBuilder.Entity<VwCustomerlist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_customerlist");

            entity.Property(e => e.AddressTypeNick).HasMaxLength(30);
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CompanyApprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");
            entity.Property(e => e.CompanyTypeName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.Notes).HasMaxLength(200);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OwnerId).HasColumnName("ownerID");
            entity.Property(e => e.ParentCompanyId).HasColumnName("ParentCompanyID");
            entity.Property(e => e.Phone1).HasMaxLength(15);
            entity.Property(e => e.Phone2).HasMaxLength(15);
            entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDetailsAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DetailsAddress");

            entity.Property(e => e.AddressTypeNick).HasMaxLength(30);
            entity.Property(e => e.CompanyAddressId).HasColumnName("CompanyAddressID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.FormattedAddress).HasMaxLength(500);
        });

        modelBuilder.Entity<VwDsr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR");

            entity.Property(e => e.Booking).HasMaxLength(111);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ConsigneeId).HasColumnName("ConsigneeID");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Invoiceno).HasColumnName("invoiceno");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OceanLine).HasMaxLength(60);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
            entity.Property(e => e.TotalChargeable).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TotalGrossWeightKgs)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalGrossWeightKGS");
            entity.Property(e => e.TotalNetWeightKgs)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalNetWeightKGS");
            entity.Property(e => e.TotalVolWeight).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TotalVolumeCbm)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalVolumeCBM");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Vessel).HasMaxLength(50);
        });

        modelBuilder.Entity<VwDsrAppointment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR_Appointments");

            entity.Property(e => e.AppontmentType).HasMaxLength(20);
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .HasColumnName("AREA");
            entity.Property(e => e.Comments).HasColumnName("COMMENTS");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.Createdby).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Purpose)
                .HasMaxLength(50)
                .HasColumnName("purpose");
            entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("TYPE");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<VwDsrCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR_Companies");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .HasColumnName("AREA");
            entity.Property(e => e.Comments).HasColumnName("COMMENTS");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.Designation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Purpose)
                .HasMaxLength(50)
                .HasColumnName("purpose");
            entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<VwDsrLead>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR_Leads");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .HasColumnName("AREA");
            entity.Property(e => e.Comments).HasColumnName("COMMENTS");
            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Purpose)
                .HasMaxLength(50)
                .HasColumnName("purpose");
            entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<VwDsrMeeting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR_Meetings");

            entity.Property(e => e.AppontmentType).HasMaxLength(20);
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .HasColumnName("AREA");
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.Comments).HasColumnName("COMMENTS");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.CountryName).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Nextstep)
                .HasMaxLength(200)
                .HasColumnName("nextstep");
            entity.Property(e => e.Purpose)
                .HasMaxLength(50)
                .HasColumnName("purpose");
            entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StateName).HasMaxLength(50);
            entity.Property(e => e.Street).HasMaxLength(200);
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("TYPE");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDsrMumbaiAirExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR_MumbaiAirEXPORT");

            entity.Property(e => e.AirCarrierName).HasMaxLength(60);
            entity.Property(e => e.ChWt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CH.WT");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("DESTINATION");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.FlightNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FLIGHT NO.");
            entity.Property(e => e.HawbNo)
                .HasMaxLength(100)
                .HasColumnName("HAWB NO.");
            entity.Property(e => e.IgmInwardDate)
                .HasColumnType("date")
                .HasColumnName("IGM INWARD DATE");
            entity.Property(e => e.IgmNoSublineNo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IGM NO / SUBLINE NO.");
            entity.Property(e => e.JobDate)
                .HasColumnType("date")
                .HasColumnName("JOB DATE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO.");
            entity.Property(e => e.MawbNo)
                .HasMaxLength(100)
                .HasColumnName("MAWB NO.");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.Pkg).HasColumnName("PKG");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<VwDsrMumbaiAirExportPatco>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR_MumbaiAirEXPORT_PATCO");

            entity.Property(e => e.AirCarrierName).HasMaxLength(60);
            entity.Property(e => e.ChWt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CH.WT");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.FlightNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FLIGHT NO.");
            entity.Property(e => e.IgmInwardDate)
                .HasColumnType("date")
                .HasColumnName("IGM INWARD DATE");
            entity.Property(e => e.IgmNoSublineNo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IGM NO / SUBLINE NO.");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO.");
            entity.Property(e => e.Pkg).HasColumnName("PKG");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.ShipperInvoiceNo).HasColumnName("SHIPPER INVOICE NO");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<VwDsrMumbaiAirImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR_MumbaiAirImport");

            entity.Property(e => e.ChWt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CH.WT");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("DESTINATION");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.FlightNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FLIGHT NO.");
            entity.Property(e => e.HawbNo)
                .HasMaxLength(100)
                .HasColumnName("HAWB NO.");
            entity.Property(e => e.IgmInwardDate)
                .HasColumnType("date")
                .HasColumnName("IGM INWARD DATE");
            entity.Property(e => e.IgmNoSublineNo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IGM NO / SUBLINE NO.");
            entity.Property(e => e.JobDate)
                .HasColumnType("date")
                .HasColumnName("JOB DATE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO.");
            entity.Property(e => e.MawbNo)
                .HasMaxLength(100)
                .HasColumnName("MAWB NO.");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.Pkg).HasColumnName("PKG");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<VwDsrMumbaiOceanImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR_MumbaiOceanImport");

            entity.Property(e => e.BookingConfirmation)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMATION");
            entity.Property(e => e.CargoArrivalNoticeSentToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("CARGO ARRIVAL NOTICE SENT TO CUSTOMER");
            entity.Property(e => e.Carrier)
                .HasMaxLength(30)
                .HasColumnName("CARRIER");
            entity.Property(e => e.Cha)
                .HasMaxLength(200)
                .HasColumnName("CHA");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.ContainerPickupFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("CONTAINER PICKUP FROM LINER");
            entity.Property(e => e.CostSheetApprovalLockDate)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET APPROVAL/LOCK DATE");
            entity.Property(e => e.CostSheetHandedOverToAccounts)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET HANDED OVER TO ACCOUNTS");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Customer)
                .HasMaxLength(100)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.DebitNoteReceivedFromAgent)
                .HasColumnType("datetime")
                .HasColumnName("DEBIT NOTE RECEIVED FROM AGENT");
            entity.Property(e => e.DeliveryOrderIssuedToConsigneeCha)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY ORDER ISSUED TO CONSIGNEE/CHA");
            entity.Property(e => e.DestinationAgent)
                .HasMaxLength(100)
                .HasColumnName("DESTINATION AGENT");
            entity.Property(e => e.DraftConfirmationReceivedFromConsignee)
                .HasColumnType("datetime")
                .HasColumnName("DRAFT CONFIRMATION RECEIVED FROM CONSIGNEE");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.FreightInvoiceNo)
                .HasMaxLength(20)
                .HasColumnName("FREIGHT INVOICE NO");
            entity.Property(e => e.Hbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL #");
            entity.Property(e => e.HblDate)
                .HasColumnType("datetime")
                .HasColumnName("HBL DATE");
            entity.Property(e => e.IgmDate)
                .HasColumnType("datetime")
                .HasColumnName("IGM DATE");
            entity.Property(e => e.IgmFilingManfestation)
                .HasColumnType("datetime")
                .HasColumnName("IGM FILING/MANFESTATION");
            entity.Property(e => e.IgmNo)
                .HasMaxLength(50)
                .HasColumnName("IGM NO");
            entity.Property(e => e.InvoiceAmount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INVOICE AMOUNT");
            entity.Property(e => e.InvoiceGenerationDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE GENERATION DATE");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ISSUED TO CUSTOMER");
            entity.Property(e => e.InvoiceTo)
                .HasMaxLength(100)
                .HasColumnName("INVOICE TO");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.LineNo)
                .HasMaxLength(50)
                .HasColumnName("LINE NO");
            entity.Property(e => e.LinerInvoiceReceived)
                .HasColumnType("datetime")
                .HasColumnName("LINER INVOICE RECEIVED");
            entity.Property(e => e.Mbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL #");
            entity.Property(e => e.MblDate)
                .HasColumnType("datetime")
                .HasColumnName("MBL DATE");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlertReceived)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT RECEIVED");
            entity.Property(e => e.PreAlertSentToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO CONSIGNEE");
            entity.Property(e => e.ShippedOnBoard)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPED ON BOARD");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.Vessel)
                .HasMaxLength(50)
                .HasColumnName("VESSEL");
            entity.Property(e => e.VesselArrivalAtDestination)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL ARRIVAL AT DESTINATION");
            entity.Property(e => e.VesselDeparture)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL DEPARTURE");
        });

        modelBuilder.Entity<VwDsrMumbaiOceanImportShort>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR_MumbaiOceanImport_short");

            entity.Property(e => e.Carrier)
                .HasMaxLength(200)
                .HasColumnName("CARRIER");
            entity.Property(e => e.Cbm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CBM");
            entity.Property(e => e.Cfs)
                .HasMaxLength(100)
                .HasColumnName("CFS");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.ContainerNo).HasColumnName("CONTAINER NO");
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("DESTINATION");
            entity.Property(e => e.Destuffing)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DESTUFFING");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.FinalMblNo)
                .HasMaxLength(100)
                .HasColumnName("FINAL MBL NO.");
            entity.Property(e => e.HblNo)
                .HasMaxLength(100)
                .HasColumnName("HBL NO.");
            entity.Property(e => e.IgmInwardDate)
                .HasColumnType("date")
                .HasColumnName("IGM INWARD DATE");
            entity.Property(e => e.IgmNoSublineNo)
                .HasMaxLength(500)
                .HasColumnName("IGM NO / SUBLINE NO.");
            entity.Property(e => e.IgmSplitDate)
                .HasColumnType("date")
                .HasColumnName("IGM SPLIT DATE");
            entity.Property(e => e.JobDate)
                .HasColumnType("date")
                .HasColumnName("JOB DATE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB NO");
            entity.Property(e => e.MblNo)
                .HasMaxLength(100)
                .HasColumnName("MBL NO.");
            entity.Property(e => e.Note)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NOTE");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.Pkg).HasColumnName("PKG");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.TypeOfShipment)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TYPE OF SHIPMENT");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .HasColumnName("VESSEL NAME");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<VwDsrPuneOceanExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR_Pune_Ocean_Export");

            entity.Property(e => e.BlFirstPrintReceivedFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("BL FIRST PRINT RECEIVED FROM LINER");
            entity.Property(e => e.BlIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BL ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingConfirmedByLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMED BY LINER");
            entity.Property(e => e.BookingIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingRequestDocumentsReceivedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST/DOCUMENTS RECEIVED FROM CUSTOMER");
            entity.Property(e => e.BookingRequestToLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST TO LINER");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CarrierAgent).HasMaxLength(200);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ContainerPickedUpByCustomer)
                .HasColumnType("datetime")
                .HasColumnName("CONTAINER PICKED UP BY CUSTOMER");
            entity.Property(e => e.CostSheetApprovalLockDate)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET APPROVAL/LOCK DATE");
            entity.Property(e => e.CostSheetHandedOverToAccounts)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET HANDED OVER TO ACCOUNTS");
            entity.Property(e => e.DebitNoteReceivedFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("DEBIT NOTE RECEIVED FROM LINER");
            entity.Property(e => e.Delivered)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERED");
            entity.Property(e => e.DeliveryOrderSentByDestinationAgent)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY ORDER SENT BY DESTINATION AGENT");
            entity.Property(e => e.DestinationAgent).HasMaxLength(100);
            entity.Property(e => e.DestinationCustomsCleared)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION CUSTOMS CLEARED");
            entity.Property(e => e.DestinationCustomsHold)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION CUSTOMS HOLD");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceGenerationDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE GENERATION DATE");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ISSUED TO CUSTOMER");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Jobdate)
                .HasColumnType("datetime")
                .HasColumnName("JOBDATE");
            entity.Property(e => e.LoadingListSentToLiner)
                .HasColumnType("datetime")
                .HasColumnName("LOADING LIST SENT TO LINER");
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OceanCarrierName).HasMaxLength(30);
            entity.Property(e => e.OriginAgent).HasMaxLength(100);
            entity.Property(e => e.PickedUpByCustomerAgent)
                .HasColumnType("datetime")
                .HasColumnName("PICKED UP BY CUSTOMER / AGENT");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlertSentToAgent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO AGENT");
            entity.Property(e => e.Salesperson).HasMaxLength(100);
            entity.Property(e => e.ShipmentClosed)
                .HasColumnType("datetime")
                .HasColumnName("SHIPMENT CLOSED");
            entity.Property(e => e.ShippedOnBoard)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPED ON BOARD");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.ShipperInvoiceDetails).HasMaxLength(50);
            entity.Property(e => e.SiIssuedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("SI ISSUED FROM CUSTOMER");
            entity.Property(e => e.SiSubmissionToTheLiner)
                .HasColumnType("datetime")
                .HasColumnName("SI SUBMISSION TO THE LINER");
            entity.Property(e => e.User)
                .HasMaxLength(100)
                .HasColumnName("USER");
            entity.Property(e => e.VesselArrivalAtDestination)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL ARRIVAL AT DESTINATION");
            entity.Property(e => e.VesselDeparture)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL DEPARTURE");
            entity.Property(e => e.VesselName).HasMaxLength(50);
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40ot).HasColumnName("40OT");
        });

        modelBuilder.Entity<VwDsrPuneOceanImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR_Pune_Ocean_Import");

            entity.Property(e => e.BlFirstPrintReceivedFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("BL FIRST PRINT RECEIVED FROM LINER");
            entity.Property(e => e.BlIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BL ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingConfirmedByLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMED BY LINER");
            entity.Property(e => e.BookingIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingRequestDocumentsReceivedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST/DOCUMENTS RECEIVED FROM CUSTOMER");
            entity.Property(e => e.BookingRequestToLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST TO LINER");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CarrierAgent).HasMaxLength(200);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ContainerPickedUpByCustomer)
                .HasColumnType("datetime")
                .HasColumnName("CONTAINER PICKED UP BY CUSTOMER");
            entity.Property(e => e.CostSheetApprovalLockDate)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET APPROVAL/LOCK DATE");
            entity.Property(e => e.CostSheetHandedOverToAccounts)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET HANDED OVER TO ACCOUNTS");
            entity.Property(e => e.DebitNoteReceivedFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("DEBIT NOTE RECEIVED FROM LINER");
            entity.Property(e => e.Delivered)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERED");
            entity.Property(e => e.DeliveryOrderSentByDestinationAgent)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY ORDER SENT BY DESTINATION AGENT");
            entity.Property(e => e.DestinationAgent).HasMaxLength(100);
            entity.Property(e => e.DestinationCustomsCleared)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION CUSTOMS CLEARED");
            entity.Property(e => e.DestinationCustomsHold)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION CUSTOMS HOLD");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceGenerationDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE GENERATION DATE");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ISSUED TO CUSTOMER");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Jobdate)
                .HasColumnType("datetime")
                .HasColumnName("JOBDATE");
            entity.Property(e => e.LoadingListSentToLiner)
                .HasColumnType("datetime")
                .HasColumnName("LOADING LIST SENT TO LINER");
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OceanCarrierName).HasMaxLength(30);
            entity.Property(e => e.OriginAgent).HasMaxLength(100);
            entity.Property(e => e.PickedUpByCustomerAgent)
                .HasColumnType("datetime")
                .HasColumnName("PICKED UP BY CUSTOMER / AGENT");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlertSentToAgent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO AGENT");
            entity.Property(e => e.Salesperson).HasMaxLength(100);
            entity.Property(e => e.ShipmentClosed)
                .HasColumnType("datetime")
                .HasColumnName("SHIPMENT CLOSED");
            entity.Property(e => e.ShippedOnBoard)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPED ON BOARD");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.ShipperInvoiceDetails).HasMaxLength(50);
            entity.Property(e => e.SiIssuedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("SI ISSUED FROM CUSTOMER");
            entity.Property(e => e.SiSubmissionToTheLiner)
                .HasColumnType("datetime")
                .HasColumnName("SI SUBMISSION TO THE LINER");
            entity.Property(e => e.User)
                .HasMaxLength(100)
                .HasColumnName("USER");
            entity.Property(e => e.VesselArrivalAtDestination)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL ARRIVAL AT DESTINATION");
            entity.Property(e => e.VesselDeparture)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL DEPARTURE");
            entity.Property(e => e.VesselName).HasMaxLength(50);
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40ot).HasColumnName("40OT");
        });

        modelBuilder.Entity<VwDsrTurkeyOceanExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR_Turkey_Ocean_Export");

            entity.Property(e => e.BlFirstPrintReceivedFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("BL FIRST PRINT RECEIVED FROM LINER");
            entity.Property(e => e.BlIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BL ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingConfirmedByLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMED BY LINER");
            entity.Property(e => e.BookingIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingRequestDocumentsReceivedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST/DOCUMENTS RECEIVED FROM CUSTOMER");
            entity.Property(e => e.BookingRequestToLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST TO LINER");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CarrierAgent).HasMaxLength(200);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ContainerPickedUpByCustomer)
                .HasColumnType("datetime")
                .HasColumnName("CONTAINER PICKED UP BY CUSTOMER");
            entity.Property(e => e.CostSheetApprovalLockDate)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET APPROVAL/LOCK DATE");
            entity.Property(e => e.CostSheetHandedOverToAccounts)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET HANDED OVER TO ACCOUNTS");
            entity.Property(e => e.DebitNoteReceivedFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("DEBIT NOTE RECEIVED FROM LINER");
            entity.Property(e => e.Delivered)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERED");
            entity.Property(e => e.DeliveryOrderSentByDestinationAgent)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY ORDER SENT BY DESTINATION AGENT");
            entity.Property(e => e.DestinationCustomsCleared)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION CUSTOMS CLEARED");
            entity.Property(e => e.DestinationCustomsHold)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION CUSTOMS HOLD");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceGenerationDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE GENERATION DATE");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ISSUED TO CUSTOMER");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Jobdate)
                .HasColumnType("datetime")
                .HasColumnName("JOBDATE");
            entity.Property(e => e.LoadingListSentToLiner)
                .HasColumnType("datetime")
                .HasColumnName("LOADING LIST SENT TO LINER");
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OceanCarrierName).HasMaxLength(30);
            entity.Property(e => e.PickedUpByCustomerAgent)
                .HasColumnType("datetime")
                .HasColumnName("PICKED UP BY CUSTOMER / AGENT");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlertSentToAgent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO AGENT");
            entity.Property(e => e.ShipmentClosed)
                .HasColumnType("datetime")
                .HasColumnName("SHIPMENT CLOSED");
            entity.Property(e => e.ShippedOnBoard)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPED ON BOARD");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.SiIssuedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("SI ISSUED FROM CUSTOMER");
            entity.Property(e => e.SiSubmissionToTheLiner)
                .HasColumnType("datetime")
                .HasColumnName("SI SUBMISSION TO THE LINER");
            entity.Property(e => e.User)
                .HasMaxLength(100)
                .HasColumnName("USER");
            entity.Property(e => e.VesselArrivalAtDestination)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL ARRIVAL AT DESTINATION");
            entity.Property(e => e.VesselDeparture)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL DEPARTURE");
            entity.Property(e => e.VesselName).HasMaxLength(50);
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40ot).HasColumnName("40OT");
        });

        modelBuilder.Entity<VwDsrTurkeyOceanImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DSR_Turkey_Ocean_Import");

            entity.Property(e => e.BlFirstPrintReceivedFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("BL FIRST PRINT RECEIVED FROM LINER");
            entity.Property(e => e.BlIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BL ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingConfirmedByLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMED BY LINER");
            entity.Property(e => e.BookingIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingRequestDocumentsReceivedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST/DOCUMENTS RECEIVED FROM CUSTOMER");
            entity.Property(e => e.BookingRequestToLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST TO LINER");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CarrierAgent).HasMaxLength(200);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ContainerPickedUpByCustomer)
                .HasColumnType("datetime")
                .HasColumnName("CONTAINER PICKED UP BY CUSTOMER");
            entity.Property(e => e.CostSheetApprovalLockDate)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET APPROVAL/LOCK DATE");
            entity.Property(e => e.CostSheetHandedOverToAccounts)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET HANDED OVER TO ACCOUNTS");
            entity.Property(e => e.DebitNoteReceivedFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("DEBIT NOTE RECEIVED FROM LINER");
            entity.Property(e => e.Delivered)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERED");
            entity.Property(e => e.DeliveryOrderSentByDestinationAgent)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY ORDER SENT BY DESTINATION AGENT");
            entity.Property(e => e.DestinationCustomsCleared)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION CUSTOMS CLEARED");
            entity.Property(e => e.DestinationCustomsHold)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION CUSTOMS HOLD");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceGenerationDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE GENERATION DATE");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ISSUED TO CUSTOMER");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Jobdate)
                .HasColumnType("datetime")
                .HasColumnName("JOBDATE");
            entity.Property(e => e.LoadingListSentToLiner)
                .HasColumnType("datetime")
                .HasColumnName("LOADING LIST SENT TO LINER");
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OceanCarrierName).HasMaxLength(30);
            entity.Property(e => e.PickedUpByCustomerAgent)
                .HasColumnType("datetime")
                .HasColumnName("PICKED UP BY CUSTOMER / AGENT");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlertSentToAgent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO AGENT");
            entity.Property(e => e.ShipmentClosed)
                .HasColumnType("datetime")
                .HasColumnName("SHIPMENT CLOSED");
            entity.Property(e => e.ShippedOnBoard)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPED ON BOARD");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.SiIssuedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("SI ISSUED FROM CUSTOMER");
            entity.Property(e => e.SiSubmissionToTheLiner)
                .HasColumnType("datetime")
                .HasColumnName("SI SUBMISSION TO THE LINER");
            entity.Property(e => e.User)
                .HasMaxLength(100)
                .HasColumnName("USER");
            entity.Property(e => e.VesselArrivalAtDestination)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL ARRIVAL AT DESTINATION");
            entity.Property(e => e.VesselDeparture)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL DEPARTURE");
            entity.Property(e => e.VesselName).HasMaxLength(50);
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40ot).HasColumnName("40OT");
        });

        modelBuilder.Entity<VwExpenseChargeNull>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ExpenseChargeNull");

            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChargeItemId).HasColumnName("ChargeItemID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExpectedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.VendorBillId).HasColumnName("VendorBillID");
            entity.Property(e => e.VendorBillLineItemId).HasColumnName("VendorBillLineItemID");
        });

        modelBuilder.Entity<VwFretlogSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_FretlogSummary");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.IsConsolidation).HasColumnName("isConsolidation");
            entity.Property(e => e.JobMonth)
                .HasColumnType("datetime")
                .HasColumnName("JOB_MONTH");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Officename)
                .HasMaxLength(100)
                .HasColumnName("OFFICENAME");
            entity.Property(e => e.TotalChargeable).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TotalGrossWeightKgs)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalGrossWeightKGS");
            entity.Property(e => e.TotalVolumeCbm)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalVolumeCBM");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40ot).HasColumnName("40OT");
        });

        modelBuilder.Entity<VwFyjobsDaily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_FYjobsDaily");

            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.DestinationAgent).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("date");
            entity.Property(e => e.JobCloseDate).HasColumnType("date");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JobOpenDate).HasColumnType("date");
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OriginAgent).HasMaxLength(100);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.SalesPerson)
                .HasMaxLength(100)
                .HasColumnName("sales person");
            entity.Property(e => e.ShipmentType)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.TotalChargeable).HasColumnType("decimal(38, 4)");
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40ot).HasColumnName("40OT");
        });

        modelBuilder.Entity<VwGoodPackXingdaReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GoodPackXingdaReport");

            entity.Property(e => e.Ata)
                .HasColumnType("date")
                .HasColumnName("ATA");
            entity.Property(e => e.Atd)
                .HasColumnType("date")
                .HasColumnName("ATD");
            entity.Property(e => e.Bl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BL");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.Hbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(30);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pallet).HasColumnName("PALLET");
            entity.Property(e => e.Plant)
                .HasMaxLength(100)
                .HasColumnName("PLANT");
            entity.Property(e => e.Seperator).HasColumnName("SEPERATOR");
            entity.Property(e => e.Spools).HasColumnName("SPOOLS");
            entity.Property(e => e._40hc).HasColumnName("40HC");
        });

        modelBuilder.Entity<VwGoodPackXingdaReport1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GoodPackXingdaReport1");

            entity.Property(e => e.Ata)
                .HasColumnType("date")
                .HasColumnName("ATA");
            entity.Property(e => e.Atd)
                .HasColumnType("date")
                .HasColumnName("ATD");
            entity.Property(e => e.Bl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BL");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.Hbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(30);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pallet).HasColumnName("PALLET");
            entity.Property(e => e.Plant)
                .HasMaxLength(100)
                .HasColumnName("PLANT");
            entity.Property(e => e.Seperator).HasColumnName("SEPERATOR");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.Spools).HasColumnName("SPOOLS");
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._20rf).HasColumnName("20RF");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40ot).HasColumnName("40OT");
            entity.Property(e => e._40rf).HasColumnName("40RF");
            entity.Property(e => e._45gp).HasColumnName("45GP");
        });

        modelBuilder.Entity<VwGstCalculation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_gstCalculation");

            entity.Property(e => e.CgstAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CgstRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IgstAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IgstRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceLineItemId).HasColumnName("InvoiceLineItemID");
            entity.Property(e => e.SgstAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SgstRate).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VwGstinvoicelineitemsAug2017>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_GSTINVOICELINEITEMS_AUG2017");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceTypeGst)
                .HasMaxLength(100)
                .HasColumnName("invoiceTypeGst");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ServiceCode).HasMaxLength(100);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.Taxamount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAXAMOUNT");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(21, 4)");
        });

        modelBuilder.Entity<VwGstinvoicelineitemsJuly2017>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_GSTINVOICELINEITEMS_JULY2017");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceTypeGst)
                .HasMaxLength(100)
                .HasColumnName("invoiceTypeGst");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ServiceCode).HasMaxLength(100);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.Taxamount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAXAMOUNT");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(21, 4)");
        });

        modelBuilder.Entity<VwGstinvoicesummaryAug2017>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_GSTINVOICESUMMARY_AUG2017");

            entity.Property(e => e.Amount).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Gstnumber)
                .HasMaxLength(100)
                .HasColumnName("GSTnumber");
            entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceTypeGst)
                .HasMaxLength(100)
                .HasColumnName("invoiceTypeGst");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PayingParty).HasMaxLength(100);
            entity.Property(e => e.PayingPartyAddress).HasMaxLength(4000);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<VwGstinvoicesummaryJuly2017>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_GSTINVOICESUMMARY_JULY2017");

            entity.Property(e => e.Amount).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Gstnumber)
                .HasMaxLength(100)
                .HasColumnName("GSTnumber");
            entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceTypeGst)
                .HasMaxLength(100)
                .HasColumnName("invoiceTypeGst");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PayingParty).HasMaxLength(100);
            entity.Property(e => e.PayingPartyAddress).HasMaxLength(4000);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<VwHandlingCharge>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_HandlingCharges");

            entity.Property(e => e.AirlineTerminalHandlingCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AIRLINE TERMINAL HANDLING CHARGES");
            entity.Property(e => e.AirportHandlingCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AIRPORT HANDLING CHARGES");
            entity.Property(e => e.Cargoid).HasColumnName("CARGOID");
            entity.Property(e => e.Handling)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HANDLING");
            entity.Property(e => e.HandlingAgentFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HANDLING AGENT FEE");
            entity.Property(e => e.HandlingCharge)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HANDLING CHARGE");
            entity.Property(e => e.HandlingCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HANDLING CHARGES");
            entity.Property(e => e.HandlingChargesOld)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HANDLING CHARGES - OLD");
            entity.Property(e => e.HandlingFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HANDLING FEE");
            entity.Property(e => e.HandlingFeeSE)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HANDLING FEE S.E ");
            entity.Property(e => e.HandlingOld)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HANDLING - OLD");
            entity.Property(e => e.PortHandlingCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PORT HANDLING CHARGES");
            entity.Property(e => e.ProcessingMessengerHandlingFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PROCESSING,MESSENGER,HANDLING FEE");
            entity.Property(e => e.TerminalHandlingCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TERMINAL HANDLING CHARGES");
            entity.Property(e => e.TerminalHandlingChargesOld)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TERMINAL HANDLING CHARGES - OLD");
            entity.Property(e => e.TerminalHandlingChgsSe)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TERMINAL HANDLING CHGS - SE");
        });

        modelBuilder.Entity<VwInvoiceList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_InvoiceList");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CostSheetId).HasColumnName("CostSheetID");
            entity.Property(e => e.CreditDays).HasMaxLength(20);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.Cycle)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateLocked).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.EducationCess).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExchangeRateId).HasColumnName("ExchangeRateID");
            entity.Property(e => e.FinalDestination).HasMaxLength(50);
            entity.Property(e => e.FlightDetails).HasMaxLength(50);
            entity.Property(e => e.FreightStatus).HasMaxLength(20);
            entity.Property(e => e.HblHawb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL_HAWB");
            entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceAmountLocalCurrency).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceAmountWords).HasMaxLength(200);
            entity.Property(e => e.InvoiceApprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.IsSentToParty).HasColumnName("isSentToParty");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LocalCurrencyId).HasColumnName("LocalCurrencyID");
            entity.Property(e => e.MblMawb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL_MAWB");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NonTaxableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Notes1).HasMaxLength(200);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.PayingParty).HasMaxLength(100);
            entity.Property(e => e.PayingPartyAddress).HasMaxLength(300);
            entity.Property(e => e.PayingPartyAddressId).HasColumnName("PayingPartyAddressID");
            entity.Property(e => e.PayingPartyId).HasColumnName("PayingPartyID");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shecess)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SHECess");
            entity.Property(e => e.ShipperInvoiceDetails).HasMaxLength(50);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxAmountLocalCurrency).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VesselVoyage).HasMaxLength(50);
        });

        modelBuilder.Entity<VwInvoiceTaxBreakup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_InvoiceTaxBreakup");

            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GstAmount)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("GST_AMOUNT");
            entity.Property(e => e.GstRate)
                .HasColumnType("numeric(2, 1)")
                .HasColumnName("GST_RATE");
            entity.Property(e => e.GstTaxCode)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("GST_TAX_CODE");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.TaxableAmount)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("TAXABLE_AMOUNT");
        });

        modelBuilder.Entity<VwJobActivityByOffice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwJobActivityByOffice");

            entity.Property(e => e.JobCount).HasColumnName("JOB_COUNT");
            entity.Property(e => e.Jobtype)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("JOBTYPE");
            entity.Property(e => e.Modeoftransport)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODEOFTRANSPORT");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.Transportdirection)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TRANSPORTDIRECTION");
        });

        modelBuilder.Entity<VwJobAdditionalDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_jobAdditionalDetails");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Cfs).HasColumnName("CFS");
            entity.Property(e => e.Cha).HasColumnName("CHA");
            entity.Property(e => e.FinalMblMawbNo).HasColumnName("FINAL MBL/MAWB NO");
            entity.Property(e => e.IgmNoSublineNo).HasColumnName("IGM NO/ SUBLINE NO");
            entity.Property(e => e.IgmSentOn).HasColumnName("IGM SENT ON");
            entity.Property(e => e.Remarks).HasColumnName("REMARKS");
            entity.Property(e => e.SurrenderBlReceivedDate).HasColumnName("SURRENDER BL RECEIVED DATE");
        });

        modelBuilder.Entity<VwLeadSalesReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_LeadSalesReport");

            entity.Property(e => e.Address)
                .HasMaxLength(353)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Area)
                .HasMaxLength(30)
                .HasColumnName("AREA");
            entity.Property(e => e.AttendedBy)
                .HasMaxLength(100)
                .HasColumnName("ATTENDED_BY");
            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.ContactName)
                .HasMaxLength(61)
                .HasColumnName("CONTACT_NAME");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CONTACT_NO");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Enquiry)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ENQUIRY");
            entity.Property(e => e.FolloupDate)
                .HasColumnType("datetime")
                .HasColumnName("FOLLOUP_DATE");
            entity.Property(e => e.Met)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("MET");
            entity.Property(e => e.PrimaryOfficeId).HasColumnName("PrimaryOfficeID");
            entity.Property(e => e.ProfileSent)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PROFILE_SENT");
            entity.Property(e => e.Quote)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("QUOTE");
            entity.Property(e => e.RemarksStatus)
                .HasMaxLength(200)
                .HasColumnName("REMARKS_STATUS");
            entity.Property(e => e.ResonNotSecured).HasMaxLength(500);
            entity.Property(e => e.SalesPerson)
                .HasMaxLength(100)
                .HasColumnName("SALES_PERSON");
            entity.Property(e => e.Sector).HasMaxLength(500);
            entity.Property(e => e.Secured)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Shipments)
                .HasMaxLength(100)
                .HasColumnName("SHIPMENTS");
        });

        modelBuilder.Entity<VwLinerReportExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_LinerReportEXPORT");

            entity.Property(e => e.AmtInInr)
                .HasColumnType("numeric(2, 2)")
                .HasColumnName("Amt in INR");
            entity.Property(e => e.AmtInUsd)
                .HasColumnType("numeric(2, 2)")
                .HasColumnName("Amt in USD");
            entity.Property(e => e.BlNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BL No");
            entity.Property(e => e.BookingNo)
                .HasMaxLength(60)
                .HasColumnName("Booking No");
            entity.Property(e => e.Brokerage)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Brokerage %");
            entity.Property(e => e.ExRate)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Ex-Rate");
            entity.Property(e => e.FrtInvoiceSettledOn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Frt Invoice settled on");
            entity.Property(e => e.NetFreightInUsdPp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Net Freight-in USD-PP");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.SailedOn)
                .HasColumnType("date")
                .HasColumnName("Sailed on");
            entity.Property(e => e.Trade)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Vessel).HasMaxLength(50);
            entity.Property(e => e.Voyage).HasMaxLength(10);
        });

        modelBuilder.Entity<VwMumAirDsr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MumAirDSR");

            entity.Property(e => e.AirCarrierName).HasMaxLength(60);
            entity.Property(e => e.AwbDraft)
                .HasColumnType("datetime")
                .HasColumnName("AWB Draft");
            entity.Property(e => e.AwbIssuedByLiner)
                .HasColumnType("datetime")
                .HasColumnName("AWB Issued by Liner");
            entity.Property(e => e.AwbIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("AWB Issued to Customer");
            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.BookingIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("Booking Issued to Customer");
            entity.Property(e => e.BookingNumber).HasMaxLength(60);
            entity.Property(e => e.BookingRequestReceived)
                .HasColumnType("datetime")
                .HasColumnName("Booking Request Received");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.CostSheetApproval)
                .HasColumnType("datetime")
                .HasColumnName("Cost Sheet Approval");
            entity.Property(e => e.CustomDocumentsHandover)
                .HasColumnType("datetime")
                .HasColumnName("Custom Documents HAndover");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Delivered).HasColumnType("datetime");
            entity.Property(e => e.DocumentHandover)
                .HasColumnType("datetime")
                .HasColumnName("Document Handover");
            entity.Property(e => e.Draft)
                .HasColumnType("datetime")
                .HasColumnName("DRAFT");
            entity.Property(e => e.EpCopyHandover)
                .HasColumnType("datetime")
                .HasColumnName("EP Copy Handover");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.FlightDeparture)
                .HasColumnType("datetime")
                .HasColumnName("Flight Departure");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceGeneration)
                .HasColumnType("datetime")
                .HasColumnName("Invoice Generation");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("Invoice Issued to Customer");
            entity.Property(e => e.InvoiceSentToAgent)
                .HasColumnType("datetime")
                .HasColumnName("Invoice Sent to Agent");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlertSent)
                .HasColumnType("datetime")
                .HasColumnName("Pre-Alert Sent");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.User)
                .HasMaxLength(100)
                .HasColumnName("USER");
        });

        modelBuilder.Entity<VwOceanDocumentsStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_OceanDocumentsStatus");

            entity.Property(e => e.AgentHbl)
                .HasMaxLength(20)
                .HasColumnName("AGENT HBL");
            entity.Property(e => e.AgentMbl)
                .HasMaxLength(20)
                .HasColumnName("AGENT MBL");
            entity.Property(e => e.ArrivalNotice)
                .HasMaxLength(20)
                .HasColumnName("ARRIVAL NOTICE");
            entity.Property(e => e.BlFirstPrint)
                .HasMaxLength(20)
                .HasColumnName("BL - FIRST PRINT");
            entity.Property(e => e.BlInstructions)
                .HasMaxLength(20)
                .HasColumnName("BL INSTRUCTIONS");
            entity.Property(e => e.BookingCopy)
                .HasMaxLength(20)
                .HasColumnName("BOOKING COPY");
            entity.Property(e => e.Can)
                .HasMaxLength(20)
                .HasColumnName("CAN");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CertificateOfInsurance)
                .HasMaxLength(20)
                .HasColumnName("CERTIFICATE OF INSURANCE");
            entity.Property(e => e.CertificateOfOrigin)
                .HasMaxLength(20)
                .HasColumnName("CERTIFICATE OF ORIGIN");
            entity.Property(e => e.CommercialInvoice)
                .HasMaxLength(20)
                .HasColumnName("COMMERCIAL INVOICE");
            entity.Property(e => e.DebitNote)
                .HasMaxLength(20)
                .HasColumnName("DEBIT NOTE");
            entity.Property(e => e.DgDeclaration)
                .HasMaxLength(20)
                .HasColumnName("DG DECLARATION");
            entity.Property(e => e.Do)
                .HasMaxLength(20)
                .HasColumnName("DO");
            entity.Property(e => e.EnsDeclaration)
                .HasMaxLength(20)
                .HasColumnName("ENS DECLARATION");
            entity.Property(e => e.EpCopy)
                .HasMaxLength(20)
                .HasColumnName("EP COPY");
            entity.Property(e => e.FreightInvoice)
                .HasMaxLength(20)
                .HasColumnName("FREIGHT INVOICE");
            entity.Property(e => e.Hbl)
                .HasMaxLength(20)
                .HasColumnName("HBL");
            entity.Property(e => e.Iip)
                .HasMaxLength(20)
                .HasColumnName("IIP");
            entity.Property(e => e.Invoice)
                .HasMaxLength(20)
                .HasColumnName("INVOICE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LcCopy)
                .HasMaxLength(20)
                .HasColumnName("LC COPY");
            entity.Property(e => e.Mbl)
                .HasMaxLength(20)
                .HasColumnName("MBL");
            entity.Property(e => e.Msds)
                .HasMaxLength(20)
                .HasColumnName("MSDS");
            entity.Property(e => e.PackingList)
                .HasMaxLength(20)
                .HasColumnName("PACKING LIST");
            entity.Property(e => e.PreAlert)
                .HasMaxLength(20)
                .HasColumnName("PRE ALERT");
            entity.Property(e => e.ShippingBill)
                .HasMaxLength(20)
                .HasColumnName("SHIPPING BILL");
            entity.Property(e => e.Sop)
                .HasMaxLength(20)
                .HasColumnName("SOP");
            entity.Property(e => e.TransportBill)
                .HasMaxLength(20)
                .HasColumnName("TRANSPORT BILL");
            entity.Property(e => e.VendorBill)
                .HasMaxLength(20)
                .HasColumnName("VENDOR BILL");
        });

        modelBuilder.Entity<VwOceanExportStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_OceanExportStatus");

            entity.Property(e => e.ArrivedAtDestination)
                .HasColumnType("datetime")
                .HasColumnName("Arrived at Destination");
            entity.Property(e => e.BlFirstPrint)
                .HasColumnType("datetime")
                .HasColumnName("BL First Print");
            entity.Property(e => e.BlIssuedByLiner)
                .HasColumnType("datetime")
                .HasColumnName("BL Issued by Liner");
            entity.Property(e => e.BlIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BL Issued to Customer");
            entity.Property(e => e.BookingConfirmed)
                .HasColumnType("datetime")
                .HasColumnName("Booking Confirmed");
            entity.Property(e => e.BookingRequestReceived)
                .HasColumnType("datetime")
                .HasColumnName("Booking Request Received");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ContainerPickedUp)
                .HasColumnType("datetime")
                .HasColumnName("Container Picked Up");
            entity.Property(e => e.CostSheetApproval)
                .HasColumnType("datetime")
                .HasColumnName("Cost Sheet Approval");
            entity.Property(e => e.CustomsDocumentHandover)
                .HasColumnType("datetime")
                .HasColumnName("Customs Document Handover");
            entity.Property(e => e.Delivered).HasColumnType("datetime");
            entity.Property(e => e.DestinationCustomsCleared)
                .HasColumnType("datetime")
                .HasColumnName("Destination Customs Cleared");
            entity.Property(e => e.DestinationCustomsHold)
                .HasColumnType("datetime")
                .HasColumnName("Destination Customs Hold");
            entity.Property(e => e.DoSent)
                .HasColumnType("datetime")
                .HasColumnName("DO Sent");
            entity.Property(e => e.DocumentHandover)
                .HasColumnType("datetime")
                .HasColumnName("Document Handover");
            entity.Property(e => e.Draft)
                .HasColumnType("datetime")
                .HasColumnName("DRAFT");
            entity.Property(e => e.EpCopyHandover)
                .HasColumnType("datetime")
                .HasColumnName("EP Copy Handover");
            entity.Property(e => e.InTransitToOriginPort)
                .HasColumnType("datetime")
                .HasColumnName("In Transit to Origin Port");
            entity.Property(e => e.InvoiceGeneration)
                .HasColumnType("datetime")
                .HasColumnName("Invoice Generation");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("Invoice Issued to Customer");
            entity.Property(e => e.LoadingList)
                .HasColumnType("datetime")
                .HasColumnName("Loading List");
            entity.Property(e => e.ManifestSubmitted)
                .HasColumnType("datetime")
                .HasColumnName("Manifest Submitted");
            entity.Property(e => e.PickedUpByCustomerAgent)
                .HasColumnType("datetime")
                .HasColumnName("Picked up by Customer/Agent");
            entity.Property(e => e.PreAlertSent)
                .HasColumnType("datetime")
                .HasColumnName("Pre-Alert Sent");
            entity.Property(e => e.ShippedOnBoard)
                .HasColumnType("datetime")
                .HasColumnName("Shipped On Board");
            entity.Property(e => e.SiFormatReceiptFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("SI Format Receipt from Customer");
            entity.Property(e => e.SiSubmissionToLiner)
                .HasColumnType("datetime")
                .HasColumnName("SI Submission to Liner");
            entity.Property(e => e.VesselDeparture)
                .HasColumnType("datetime")
                .HasColumnName("Vessel Departure");
        });

        modelBuilder.Entity<VwOceanImportDocumentsStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_OceanImportDocumentsStatus");

            entity.Property(e => e.Can)
                .HasMaxLength(20)
                .HasColumnName("CAN");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CommercialInvoice)
                .HasMaxLength(20)
                .HasColumnName("COMMERCIAL INVOICE");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("CONSIGNEE");
            entity.Property(e => e.DebitNote)
                .HasMaxLength(20)
                .HasColumnName("DEBIT NOTE");
            entity.Property(e => e.Do)
                .HasMaxLength(20)
                .HasColumnName("DO");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.Hbl)
                .HasMaxLength(20)
                .HasColumnName("HBL");
            entity.Property(e => e.Invoice)
                .HasMaxLength(20)
                .HasColumnName("INVOICE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mbl)
                .HasMaxLength(20)
                .HasColumnName("MBL");
            entity.Property(e => e.PackingList)
                .HasMaxLength(20)
                .HasColumnName("PACKING LIST");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.Sop)
                .HasMaxLength(20)
                .HasColumnName("SOP");
            entity.Property(e => e.TransportBill)
                .HasMaxLength(20)
                .HasColumnName("TRANSPORT BILL");
            entity.Property(e => e.VendorBill)
                .HasMaxLength(20)
                .HasColumnName("VENDOR BILL");
        });

        modelBuilder.Entity<VwOpportunity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_opportunities");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CargoType).HasMaxLength(30);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.Mode).HasMaxLength(30);
            entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");
            entity.Property(e => e.OpportunityName).HasMaxLength(50);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwPatcoAirDsr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_PATCO_AirDSR");

            entity.Property(e => e.Airline).HasMaxLength(60);
            entity.Property(e => e.AirwayBillNo)
                .HasMaxLength(100)
                .HasColumnName("AIRWAY BILL NO.");
            entity.Property(e => e.ChWt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CH.WT");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.DeliveryDt)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY DT");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .HasColumnName("REMARKS");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.ShipperInvoiceNo).HasMaxLength(30);
            entity.Property(e => e.Status)
                .HasMaxLength(1000)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<VwPatcoOceanDsr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_PATCO_OceanDSR");

            entity.Property(e => e.BookingNumber).HasMaxLength(30);
            entity.Property(e => e.CargoStatus)
                .HasMaxLength(255)
                .HasColumnName("CARGO_STATUS");
            entity.Property(e => e.Cbm)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("CBM");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ContainerNumber).HasMaxLength(15);
            entity.Property(e => e.DeliveryDt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DELIVERY DT");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(4000)
                .HasColumnName("POL");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .HasColumnName("REMARKS");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.ShipperInvoiceNo).HasMaxLength(30);
            entity.Property(e => e.ShippingLine).HasMaxLength(30);
            entity.Property(e => e.Vessel)
                .HasMaxLength(61)
                .HasColumnName("VESSEL");
        });

        modelBuilder.Entity<VwPolyrubShipment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_polyrubShipments");

            entity.Property(e => e.AirFreight)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("AIR FREIGHT");
            entity.Property(e => e.CustomDuty)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("CUSTOM DUTY");
            entity.Property(e => e.FreightOtherComponent)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("FREIGHT (OTHER COMPONENT)");
            entity.Property(e => e.GrossProfit)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Gross Profit");
            entity.Property(e => e.HandlingCharges)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("HANDLING CHARGES");
            entity.Property(e => e.Job)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOB #");
            entity.Property(e => e.OtherCharges)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("OTHER CHARGES");
            entity.Property(e => e.Rebate)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("REBATE");
            entity.Property(e => e.TotalBuy)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Total Buy");
            entity.Property(e => e.TotalSell)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Total Sell");
        });

        modelBuilder.Entity<VwProductwiseShipmentCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwProductwiseShipmentCount");

            entity.Property(e => e.AirExport).HasColumnName("AIR-EXPORT");
            entity.Property(e => e.AirImport).HasColumnName("AIR-IMPORT");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Customer)
                .HasMaxLength(100)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.FirstShipmentDate)
                .HasColumnType("datetime")
                .HasColumnName("FIRST SHIPMENT DATE");
            entity.Property(e => e.LastShipmentDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST SHIPMENT DATE");
            entity.Property(e => e.OceanExport).HasColumnName("OCEAN-EXPORT");
            entity.Property(e => e.OceanImport).HasColumnName("OCEAN-IMPORT");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.Salesperson)
                .HasMaxLength(100)
                .HasColumnName("SALESPERSON");
        });

        modelBuilder.Entity<VwProductwiseShipmentCountChn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwProductwiseShipmentCount_CHN");

            entity.Property(e => e.AirExport).HasColumnName("AIR-EXPORT");
            entity.Property(e => e.AirImport).HasColumnName("AIR-IMPORT");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Customer)
                .HasMaxLength(100)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.FirstShipmentDate)
                .HasColumnType("datetime")
                .HasColumnName("FIRST SHIPMENT DATE");
            entity.Property(e => e.LastShipmentDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST SHIPMENT DATE");
            entity.Property(e => e.OceanExport).HasColumnName("OCEAN-EXPORT");
            entity.Property(e => e.OceanImport).HasColumnName("OCEAN-IMPORT");
            entity.Property(e => e.Salesperson)
                .HasMaxLength(100)
                .HasColumnName("SALESPERSON");
        });

        modelBuilder.Entity<VwProductwiseShipmentCountLastyear>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwProductwiseShipmentCount_LASTYEAR");

            entity.Property(e => e.AirExport).HasColumnName("AIR-EXPORT");
            entity.Property(e => e.AirImport).HasColumnName("AIR-IMPORT");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Customer)
                .HasMaxLength(100)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.FirstShipmentDate).HasColumnName("FIRST SHIPMENT DATE");
            entity.Property(e => e.LastShipmentDate).HasColumnName("LAST SHIPMENT DATE");
            entity.Property(e => e.OceanExport).HasColumnName("OCEAN-EXPORT");
            entity.Property(e => e.OceanImport).HasColumnName("OCEAN-IMPORT");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.Salesperson)
                .HasMaxLength(100)
                .HasColumnName("SALESPERSON");
        });

        modelBuilder.Entity<VwProfitLossStatement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwProfitLossStatement");

            entity.Property(e => e.Account)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.BillToName).HasMaxLength(100);
            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EurAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EUR_AMOUNT");
            entity.Property(e => e.GbpAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GBP_AMOUNT");
            entity.Property(e => e.HblHawb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL_HAWB");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.IciExrate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ICI_EXRate");
            entity.Property(e => e.InvoiceCurrency)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Jobnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOBNUMBER");
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MblMawb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL_MAWB");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ShipmentNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalAmountLocalCurrency).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalSelectedCurrency).HasColumnType("decimal(37, 8)");
            entity.Property(e => e.TotalWithoutTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalWithoutTAX");
            entity.Property(e => e.TryAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TRY_AMOUNT");
            entity.Property(e => e.UsdAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("USD_AMOUNT");
        });

        modelBuilder.Entity<VwProfitPerJob>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ProfitPerJob");

            entity.Property(e => e.CargoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CargoID");
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CargoSopapprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CargoSOPApprovalStatus");
            entity.Property(e => e.Expense)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("EXPENSE");
            entity.Property(e => e.Income)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("INCOME");
            entity.Property(e => e.Profit)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("profit");
        });

        modelBuilder.Entity<VwProfitPerJobNonTax>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ProfitPerJob_nonTax");

            entity.Property(e => e.CargoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CargoID");
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CargoSopapprovalStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CargoSOPApprovalStatus");
            entity.Property(e => e.Expense)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("EXPENSE");
            entity.Property(e => e.Income)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("INCOME");
            entity.Property(e => e.Profit)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("profit");
        });

        modelBuilder.Entity<VwProfitPerJobTurkey>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ProfitPerJobTurkey");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Costsheetstatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COSTSHEETSTATUS");
            entity.Property(e => e.Costsheettype)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COSTSHEETTYPE");
            entity.Property(e => e.ExpenseEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_EUR");
            entity.Property(e => e.ExpenseTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("EXPENSE_TL");
            entity.Property(e => e.ExpenseUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_USD");
            entity.Property(e => e.IncomeEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_EUR");
            entity.Property(e => e.IncomeTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("INCOME_TL");
            entity.Property(e => e.IncomeUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_USD");
            entity.Property(e => e.ProfitEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PROFIT_EUR");
            entity.Property(e => e.ProfitTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("PROFIT_TL");
            entity.Property(e => e.ProfitUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PROFIT_USD");
        });

        modelBuilder.Entity<VwProfitPerJobTurkeyKdv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ProfitPerJobTurkeyKDV");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Costsheetstatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COSTSHEETSTATUS");
            entity.Property(e => e.Costsheettype)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COSTSHEETTYPE");
            entity.Property(e => e.ExpenseEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_EUR");
            entity.Property(e => e.ExpenseEurKdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_EUR_KDV");
            entity.Property(e => e.ExpenseKdvTl)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("EXPENSE_KDV_TL");
            entity.Property(e => e.ExpenseTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("EXPENSE_TL");
            entity.Property(e => e.ExpenseUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_USD");
            entity.Property(e => e.ExpenseUsdKdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_USD_KDV");
            entity.Property(e => e.IncomeEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_EUR");
            entity.Property(e => e.IncomeEurKdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_EUR_KDV");
            entity.Property(e => e.IncomeKdvTl)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("INCOME_KDV_TL");
            entity.Property(e => e.IncomeTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("INCOME_TL");
            entity.Property(e => e.IncomeUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_USD");
            entity.Property(e => e.IncomeUsdKdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_USD_KDV");
            entity.Property(e => e.ProfitEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PROFIT_EUR");
            entity.Property(e => e.ProfitTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("PROFIT_TL");
            entity.Property(e => e.ProfitUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PROFIT_USD");
        });

        modelBuilder.Entity<VwProfitPerJobTurkeyKdv1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ProfitPerJobTurkeyKDV1");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Costsheetstatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COSTSHEETSTATUS");
            entity.Property(e => e.Costsheettype)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COSTSHEETTYPE");
            entity.Property(e => e.ExpenseEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_EUR");
            entity.Property(e => e.ExpenseEurKdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_EUR_KDV");
            entity.Property(e => e.ExpenseKdvTl)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("EXPENSE_KDV_TL");
            entity.Property(e => e.ExpenseTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("EXPENSE_TL");
            entity.Property(e => e.ExpenseUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_USD");
            entity.Property(e => e.ExpenseUsdKdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_USD_KDV");
            entity.Property(e => e.IncomeEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_EUR");
            entity.Property(e => e.IncomeEurKdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_EUR_KDV");
            entity.Property(e => e.IncomeKdvTl)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("INCOME_KDV_TL");
            entity.Property(e => e.IncomeTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("INCOME_TL");
            entity.Property(e => e.IncomeUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_USD");
            entity.Property(e => e.IncomeUsdKdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_USD_KDV");
            entity.Property(e => e.ProfitEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PROFIT_EUR");
            entity.Property(e => e.ProfitTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("PROFIT_TL");
            entity.Property(e => e.ProfitUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PROFIT_USD");
        });

        modelBuilder.Entity<VwProfitPerJobTurkeyKdvSq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ProfitPerJobTurkeyKDV_SQ");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Costsheetstatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COSTSHEETSTATUS");
            entity.Property(e => e.Costsheettype)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COSTSHEETTYPE");
            entity.Property(e => e.ExpenseEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_EUR");
            entity.Property(e => e.ExpenseEurKdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_EUR_KDV");
            entity.Property(e => e.ExpenseKdvTl)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("EXPENSE_KDV_TL");
            entity.Property(e => e.ExpenseTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("EXPENSE_TL");
            entity.Property(e => e.ExpenseUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_USD");
            entity.Property(e => e.ExpenseUsdKdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_USD_KDV");
            entity.Property(e => e.IncomeEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_EUR");
            entity.Property(e => e.IncomeEurKdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_EUR_KDV");
            entity.Property(e => e.IncomeKdvTl)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("INCOME_KDV_TL");
            entity.Property(e => e.IncomeTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("INCOME_TL");
            entity.Property(e => e.IncomeUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_USD");
            entity.Property(e => e.IncomeUsdKdv)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_USD_KDV");
            entity.Property(e => e.ProfitEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PROFIT_EUR");
            entity.Property(e => e.ProfitTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("PROFIT_TL");
            entity.Property(e => e.ProfitUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PROFIT_USD");
        });

        modelBuilder.Entity<VwPuneAirExportDsr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_PuneAirExportDSR");

            entity.Property(e => e.AwbDraftIssuedToShipperCha)
                .HasColumnType("datetime")
                .HasColumnName("AWB DRAFT ISSUED TO SHIPPER/CHA");
            entity.Property(e => e.AwbHawbSentToShipperCha)
                .HasColumnType("datetime")
                .HasColumnName("AWB/HAWB SENT TO SHIPPER/CHA");
            entity.Property(e => e.BookingConfirmedByAirLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMED BY AIR LINER");
            entity.Property(e => e.BookingIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingRequestDocumentsReceivedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST/DOCUMENTS RECEIVED FROM CUSTOMER");
            entity.Property(e => e.BookingRequestToAirLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST TO AIR LINER");
            entity.Property(e => e.CargoCustomCleared)
                .HasColumnType("datetime")
                .HasColumnName("CARGO CUSTOM CLEARED");
            entity.Property(e => e.CargoDelivered)
                .HasColumnType("datetime")
                .HasColumnName("CARGO DELIVERED");
            entity.Property(e => e.CargoGatedInByCha)
                .HasColumnType("datetime")
                .HasColumnName("CARGO GATED IN BY CHA");
            entity.Property(e => e.CargoHandedOverToAirline)
                .HasColumnType("datetime")
                .HasColumnName("CARGO HANDED OVER TO AIRLINE");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.CostSheetApprovalLockDate)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET APPROVAL/LOCK DATE");
            entity.Property(e => e.CostSheetHandedOverToAccounts)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET HANDED OVER TO ACCOUNTS");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.FlightArrivalAtDestination)
                .HasColumnType("datetime")
                .HasColumnName("FLIGHT ARRIVAL AT DESTINATION");
            entity.Property(e => e.FlightDeparture)
                .HasColumnType("datetime")
                .HasColumnName("FLIGHT DEPARTURE");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceGenerationDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE GENERATION DATE");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ISSUED TO CUSTOMER");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlertSentToDestinationAgent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO DESTINATION AGENT");
            entity.Property(e => e.ProofOfDeliveryFromAgent)
                .HasColumnType("datetime")
                .HasColumnName("PROOF OF DELIVERY FROM AGENT");
            entity.Property(e => e.Salesperson).HasMaxLength(100);
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.ShipperInvoiceDetails).HasMaxLength(50);
            entity.Property(e => e.ShippingInstructionsIssuedByCha)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPING INSTRUCTIONS ISSUED BY CHA");
            entity.Property(e => e.User)
                .HasMaxLength(100)
                .HasColumnName("USER");
        });

        modelBuilder.Entity<VwPuneAirImportDsr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_PuneAirImportDSR");

            entity.Property(e => e.AirlineBbAgentInvoiceReceived)
                .HasColumnType("datetime")
                .HasColumnName("AIRLINE/BB AGENT INVOICE RECEIVED");
            entity.Property(e => e.CargoArrivalNotice)
                .HasColumnType("datetime")
                .HasColumnName("CARGO ARRIVAL NOTICE");
            entity.Property(e => e.CargoBookingDate)
                .HasColumnType("datetime")
                .HasColumnName("CARGO BOOKING DATE");
            entity.Property(e => e.CargoDeliveredToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("CARGO DELIVERED TO CUSTOMER");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoPickupDate)
                .HasColumnType("datetime")
                .HasColumnName("CARGO PICKUP DATE");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.CostSheetApprovalLockDate)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET APPROVAL/LOCK DATE");
            entity.Property(e => e.CostSheetHandedOverToAccounts)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET HANDED OVER TO ACCOUNTS");
            entity.Property(e => e.DeliveryOrderIssuedToConsigneeCha)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY ORDER ISSUED TO CONSIGNEE/CHA");
            entity.Property(e => e.DocumentsCouriedToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("DOCUMENTS COURIED TO CONSIGNEE");
            entity.Property(e => e.DocumentsReceivedAck)
                .HasColumnType("datetime")
                .HasColumnName("DOCUMENTS RECEIVED ACK");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.FlightArrival)
                .HasColumnType("datetime")
                .HasColumnName("FLIGHT ARRIVAL");
            entity.Property(e => e.FlightDepartureDate)
                .HasColumnType("datetime")
                .HasColumnName("FLIGHT DEPARTURE DATE");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.IgmFilingDate)
                .HasColumnType("datetime")
                .HasColumnName("IGM FILING DATE");
            entity.Property(e => e.InvoiceGenerationDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE GENERATION DATE");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ISSUED TO CUSTOMER");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.NominationInformedToOverseasAgent)
                .HasColumnType("datetime")
                .HasColumnName("NOMINATION INFORMED TO OVERSEAS AGENT");
            entity.Property(e => e.NominationReceivedFromConsignee)
                .HasColumnType("datetime")
                .HasColumnName("NOMINATION RECEIVED FROM CONSIGNEE");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.PreAlertReceivedFromOverseas)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT RECEIVED FROM OVERSEAS");
            entity.Property(e => e.PreAlertSentToBbAgent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO BB AGENT ");
            entity.Property(e => e.PreAlertSentToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO CONSIGNEE");
            entity.Property(e => e.Salesperson).HasMaxLength(100);
            entity.Property(e => e.ShipmentClosed)
                .HasColumnType("datetime")
                .HasColumnName("SHIPMENT CLOSED");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.User)
                .HasMaxLength(100)
                .HasColumnName("USER");
        });

        modelBuilder.Entity<VwQbBillChargesBindFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_qbBillChargesBindFinal");

            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName).HasMaxLength(255);
            entity.Property(e => e.Cmid).HasColumnName("CMID");
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExpectedAmount).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ExpenseAccountHeadId).HasColumnName("ExpenseAccountHeadID");
            entity.Property(e => e.ExpenseRefId)
                .HasMaxLength(255)
                .HasColumnName("ExpenseRefID");
            entity.Property(e => e.ExpenseRefName).HasMaxLength(255);
            entity.Property(e => e.LineAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QbChargeId)
                .HasMaxLength(255)
                .HasColumnName("qbChargeID");
            entity.Property(e => e.QbChargeName)
                .HasMaxLength(255)
                .HasColumnName("qbChargeName");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rate).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ServiceCode).HasMaxLength(100);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.VendorBillId).HasColumnName("VendorBillID");
        });

        modelBuilder.Entity<VwQbExpenseChargeNull>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_qbExpenseChargeNull");

            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChargeItemId).HasColumnName("ChargeItemID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExpectedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.VendorBillId).HasColumnName("VendorBillID");
            entity.Property(e => e.VendorBillLineItemId).HasColumnName("VendorBillLineItemID");
        });

        modelBuilder.Entity<VwQbInvoiceCharge>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_qbInvoiceCharges");

            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName).HasMaxLength(255);
            entity.Property(e => e.ExpectedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IncomeAccountHeadId).HasColumnName("IncomeAccountHeadID");
            entity.Property(e => e.IncomeAccountRefName).HasMaxLength(255);
            entity.Property(e => e.IncomeAccountRefValue).HasMaxLength(255);
            entity.Property(e => e.QbchennaiId)
                .HasMaxLength(255)
                .HasColumnName("QBChennaiId");
            entity.Property(e => e.QbchennaiName)
                .HasMaxLength(255)
                .HasColumnName("QBChennaiName");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
        });

        modelBuilder.Entity<VwQbInvoiceChargesBind>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_qbInvoiceChargesBind");

            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName).HasMaxLength(255);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExpectedAmount).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.IncomeAccountHeadId).HasColumnName("IncomeAccountHeadID");
            entity.Property(e => e.IncomeAccountRefName).HasMaxLength(255);
            entity.Property(e => e.IncomeAccountRefValue).HasMaxLength(255);
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.LineAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QbchennaiId)
                .HasMaxLength(255)
                .HasColumnName("QBChennaiId");
            entity.Property(e => e.QbchennaiName)
                .HasMaxLength(255)
                .HasColumnName("QBChennaiName");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rate).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ServiceCode).HasMaxLength(100);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
        });

        modelBuilder.Entity<VwQbInvoiceChargesBindFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_qbInvoiceChargesBindFinal");

            entity.Property(e => e.ChargeDescription).HasMaxLength(50);
            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName).HasMaxLength(255);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExpectedAmount).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.IncomeAccountHeadId).HasColumnName("IncomeAccountHeadID");
            entity.Property(e => e.IncomeAccountRefName).HasMaxLength(255);
            entity.Property(e => e.IncomeAccountRefValue).HasMaxLength(255);
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.LineAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QbChargeId)
                .HasMaxLength(255)
                .HasColumnName("qbChargeID");
            entity.Property(e => e.QbChargeName)
                .HasMaxLength(255)
                .HasColumnName("qbChargeName");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rate).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ServiceCode).HasMaxLength(100);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
        });

        modelBuilder.Entity<VwQbInvoiceLineItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_QbInvoiceLineItems");

            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IncomeAccountRefName).HasMaxLength(255);
            entity.Property(e => e.IncomeAccountRefValue).HasMaxLength(255);
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.ItemRefId)
                .HasMaxLength(255)
                .HasColumnName("ItemRefID");
            entity.Property(e => e.ItemRefValue).HasMaxLength(255);
            entity.Property(e => e.LineAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QbtaxCodeId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeID");
            entity.Property(e => e.Rate).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
        });

        modelBuilder.Entity<VwQbInvoiceLineItemsFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_QbInvoiceLineItemsFinal");

            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IncomeAccountRefName).HasMaxLength(255);
            entity.Property(e => e.IncomeAccountRefValue).HasMaxLength(255);
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.ItemRefId)
                .HasMaxLength(255)
                .HasColumnName("ItemRefID");
            entity.Property(e => e.ItemRefValue).HasMaxLength(255);
            entity.Property(e => e.LineAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QbtaxCodeId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeID");
            entity.Property(e => e.Rate).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(10, 4)");
        });

        modelBuilder.Entity<VwQbInvoiceTaxChennai>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_qbInvoiceTaxChennai");

            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceLinePercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.InvoiceTypeGst)
                .HasMaxLength(100)
                .HasColumnName("invoiceTypeGst");
            entity.Property(e => e.QbtaxCodeId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeID");
            entity.Property(e => e.QbtaxCodeName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeName");
            entity.Property(e => e.QbtaxRateId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateID");
            entity.Property(e => e.QbtaxRateName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateName");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxLineName).HasMaxLength(255);
            entity.Property(e => e.TaxLinePercent).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TaxableLineAmount).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<VwQbInvoiceTaxFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_qbInvoiceTaxFinal");

            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceLinePercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.InvoiceTypeGst)
                .HasMaxLength(100)
                .HasColumnName("invoiceTypeGst");
            entity.Property(e => e.QbtaxCodeId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeID");
            entity.Property(e => e.QbtaxCodeName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeName");
            entity.Property(e => e.QbtaxRateId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateID");
            entity.Property(e => e.QbtaxRateName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateName");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxLineName).HasMaxLength(255);
            entity.Property(e => e.TaxLinePercent).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TaxableLineAmount).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<VwQbTaxCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_qbTaxCodes");

            entity.Property(e => e.Invoicetypegst)
                .HasMaxLength(255)
                .HasColumnName("INVOICETYPEGST");
            entity.Property(e => e.Qbtaxcodeid)
                .HasMaxLength(255)
                .HasColumnName("QBTAXCODEID");
            entity.Property(e => e.Qbtaxcodename)
                .HasMaxLength(255)
                .HasColumnName("QBTAXCODENAME");
            entity.Property(e => e.Totalpercentage)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TOTALPERCENTAGE");
        });

        modelBuilder.Entity<VwQbTaxCodesBillFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_qbTaxCodesBillFinal");

            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.Invoicetypegst)
                .HasMaxLength(255)
                .HasColumnName("INVOICETYPEGST");
            entity.Property(e => e.Qbtaxcodeid)
                .HasMaxLength(255)
                .HasColumnName("QBTAXCODEID");
            entity.Property(e => e.Qbtaxcodename)
                .HasMaxLength(255)
                .HasColumnName("QBTAXCODENAME");
            entity.Property(e => e.Totalpercentage)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TOTALPERCENTAGE");
        });

        modelBuilder.Entity<VwQbTaxCodesFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_qbTaxCodesFinal");

            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.Invoicetypegst)
                .HasMaxLength(255)
                .HasColumnName("INVOICETYPEGST");
            entity.Property(e => e.Qbtaxcodeid)
                .HasMaxLength(255)
                .HasColumnName("QBTAXCODEID");
            entity.Property(e => e.Qbtaxcodename)
                .HasMaxLength(255)
                .HasColumnName("QBTAXCODENAME");
            entity.Property(e => e.Totalpercentage)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TOTALPERCENTAGE");
        });

        modelBuilder.Entity<VwQbTdsline>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_qbTDSLine");

            entity.Property(e => e.ChargeDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Chg)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CHG");
            entity.Property(e => e.Cmid).HasColumnName("CMID");
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.ExpectedAmount).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.ExpenseAccountHeadId).HasColumnName("ExpenseAccountHeadID");
            entity.Property(e => e.ExpenseRefId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ExpenseRefID");
            entity.Property(e => e.ExpenseRefName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LineAmount).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.QbChargeId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("qbChargeID");
            entity.Property(e => e.Rate).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.ServiceCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.VendorBillId).HasColumnName("VendorBillID");
        });

        modelBuilder.Entity<VwQbVendorBillDataFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_qbVendorBillDataFinal");

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BillingAddrCountrySubDivisionCode)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine1)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine3)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine4)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine5)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ClassRefName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassRefValue)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyRefName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyRefValue)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentRefName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EmailStatus)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FretrackCompanyId).HasColumnName("FretrackCompanyID");
            entity.Property(e => e.FretrackCompanyName).HasMaxLength(100);
            entity.Property(e => e.GlobalTaxCalculation)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PrintStatus)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.PrivateNote).HasMaxLength(155);
            entity.Property(e => e.SalesTermRefValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrCountrySubDivisionCode)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine1)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine3)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine4)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine5)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TranactionLocationType).HasMaxLength(255);
            entity.Property(e => e.VendorBillDate).HasColumnType("datetime");
            entity.Property(e => e.VendorBillId).HasColumnName("VendorBillID");
            entity.Property(e => e.VendorBillNumber).HasMaxLength(20);
            entity.Property(e => e.VendorRefName).HasMaxLength(100);
        });

        modelBuilder.Entity<VwQbVendorBillLineItemsFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_QbVendorBillLineItemsFinal");

            entity.Property(e => e.ChargeDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExpenseRefName).HasMaxLength(255);
            entity.Property(e => e.ExpenseRefValue).HasMaxLength(255);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ItemRefId)
                .HasMaxLength(255)
                .HasColumnName("ItemRefID");
            entity.Property(e => e.ItemRefValue).HasMaxLength(255);
            entity.Property(e => e.LineAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QbtaxCodeId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeID");
            entity.Property(e => e.Rate).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.VendorBillId).HasColumnName("VendorBillID");
        });

        modelBuilder.Entity<VwQbVendorBillTaxFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_qbVendorBillTaxFinal");

            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.InvoiceLinePercent).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.QbtaxCodeId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeID");
            entity.Property(e => e.QbtaxCodeName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxCodeName");
            entity.Property(e => e.QbtaxRateId)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateID");
            entity.Property(e => e.QbtaxRateName)
                .HasMaxLength(255)
                .HasColumnName("QBTaxRateName");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxLineName).HasMaxLength(255);
            entity.Property(e => e.TaxLinePercent).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TaxableLineAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.VendorBillId).HasColumnName("VendorBillID");
            entity.Property(e => e.VendorBillTypeGst)
                .HasMaxLength(100)
                .HasColumnName("VendorBillTypeGST");
        });

        modelBuilder.Entity<VwQbchargeUniqueMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwQBChargeUniqueMappings");

            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName).HasMaxLength(255);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.QbChargeId)
                .HasMaxLength(255)
                .HasColumnName("qbChargeID");
            entity.Property(e => e.QbChargeName)
                .HasMaxLength(255)
                .HasColumnName("qbChargeName");
        });

        modelBuilder.Entity<VwQbexpenseUniqueMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwQBExpenseUniqueMappings");

            entity.Property(e => e.ChargeHeadId).HasColumnName("ChargeHeadID");
            entity.Property(e => e.ChargeHeadName).HasMaxLength(255);
            entity.Property(e => e.Cmid).HasColumnName("CMID");
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.QbChargeId)
                .HasMaxLength(255)
                .HasColumnName("qbChargeID");
            entity.Property(e => e.QbChargeName)
                .HasMaxLength(255)
                .HasColumnName("qbChargeName");
        });

        modelBuilder.Entity<VwQbinvoiceDataFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwQBInvoiceDataFinal");

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BillingAddrCountrySubDivisionCode)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine1)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine3)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine4)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine5)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ClassRefName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassRefValue)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyRefName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyRefValue)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerRefName).HasMaxLength(100);
            entity.Property(e => e.DepartmentRefName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EmailStatus)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FretrackCustomerId).HasColumnName("FretrackCustomerID");
            entity.Property(e => e.FretrackCustomerName).HasMaxLength(100);
            entity.Property(e => e.GlobalTaxCalculation)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.PrintStatus)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.PrivateNote).HasMaxLength(184);
            entity.Property(e => e.SalesTermRefValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrCountrySubDivisionCode)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine1)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine3)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine4)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine5)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TranactionLocationType).HasMaxLength(255);
        });

        modelBuilder.Entity<VwQbinvoiceDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwQBInvoiceData");

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BillingAddrCountrySubDivisionCode)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine1)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine3)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine4)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddrLine5)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ClassRefName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassRefValue)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyRefName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyRefValue)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerRefName).HasMaxLength(100);
            entity.Property(e => e.DepartmentRefName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EmailStatus)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FretrackCustomerId).HasColumnName("FretrackCustomerID");
            entity.Property(e => e.FretrackCustomerName).HasMaxLength(100);
            entity.Property(e => e.GlobalTaxCalculation)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.HomeBalance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.HomeTotalAmt).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.PrintStatus)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.PrivateNote).HasMaxLength(133);
            entity.Property(e => e.SalesTermRefValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrCountrySubDivisionCode)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine1)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine3)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine4)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShipAddrLine5)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TranactionLocationType).HasMaxLength(255);
        });

        modelBuilder.Entity<VwRedEpartsAirDsr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_RedEParts_AirDSR");

            entity.Property(e => e.Airline).HasMaxLength(60);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoPackId).HasColumnName("CargoPackID");
            entity.Property(e => e.CargoPickupDate)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CargoStatus).HasMaxLength(1000);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.CustomsClearanceDate)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Remarks).HasMaxLength(4000);
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.ShipperInvoiceNo).HasMaxLength(30);
            entity.Property(e => e.TotalGrossWeight).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<VwRedEpartsAirDsrDaily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_RedEParts_AirDSR_DAILY");

            entity.Property(e => e.Airline).HasMaxLength(60);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoPickupDate)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CargoStatus).HasMaxLength(1000);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.CustomsClearanceDate)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Remarks).HasMaxLength(4000);
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.ShipperInvoiceNo).HasMaxLength(30);
            entity.Property(e => e.TotalGrossWeight).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<VwRedEpartsOceanDsr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_RedEParts_OceanDSR");

            entity.Property(e => e.ArrivalAtPol)
                .HasColumnType("datetime")
                .HasColumnName("ARRIVAL_AT_POL");
            entity.Property(e => e.BookingNumber).HasMaxLength(30);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoPackId).HasColumnName("CargoPackID");
            entity.Property(e => e.CargoPickupDate)
                .HasColumnType("datetime")
                .HasColumnName("CARGO_PICKUP_DATE");
            entity.Property(e => e.CargoStatus)
                .HasMaxLength(255)
                .HasColumnName("CARGO_STATUS");
            entity.Property(e => e.ChargeableWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ContainerNumber).HasMaxLength(15);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(4000)
                .HasColumnName("POL");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .HasColumnName("REMARKS");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.ShipperInvoiceNo).HasMaxLength(30);
            entity.Property(e => e.ShippingLine).HasMaxLength(30);
            entity.Property(e => e.StuffingDate)
                .HasColumnType("datetime")
                .HasColumnName("STUFFING_DATE");
            entity.Property(e => e.Vessel)
                .HasMaxLength(61)
                .HasColumnName("VESSEL");
        });

        modelBuilder.Entity<VwRedEpartsOceanDsrDaily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_RedEParts_OceanDSR_DAILY");

            entity.Property(e => e.ArrivalAtPol)
                .HasColumnType("datetime")
                .HasColumnName("ARRIVAL_AT_POL");
            entity.Property(e => e.BookingNumber).HasMaxLength(30);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoPickupDate)
                .HasColumnType("datetime")
                .HasColumnName("CARGO_PICKUP_DATE");
            entity.Property(e => e.CargoStatus)
                .HasMaxLength(255)
                .HasColumnName("CARGO_STATUS");
            entity.Property(e => e.ChargeableWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ContainerNumber).HasMaxLength(15);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(4000)
                .HasColumnName("POL");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .HasColumnName("REMARKS");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("SHIPPER");
            entity.Property(e => e.ShipperInvoiceNo).HasMaxLength(30);
            entity.Property(e => e.ShippingLine).HasMaxLength(30);
            entity.Property(e => e.StuffingDate)
                .HasColumnType("datetime")
                .HasColumnName("STUFFING_DATE");
            entity.Property(e => e.Vessel)
                .HasMaxLength(61)
                .HasColumnName("VESSEL");
        });

        modelBuilder.Entity<VwRingplusCharge>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ringplusCharges");

            entity.Property(e => e.AcdCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("ACD CHARGES");
            entity.Property(e => e.AdminFeeIn)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("ADMIN FEE IN");
            entity.Property(e => e.AdminFeeOut)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("ADMIN FEE OUT");
            entity.Property(e => e.AdvanceCargoDeclarationCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("ADVANCE CARGO DECLARATION CHARGES");
            entity.Property(e => e.AdvanceCargoDeclarationCharges1)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("Advance Cargo DeclarationCharges ");
            entity.Property(e => e.AdvanceManifestSubmission)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("ADVANCE MANIFEST SUBMISSION");
            entity.Property(e => e.AirFreight)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("AIR FREIGHT");
            entity.Property(e => e.AirwayBillFees)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("AIRWAY BILL FEES");
            entity.Property(e => e.BookingCancellationFees)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("BOOKING CANCELLATION FEES");
            entity.Property(e => e.BunkerAdjFactor)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("BUNKER ADJ FACTOR");
            entity.Property(e => e.ChasisFee)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("CHASIS FEE");
            entity.Property(e => e.CleaningCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("CLEANING CHARGES");
            entity.Property(e => e.CntrCleaningChgs)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("CNTR CLEANING CHGS");
            entity.Property(e => e.CustomClearanceCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("CUSTOM CLEARANCE CHARGES");
            entity.Property(e => e.CustomDuty)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("CUSTOM DUTY");
            entity.Property(e => e.CustomDutyCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("CUSTOM DUTY CHARGES ");
            entity.Property(e => e.Demurrage)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("DEMURRAGE");
            entity.Property(e => e.DestDoFee)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("DEST DO FEE");
            entity.Property(e => e.DestinationCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("DESTINATION CHARGES");
            entity.Property(e => e.DetentionCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("DETENTION CHARGES");
            entity.Property(e => e.DirectTruckDelivery)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("DIRECT TRUCK DELIVERY");
            entity.Property(e => e.DirectTruckingChgs)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("DIRECT TRUCKING CHGS");
            entity.Property(e => e.DocFe)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("DOC FE");
            entity.Property(e => e.DocFee)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("DOC FEE ");
            entity.Property(e => e.DocFeeOrigin)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("DOC FEE (ORIGIN)");
            entity.Property(e => e.DropOffCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("DROP OFF CHARGES");
            entity.Property(e => e.DropOffExtension)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("DROP OFF EXTENSION");
            entity.Property(e => e.EirCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("EIR CHARGES");
            entity.Property(e => e.EnsFee)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("ENS FEE ");
            entity.Property(e => e.EnsFee1)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("ENS FEE 1");
            entity.Property(e => e.EquipmentSurcharge)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("Equipment Surcharge");
            entity.Property(e => e.FacilityCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("FACILITY CHARGES");
            entity.Property(e => e.FumigationCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("FUMIGATION CHARGES");
            entity.Property(e => e.GasMeasuringContainer)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("GAS MEASURING CONTAINER");
            entity.Property(e => e.GmaxCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("GMAX CHARGES");
            entity.Property(e => e.HandlingCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("HANDLING CHARGES");
            entity.Property(e => e.HandlingChargesAtRrtTerminal)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("HANDLING CHARGES AT RRT TERMINAL");
            entity.Property(e => e.HandlingChargesMsc)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("HANDLING CHARGES MSC");
            entity.Property(e => e.HandlingChgsAtRrtTerminal)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("HANDLING CHGS AT RRT TERMINAL");
            entity.Property(e => e.HandlingFee)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("HANDLING FEE");
            entity.Property(e => e.HandlingTerminalRrt)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("HANDLING TERMINAL RRT");
            entity.Property(e => e.HarborMaintenanceFee)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("HARBOR MAINTENANCE FEE");
            entity.Property(e => e.HstOnServCollect)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("HST ON SERV COLLECT");
            entity.Property(e => e.ImportSecurityFiling)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("IMPORT SECURITY FILING");
            entity.Property(e => e.InspectionExamFees)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("INSPECTION/EXAM FEES");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.IspsSurcharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("ISPS SURCHARGES");
            entity.Property(e => e.Label)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("LABEL");
            entity.Property(e => e.LabelChgs)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("LABEL CHGS");
            entity.Property(e => e.LableCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("LABLE CHARGES ");
            entity.Property(e => e.LoadingPallets)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("LOADING PALLETS");
            entity.Property(e => e.LowWaterSurcharge)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("LOW WATER SURCHARGE");
            entity.Property(e => e.MandatoryUserCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("MANDATORY USER CHARGES");
            entity.Property(e => e.MerchandiseProcessingFee)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("MERCHANDISE PROCESSING FEE");
            entity.Property(e => e.MessengerFees)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("MESSENGER FEES");
            entity.Property(e => e.MonthlyStorage)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("MONTHLY STORAGE");
            entity.Property(e => e.MonthlyStorageApril21)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("MONTHLY STORAGE APRIL21");
            entity.Property(e => e.MonthlyStorageAug20)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("MONTHLY STORAGE (AUG20)");
            entity.Property(e => e.MonthlyStorageJul20)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("MONTHLY STORAGE (JUL20)");
            entity.Property(e => e.MonthlyStorageNov20)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("MONTHLY STORAGE( NOV20 )");
            entity.Property(e => e.MonthlyStorageOct20)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("MONTHLY STORAGE (OCT20)");
            entity.Property(e => e.MonthlyStorageSep20)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("MONTHLY STORAGE (SEP20)");
            entity.Property(e => e.MpfCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("MPF CHARGES");
            entity.Property(e => e.OceanFreight)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("OCEAN FREIGHT");
            entity.Property(e => e.OtherCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("OTHER CHARGES");
            entity.Property(e => e.PalletsIn)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("PALLETS IN");
            entity.Property(e => e.PalletsOut)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("PALLETS OUT");
            entity.Property(e => e.PcaChrages)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("PCA CHRAGES");
            entity.Property(e => e.SealFee)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("SEAL FEE");
            entity.Property(e => e.SpecialServiceRequestSsr)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("SPECIAL SERVICE REQUEST (SSR)");
            entity.Property(e => e.Storage01)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("STORAGE 01");
            entity.Property(e => e.StorageChgsEur004x8484KgsX2Days)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("STORAGE CHGS(EUR 0.04x8484 KGS x 2 DAYS) ");
            entity.Property(e => e.StorageFee)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("STORAGE FEE");
            entity.Property(e => e.Surcharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("SURCHARGES");
            entity.Property(e => e.SurrenderCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("SURRENDER CHARGES");
            entity.Property(e => e.TerminalHandlingCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("TERMINAL HANDLING CHARGES");
            entity.Property(e => e.TollCharge)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("TOLL CHARGE");
            entity.Property(e => e.TransportForScanProcedure)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("TRANSPORT FOR SCAN PROCEDURE");
            entity.Property(e => e.TransportationCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("TRANSPORTATION CHARGES");
            entity.Property(e => e.UnloadingPallets)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("UNLOADING PALLETS");
            entity.Property(e => e.VentilationInstallingVentilationCharges)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("VENTILATION & INSTALLING VENTILATION CHARGES ");
            entity.Property(e => e.VentilationInstallingVentilationChgs)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("VENTILATION & INSTALLING VENTILATION CHGS");
            entity.Property(e => e.WaitingTimeForScan)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("WAITING TIME FOR SCAN");
            entity.Property(e => e.WebServiceInventoryData)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("WEB/SERVICE/INVENTORY DATA");
        });

        modelBuilder.Entity<VwRingplusLineExRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Ringplus_LineExRate");

            entity.Property(e => e.Eur)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EUR");
            entity.Property(e => e.Inr)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INR");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.Invoicenumber)
                .HasMaxLength(20)
                .HasColumnName("INVOICENUMBER");
            entity.Property(e => e.Jobno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOBNO");
            entity.Property(e => e.Usd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("USD");
        });

        modelBuilder.Entity<VwSalesQuoteStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SalesQuoteStatus");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Lost).HasColumnName("LOST");
            entity.Property(e => e.Pending).HasColumnName("PENDING");
            entity.Property(e => e.SalesQuoteNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Won).HasColumnName("WON");
        });

        modelBuilder.Entity<VwSalesReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SalesReport");

            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.Expense)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("EXPENSE");
            entity.Property(e => e.Income)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("INCOME");
            entity.Property(e => e.JobMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("JOB_MONTH");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Officename)
                .HasMaxLength(100)
                .HasColumnName("OFFICENAME");
            entity.Property(e => e.OpportunityAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OPPORTUNITY_AMOUNT");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.ProfitOnJob)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("PROFIT_ON_JOB");
            entity.Property(e => e.Salesperson)
                .HasMaxLength(100)
                .HasColumnName("SALESPERSON");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.SopStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SOP_STATUS");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSalesReportBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SalesReport_BASE");

            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.Expense)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("EXPENSE");
            entity.Property(e => e.Income)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("INCOME");
            entity.Property(e => e.JobMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("JOB_MONTH");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Officename)
                .HasMaxLength(100)
                .HasColumnName("OFFICENAME");
            entity.Property(e => e.OpportunityAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OPPORTUNITY_AMOUNT");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.ProfitOnJob)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("PROFIT_ON_JOB");
            entity.Property(e => e.Salesperson)
                .HasMaxLength(100)
                .HasColumnName("SALESPERSON");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.SopStatus).HasColumnName("SOP_STATUS");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSalesReportHiren>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SalesReport_HIREN");

            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.Expense)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("EXPENSE");
            entity.Property(e => e.Income)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("INCOME");
            entity.Property(e => e.JobMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("JOB_MONTH");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Officename)
                .HasMaxLength(100)
                .HasColumnName("OFFICENAME");
            entity.Property(e => e.OpportunityAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OPPORTUNITY_AMOUNT");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.ProfitOnJob)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("PROFIT_ON_JOB");
            entity.Property(e => e.Salesperson)
                .HasMaxLength(100)
                .HasColumnName("SALESPERSON");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.SopStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SOP_STATUS");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSalesReportMeeting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SalesReportMEETING");

            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.JobMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("JOB_MONTH");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Officename)
                .HasMaxLength(100)
                .HasColumnName("OFFICENAME");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Salesperson)
                .HasMaxLength(100)
                .HasColumnName("SALESPERSON");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.TotalGrossWeightKgs)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalGrossWeightKGS");
            entity.Property(e => e.TotalVolumeCbm)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalVolumeCBM");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSalesReportNonTax>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SalesReport_nonTax");

            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Csid).HasColumnName("CSID");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.Expense)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("EXPENSE");
            entity.Property(e => e.Income)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("INCOME");
            entity.Property(e => e.JobMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("JOB_MONTH");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Officename)
                .HasMaxLength(100)
                .HasColumnName("OFFICENAME");
            entity.Property(e => e.OpportunityAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OPPORTUNITY_AMOUNT");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.ProfitOnJob)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("PROFIT_ON_JOB");
            entity.Property(e => e.Salesperson)
                .HasMaxLength(100)
                .HasColumnName("SALESPERSON");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.SopStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SOP_STATUS");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSalesReportTurkey>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SalesReportTurkey");

            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Costsheetstatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COSTSHEETSTATUS");
            entity.Property(e => e.Costsheettype)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COSTSHEETTYPE");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.ExpenseEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_EUR");
            entity.Property(e => e.ExpenseTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("EXPENSE_TL");
            entity.Property(e => e.ExpenseUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("EXPENSE_USD");
            entity.Property(e => e.IncomeEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_EUR");
            entity.Property(e => e.IncomeTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("INCOME_TL");
            entity.Property(e => e.IncomeUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("INCOME_USD");
            entity.Property(e => e.JobMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("JOB_MONTH");
            entity.Property(e => e.Jobno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOBNO");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Officename)
                .HasMaxLength(100)
                .HasColumnName("OFFICENAME");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.ProfitEur)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PROFIT_EUR");
            entity.Property(e => e.ProfitTl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("PROFIT_TL");
            entity.Property(e => e.ProfitUsd)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PROFIT_USD");
            entity.Property(e => e.Salesperson)
                .HasMaxLength(100)
                .HasColumnName("SALESPERSON");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSalesquoteinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_salesquoteinfo");

            entity.Property(e => e.AgentDetails)
                .HasMaxLength(500)
                .HasColumnName("AGENT DETAILS");
            entity.Property(e => e.BusinessReceivedDate)
                .HasColumnType("date")
                .HasColumnName("Business Received Date");
            entity.Property(e => e.Contact)
                .HasMaxLength(150)
                .HasColumnName("CONTACT");
            entity.Property(e => e.Customer)
                .HasMaxLength(250)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.EnquiryReceivedDate)
                .HasColumnType("date")
                .HasColumnName("Enquiry Received Date");
            entity.Property(e => e.OfficeName)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("OfficeNAme");
            entity.Property(e => e.Pod)
                .HasMaxLength(200)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(200)
                .HasColumnName("POL");
            entity.Property(e => e.PreparedBy)
                .HasMaxLength(150)
                .HasColumnName("PREPARED BY");
            entity.Property(e => e.QuoteDays).HasColumnName("QUOTE_DAYS");
            entity.Property(e => e.QuoteSentOn)
                .HasColumnType("date")
                .HasColumnName("Quote sent on");
            entity.Property(e => e.ResponseDays).HasColumnName("RESPONSE_DAYS");
            entity.Property(e => e.SalesPerson)
                .HasMaxLength(150)
                .HasColumnName("SALES PERSON");
            entity.Property(e => e.SalesQuoteNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(19)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSalesquoteinfoList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_salesquoteinfoList");

            entity.Property(e => e.AgentDetails)
                .HasMaxLength(500)
                .HasColumnName("AGENT DETAILS");
            entity.Property(e => e.BusinessReceivedDate)
                .HasColumnType("date")
                .HasColumnName("Business Received Date");
            entity.Property(e => e.Commodity).HasMaxLength(1000);
            entity.Property(e => e.Contact)
                .HasMaxLength(150)
                .HasColumnName("CONTACT");
            entity.Property(e => e.Customer)
                .HasMaxLength(250)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Direction).HasMaxLength(20);
            entity.Property(e => e.EnquiryReceivedDate)
                .HasColumnType("date")
                .HasColumnName("Enquiry Received Date");
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.Modeoftransport).HasMaxLength(20);
            entity.Property(e => e.OfficeName)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("OfficeNAme");
            entity.Property(e => e.Pod)
                .HasMaxLength(200)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(200)
                .HasColumnName("POL");
            entity.Property(e => e.PreparedBy)
                .HasMaxLength(150)
                .HasColumnName("PREPARED BY");
            entity.Property(e => e.PreparedBy1).HasColumnName("PreparedBy");
            entity.Property(e => e.QuoteDays).HasColumnName("QUOTE_DAYS");
            entity.Property(e => e.QuoteSentOn)
                .HasColumnType("date")
                .HasColumnName("Quote sent on");
            entity.Property(e => e.RequiredEquipment).HasMaxLength(1000);
            entity.Property(e => e.ResponseDays).HasColumnName("RESPONSE_DAYS");
            entity.Property(e => e.SalesPerson)
                .HasMaxLength(150)
                .HasColumnName("SALES PERSON");
            entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            entity.Property(e => e.SalesQuoteId).HasColumnName("SalesQuoteID");
            entity.Property(e => e.SalesQuoteNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SalesQuoteType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.Volume).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<VwShipmentInvoiceGeneration>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ShipmentInvoiceGeneration");

            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.Hblno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBLNO");
            entity.Property(e => e.Invdt).HasColumnName("invdt");
            entity.Property(e => e.Invno).HasColumnName("invno");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mblno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBLNO");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.TotalChargeable).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TotalGrossWeightKgs)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalGrossWeightKGS");
            entity.Property(e => e.TotalVolumeCbm)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalVolumeCBM");
            entity.Property(e => e.TransitStatus)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TRANSIT STATUS");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._20rf).HasColumnName("20RF");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40ot).HasColumnName("40OT");
            entity.Property(e => e._40rf).HasColumnName("40RF");
            entity.Property(e => e._45gp).HasColumnName("45GP");
        });

        modelBuilder.Entity<VwShipmentInvoiceGenerationChn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ShipmentInvoiceGeneration_chn");

            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.Hblno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBLNO");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mblno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBLNO");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.TotalChargeable).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TotalGrossWeightKgs)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalGrossWeightKGS");
            entity.Property(e => e.TotalVolumeCbm)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TotalVolumeCBM");
            entity.Property(e => e.TransitStatus)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TRANSIT STATUS");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._20rf).HasColumnName("20RF");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40ot).HasColumnName("40OT");
            entity.Property(e => e._40rf).HasColumnName("40RF");
            entity.Property(e => e._45gp).HasColumnName("45GP");
        });

        modelBuilder.Entity<VwShipmentOperationsReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ShipmentOperationsReport");

            entity.Property(e => e.Commodity).HasColumnName("COMMODITY");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.DestinationAgent).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Invoiceno).HasColumnName("invoiceno");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Jobdate)
                .HasColumnType("datetime")
                .HasColumnName("JOBDATE");
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OceanLine).HasMaxLength(60);
            entity.Property(e => e.OriginAgent).HasMaxLength(200);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Sbdate).HasColumnName("SBDATE");
            entity.Property(e => e.Sbno).HasColumnName("SBNO");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Vessel).HasMaxLength(50);
        });

        modelBuilder.Entity<VwShipmentOperationsReportFy20>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ShipmentOperationsReport_FY20");

            entity.Property(e => e.Commodity).HasColumnName("commodity");
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .HasColumnName("consignee");
            entity.Property(e => e.Customername)
                .HasMaxLength(100)
                .HasColumnName("customername");
            entity.Property(e => e.Destinationagent)
                .HasMaxLength(100)
                .HasColumnName("destinationagent");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("eta");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("etd");
            entity.Property(e => e.Houseno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("houseno");
            entity.Property(e => e.Invoiceno).HasColumnName("invoiceno");
            entity.Property(e => e.Jobdate)
                .HasColumnType("datetime")
                .HasColumnName("JOBDATE");
            entity.Property(e => e.Jobno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("jobno");
            entity.Property(e => e.Masterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("masterno");
            entity.Property(e => e.Modeoftransport)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("modeoftransport");
            entity.Property(e => e.Oceanline)
                .HasMaxLength(60)
                .HasColumnName("oceanline");
            entity.Property(e => e.Originagent)
                .HasMaxLength(200)
                .HasColumnName("originagent");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("pod");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("pol");
            entity.Property(e => e.Sbdate).HasColumnName("sbdate");
            entity.Property(e => e.Sbno).HasColumnName("sbno");
            entity.Property(e => e.Shipper)
                .HasMaxLength(100)
                .HasColumnName("shipper");
            entity.Property(e => e.Transportdirection)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("transportdirection");
            entity.Property(e => e.Vessel)
                .HasMaxLength(50)
                .HasColumnName("vessel");
        });

        modelBuilder.Entity<VwShipmentReportSagar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ShipmentReport_Sagar");

            entity.Property(e => e.AirlineOceanLine)
                .HasMaxLength(60)
                .HasColumnName("Airline_OceanLine");
            entity.Property(e => e.CargoType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Cbm)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("CBM");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ContainerCount).HasColumnName("Container_Count");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DestinationAgent)
                .HasMaxLength(100)
                .HasColumnName("DESTINATION_AGENT");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.IncotermName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.JobMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OriginAgent)
                .HasMaxLength(100)
                .HasColumnName("ORIGIN_AGENT");
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.TotalWeightKgs)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("TOTAL_WEIGHT_KGS");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSopreport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SOPReport");

            entity.Property(e => e.BuyingTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BUYING TOTAL");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ContainerType)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Costsheettype)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COSTSHEETTYPE");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.JobDate).HasColumnType("date");
            entity.Property(e => e.Jobno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JOBNO");
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OceanLine).HasMaxLength(60);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Profit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PROFIT");
            entity.Property(e => e.SellingTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SELLING TOTAL");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwStagingCustContainer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwStagingCustContainers");

            entity.Property(e => e.Customer)
                .HasMaxLength(100)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.ParentCompanyId).HasColumnName("parentCompanyID");
            entity.Property(e => e._2018oe20).HasColumnName("2018OE_20");
            entity.Property(e => e._2018oe40).HasColumnName("2018OE_40");
            entity.Property(e => e._2018oi20).HasColumnName("2018OI_20");
            entity.Property(e => e._2018oi40).HasColumnName("2018OI_40");
            entity.Property(e => e._2019oe20).HasColumnName("2019OE_20");
            entity.Property(e => e._2019oe40).HasColumnName("2019OE_40");
            entity.Property(e => e._2019oi20).HasColumnName("2019OI_20");
            entity.Property(e => e._2019oi40).HasColumnName("2019OI_40");
        });

        modelBuilder.Entity<VwStagingCustWeight>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwStagingCustWeight");

            entity.Property(e => e.Customer)
                .HasMaxLength(100)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.ParentCompanyId).HasColumnName("parentCompanyID");
            entity.Property(e => e._2018ae)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("2018AE");
            entity.Property(e => e._2018ai)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("2018AI");
            entity.Property(e => e._2019ae)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("2019AE");
            entity.Property(e => e._2019ai)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("2019AI");
        });

        modelBuilder.Entity<VwStatusAirExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_StatusAirExport");

            entity.Property(e => e.AwbDraftIssuedToShipperCha)
                .HasColumnType("datetime")
                .HasColumnName("AWB DRAFT ISSUED TO SHIPPER/CHA");
            entity.Property(e => e.AwbHawbSentToShipperCha)
                .HasColumnType("datetime")
                .HasColumnName("AWB/HAWB SENT TO SHIPPER/CHA");
            entity.Property(e => e.BookingConfirmedByAirLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMED BY AIR LINER");
            entity.Property(e => e.BookingIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingRequestDocumentsReceivedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST/DOCUMENTS RECEIVED FROM CUSTOMER");
            entity.Property(e => e.BookingRequestToAirLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST TO AIR LINER");
            entity.Property(e => e.CargoCustomCleared)
                .HasColumnType("datetime")
                .HasColumnName("CARGO CUSTOM CLEARED");
            entity.Property(e => e.CargoDelivered)
                .HasColumnType("datetime")
                .HasColumnName("CARGO DELIVERED");
            entity.Property(e => e.CargoGatedInByCha)
                .HasColumnType("datetime")
                .HasColumnName("CARGO GATED IN BY CHA");
            entity.Property(e => e.CargoHandedOverToAirline)
                .HasColumnType("datetime")
                .HasColumnName("CARGO HANDED OVER TO AIRLINE");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ClearanceBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE BILL RECEIVED");
            entity.Property(e => e.ClearanceDone)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE DONE");
            entity.Property(e => e.CostSheetApprovalLockDate)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET APPROVAL/LOCK DATE");
            entity.Property(e => e.CostSheetHandedOverToAccounts)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET HANDED OVER TO ACCOUNTS");
            entity.Property(e => e.DduDdpClearance)
                .HasColumnType("datetime")
                .HasColumnName("DDU/DDP CLEARANCE");
            entity.Property(e => e.DestinationDnReceived)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION DN RECEIVED");
            entity.Property(e => e.DocumentsCouriedToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("DOCUMENTS COURIED TO CONSIGNEE");
            entity.Property(e => e.FlightArrivalAtDestination)
                .HasColumnType("datetime")
                .HasColumnName("FLIGHT ARRIVAL AT DESTINATION");
            entity.Property(e => e.FlightDeparture)
                .HasColumnType("datetime")
                .HasColumnName("FLIGHT DEPARTURE");
            entity.Property(e => e.FreightBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("FREIGHT BILL RECEIVED");
            entity.Property(e => e.InvoiceGenerationDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE GENERATION DATE");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ISSUED TO CUSTOMER");
            entity.Property(e => e.PreAlertDocsSent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT DOCS SENT");
            entity.Property(e => e.PreAlertSentToDestinationAgent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO DESTINATION AGENT");
            entity.Property(e => e.ProofOfDeliveryFromAgent)
                .HasColumnType("datetime")
                .HasColumnName("PROOF OF DELIVERY FROM AGENT");
            entity.Property(e => e.ShippingInstructionsIssuedByCha)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPING INSTRUCTIONS ISSUED BY CHA");
            entity.Property(e => e.TransportBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("TRANSPORT BILL RECEIVED");
        });

        modelBuilder.Entity<VwStatusAirImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_StatusAirImport");

            entity.Property(e => e.AirlineBbAgentInvoiceReceived)
                .HasColumnType("datetime")
                .HasColumnName("AIRLINE/BB AGENT INVOICE RECEIVED");
            entity.Property(e => e.CargoArrivalNotice)
                .HasColumnType("datetime")
                .HasColumnName("CARGO ARRIVAL NOTICE");
            entity.Property(e => e.CargoBookingDate)
                .HasColumnType("datetime")
                .HasColumnName("CARGO BOOKING DATE");
            entity.Property(e => e.CargoDeliveredToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("CARGO DELIVERED TO CUSTOMER");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoPickupDate)
                .HasColumnType("datetime")
                .HasColumnName("CARGO PICKUP DATE");
            entity.Property(e => e.ClearanceBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE BILL RECEIVED");
            entity.Property(e => e.ClearanceDone)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE DONE");
            entity.Property(e => e.CostSheetApprovalLockDate)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET APPROVAL/LOCK DATE");
            entity.Property(e => e.CostSheetHandedOverToAccounts)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET HANDED OVER TO ACCOUNTS");
            entity.Property(e => e.DduDdpClearance)
                .HasColumnType("datetime")
                .HasColumnName("DDU/DDP CLEARANCE");
            entity.Property(e => e.DeliveryOrderIssuedToConsigneeCha)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY ORDER ISSUED TO CONSIGNEE/CHA");
            entity.Property(e => e.DestinationDnReceived)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION DN RECEIVED");
            entity.Property(e => e.DocumentsCouriedToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("DOCUMENTS COURIED TO CONSIGNEE");
            entity.Property(e => e.DocumentsReceivedAck)
                .HasColumnType("datetime")
                .HasColumnName("DOCUMENTS RECEIVED ACK");
            entity.Property(e => e.FlightArrival)
                .HasColumnType("datetime")
                .HasColumnName("FLIGHT ARRIVAL");
            entity.Property(e => e.FlightDepartureDate)
                .HasColumnType("datetime")
                .HasColumnName("FLIGHT DEPARTURE DATE");
            entity.Property(e => e.FreightBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("FREIGHT BILL RECEIVED");
            entity.Property(e => e.IgmFilingDate)
                .HasColumnType("datetime")
                .HasColumnName("IGM FILING DATE");
            entity.Property(e => e.InvoiceGenerationDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE GENERATION DATE");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ISSUED TO CUSTOMER");
            entity.Property(e => e.NominationInformedToOverseasAgent)
                .HasColumnType("datetime")
                .HasColumnName("NOMINATION INFORMED TO OVERSEAS AGENT");
            entity.Property(e => e.NominationReceivedFromConsignee)
                .HasColumnType("datetime")
                .HasColumnName("NOMINATION RECEIVED FROM CONSIGNEE");
            entity.Property(e => e.PreAlertDocsSent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT DOCS SENT");
            entity.Property(e => e.PreAlertReceivedFromOverseas)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT RECEIVED FROM OVERSEAS");
            entity.Property(e => e.PreAlertSentToBbAgent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO BB AGENT ");
            entity.Property(e => e.PreAlertSentToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO CONSIGNEE");
            entity.Property(e => e.ShipmentClosed)
                .HasColumnType("datetime")
                .HasColumnName("SHIPMENT CLOSED");
            entity.Property(e => e.TransportBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("TRANSPORT BILL RECEIVED");
        });

        modelBuilder.Entity<VwStatusOceanExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_StatusOceanExport");

            entity.Property(e => e.ArrivalDateIntoCfs)
                .HasColumnType("datetime")
                .HasColumnName("ARRIVAL DATE INTO CFS");
            entity.Property(e => e.BlFirstPrintReceivedFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("BL FIRST PRINT RECEIVED FROM LINER");
            entity.Property(e => e.BlIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BL ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingConfirmedByLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMED BY LINER");
            entity.Property(e => e.BookingIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingRequestDocumentsReceivedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST/DOCUMENTS RECEIVED FROM CUSTOMER");
            entity.Property(e => e.BookingRequestToLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST TO LINER");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoPickupDate)
                .HasColumnType("datetime")
                .HasColumnName("CARGO PICKUP DATE");
            entity.Property(e => e.ClearanceBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE BILL RECEIVED");
            entity.Property(e => e.ClearanceDone)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE DONE");
            entity.Property(e => e.ContainerPickedUpByCustomer)
                .HasColumnType("datetime")
                .HasColumnName("CONTAINER PICKED UP BY CUSTOMER");
            entity.Property(e => e.CostSheetApprovalLockDate)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET APPROVAL/LOCK DATE");
            entity.Property(e => e.CostSheetHandedOverToAccounts)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET HANDED OVER TO ACCOUNTS");
            entity.Property(e => e.CustomsClearanceDate)
                .HasColumnType("datetime")
                .HasColumnName("CUSTOMS CLEARANCE DATE");
            entity.Property(e => e.DduDdpClearance)
                .HasColumnType("datetime")
                .HasColumnName("DDU/DDP CLEARANCE");
            entity.Property(e => e.DebitNoteReceivedFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("DEBIT NOTE RECEIVED FROM LINER");
            entity.Property(e => e.Delivered)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERED");
            entity.Property(e => e.DeliveryOrderSentByDestinationAgent)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY ORDER SENT BY DESTINATION AGENT");
            entity.Property(e => e.DestinationCustomsCleared)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION CUSTOMS CLEARED");
            entity.Property(e => e.DestinationCustomsHold)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION CUSTOMS HOLD");
            entity.Property(e => e.DestinationDnReceived)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION DN RECEIVED");
            entity.Property(e => e.DocumentsCouriedToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("DOCUMENTS COURIED TO CONSIGNEE");
            entity.Property(e => e.FreightBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("FREIGHT BILL RECEIVED");
            entity.Property(e => e.InvoiceGenerationDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE GENERATION DATE");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ISSUED TO CUSTOMER");
            entity.Property(e => e.LoadingListSentToLiner)
                .HasColumnType("datetime")
                .HasColumnName("LOADING LIST SENT TO LINER");
            entity.Property(e => e.PickedUpByCustomerAgent)
                .HasColumnType("datetime")
                .HasColumnName("PICKED UP BY CUSTOMER / AGENT");
            entity.Property(e => e.PreAlertDocsSent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT DOCS SENT");
            entity.Property(e => e.PreAlertSentToAgent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO AGENT");
            entity.Property(e => e.ShipmentClosed)
                .HasColumnType("datetime")
                .HasColumnName("SHIPMENT CLOSED");
            entity.Property(e => e.ShippedOnBoard)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPED ON BOARD");
            entity.Property(e => e.ShipperInformDate)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPER INFORM DATE");
            entity.Property(e => e.SiIssuedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("SI ISSUED FROM CUSTOMER");
            entity.Property(e => e.SiSubmissionToTheLiner)
                .HasColumnType("datetime")
                .HasColumnName("SI SUBMISSION TO THE LINER");
            entity.Property(e => e.StuffingDateAtCfs)
                .HasColumnType("datetime")
                .HasColumnName("STUFFING DATE AT CFS");
            entity.Property(e => e.TransportBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("TRANSPORT BILL RECEIVED");
            entity.Property(e => e.VesselArrivalAtDestination)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL ARRIVAL AT DESTINATION");
            entity.Property(e => e.VesselDeparture)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL DEPARTURE");
        });

        modelBuilder.Entity<VwStatusOceanExportCc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_StatusOceanExport_CC");

            entity.Property(e => e.BlFirstPrintReceivedFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("BL FIRST PRINT RECEIVED FROM LINER");
            entity.Property(e => e.BlIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BL ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingConfirmedByLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMED BY LINER");
            entity.Property(e => e.BookingIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING ISSUED TO CUSTOMER");
            entity.Property(e => e.BookingRequestDocumentsReceivedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST/DOCUMENTS RECEIVED FROM CUSTOMER");
            entity.Property(e => e.BookingRequestToLiner)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING REQUEST TO LINER");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ClearanceBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE BILL RECEIVED");
            entity.Property(e => e.ClearanceDone)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE DONE");
            entity.Property(e => e.ContainerPickedUpByCustomer)
                .HasColumnType("datetime")
                .HasColumnName("CONTAINER PICKED UP BY CUSTOMER");
            entity.Property(e => e.CostSheetApprovalLockDate)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET APPROVAL/LOCK DATE");
            entity.Property(e => e.CostSheetHandedOverToAccounts)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET HANDED OVER TO ACCOUNTS");
            entity.Property(e => e.CustomsClearanceCompleted)
                .HasColumnType("datetime")
                .HasColumnName("CUSTOMS CLEARANCE COMPLETED");
            entity.Property(e => e.DduDdpClearance)
                .HasColumnType("datetime")
                .HasColumnName("DDU/DDP CLEARANCE");
            entity.Property(e => e.DebitNoteReceivedFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("DEBIT NOTE RECEIVED FROM LINER");
            entity.Property(e => e.Delivered)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERED");
            entity.Property(e => e.DeliveryOrderSentByDestinationAgent)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY ORDER SENT BY DESTINATION AGENT");
            entity.Property(e => e.DestinationCustomsCleared)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION CUSTOMS CLEARED");
            entity.Property(e => e.DestinationCustomsHold)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION CUSTOMS HOLD");
            entity.Property(e => e.DestinationDnReceived)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION DN RECEIVED");
            entity.Property(e => e.DocumentsCouriedToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("DOCUMENTS COURIED TO CONSIGNEE");
            entity.Property(e => e.FreightBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("FREIGHT BILL RECEIVED");
            entity.Property(e => e.InvoiceGenerationDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE GENERATION DATE");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ISSUED TO CUSTOMER");
            entity.Property(e => e.LoadingListSentToLiner)
                .HasColumnType("datetime")
                .HasColumnName("LOADING LIST SENT TO LINER");
            entity.Property(e => e.PickedUpByCustomerAgent)
                .HasColumnType("datetime")
                .HasColumnName("PICKED UP BY CUSTOMER / AGENT");
            entity.Property(e => e.PreAlertDocsSent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT DOCS SENT");
            entity.Property(e => e.PreAlertSentToAgent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO AGENT");
            entity.Property(e => e.ShipmentClosed)
                .HasColumnType("datetime")
                .HasColumnName("SHIPMENT CLOSED");
            entity.Property(e => e.ShippedOnBoard)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPED ON BOARD");
            entity.Property(e => e.SiIssuedFromCustomer)
                .HasColumnType("datetime")
                .HasColumnName("SI ISSUED FROM CUSTOMER");
            entity.Property(e => e.SiSubmissionToTheLiner)
                .HasColumnType("datetime")
                .HasColumnName("SI SUBMISSION TO THE LINER");
            entity.Property(e => e.TransportBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("TRANSPORT BILL RECEIVED");
            entity.Property(e => e.VesselArrivalAtDestination)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL ARRIVAL AT DESTINATION");
            entity.Property(e => e.VesselDeparture)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL DEPARTURE");
        });

        modelBuilder.Entity<VwStatusOceanImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_StatusOceanImport");

            entity.Property(e => e.BookingConfirmation)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING CONFIRMATION");
            entity.Property(e => e.CargoArrivalNoticeSentToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("CARGO ARRIVAL NOTICE SENT TO CUSTOMER");
            entity.Property(e => e.CargoDeliveredToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("CARGO DELIVERED TO CUSTOMER");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ClearanceBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE BILL RECEIVED");
            entity.Property(e => e.ClearanceDone)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE DONE");
            entity.Property(e => e.ContainerPickupFromLiner)
                .HasColumnType("datetime")
                .HasColumnName("CONTAINER PICKUP FROM LINER");
            entity.Property(e => e.CostSheetApprovalLockDate)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET APPROVAL/LOCK DATE");
            entity.Property(e => e.CostSheetHandedOverToAccounts)
                .HasColumnType("datetime")
                .HasColumnName("COST SHEET HANDED OVER TO ACCOUNTS");
            entity.Property(e => e.DduDdpClearance)
                .HasColumnType("datetime")
                .HasColumnName("DDU/DDP CLEARANCE");
            entity.Property(e => e.DebitNoteReceivedFromAgent)
                .HasColumnType("datetime")
                .HasColumnName("DEBIT NOTE RECEIVED FROM AGENT");
            entity.Property(e => e.DeliveryOrderIssuedToConsigneeCha)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY ORDER ISSUED TO CONSIGNEE/CHA");
            entity.Property(e => e.DestinationDnReceived)
                .HasColumnType("datetime")
                .HasColumnName("DESTINATION DN RECEIVED");
            entity.Property(e => e.DocumentsCouriedToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("DOCUMENTS COURIED TO CONSIGNEE");
            entity.Property(e => e.DocumentsReceivedAck)
                .HasColumnType("datetime")
                .HasColumnName("DOCUMENTS RECEIVED ACK");
            entity.Property(e => e.DraftConfirmationReceivedFromConsignee)
                .HasColumnType("datetime")
                .HasColumnName("DRAFT CONFIRMATION RECEIVED FROM CONSIGNEE");
            entity.Property(e => e.FactoryPickupDate)
                .HasColumnType("datetime")
                .HasColumnName("FACTORY PICKUP DATE");
            entity.Property(e => e.FreightBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("FREIGHT BILL RECEIVED");
            entity.Property(e => e.IgmFilingManfestation)
                .HasColumnType("datetime")
                .HasColumnName("IGM FILING/MANFESTATION");
            entity.Property(e => e.InvoiceGenerationDate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE GENERATION DATE");
            entity.Property(e => e.InvoiceIssuedToCustomer)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ISSUED TO CUSTOMER");
            entity.Property(e => e.LinerInvoiceReceived)
                .HasColumnType("datetime")
                .HasColumnName("LINER INVOICE RECEIVED");
            entity.Property(e => e.PreAlertDocsSent)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT DOCS SENT");
            entity.Property(e => e.PreAlertReceived)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT RECEIVED");
            entity.Property(e => e.PreAlertSentToConsignee)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT TO CONSIGNEE");
            entity.Property(e => e.ShipmentClosed)
                .HasColumnType("datetime")
                .HasColumnName("SHIPMENT CLOSED");
            entity.Property(e => e.ShippedOnBoard)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPED ON BOARD");
            entity.Property(e => e.Transhippment)
                .HasColumnType("datetime")
                .HasColumnName("TRANSHIPPMENT");
            entity.Property(e => e.TransportBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("TRANSPORT BILL RECEIVED");
            entity.Property(e => e.VesselArrivalAtDestination)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL ARRIVAL AT DESTINATION");
            entity.Property(e => e.VesselDeparture)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL DEPARTURE");
        });

        modelBuilder.Entity<VwStatusPendingVendorBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_StatusPendingVendorBills");

            entity.Property(e => e.Ata)
                .HasColumnType("datetime")
                .HasColumnName("ATA");
            entity.Property(e => e.Atd)
                .HasColumnType("datetime")
                .HasColumnName("ATD");
            entity.Property(e => e.BillStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BILL STATUS");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.CostsheetVendor)
                .HasMaxLength(100)
                .HasColumnName("COSTSHEET_VENDOR");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfShipment)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("Mode of shipment");
            entity.Property(e => e.PayingParty).HasMaxLength(100);
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.VendorBillAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VendorBillDate).HasColumnType("datetime");
            entity.Property(e => e.VendorBillNumber).HasMaxLength(20);
        });

        modelBuilder.Entity<VwStatusReportAir>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_statusReportAir");

            entity.Property(e => e.AgeingCourierSent).HasColumnName("AGEING COURIER SENT");
            entity.Property(e => e.AgeingPreAlert).HasColumnName("AGEING PRE ALERT");
            entity.Property(e => e.BillingPatry)
                .HasMaxLength(100)
                .HasColumnName("BILLING PATRY");
            entity.Property(e => e.ClearanceBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE BILL RECEIVED");
            entity.Property(e => e.ClearanceDone)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE DONE");
            entity.Property(e => e.CourierSentOn)
                .HasColumnType("datetime")
                .HasColumnName("COURIER SENT ON");
            entity.Property(e => e.DueDateClearanceDone)
                .HasColumnType("datetime")
                .HasColumnName("DUE DATE CLEARANCE DONE");
            entity.Property(e => e.DueDateCourierSent)
                .HasColumnType("datetime")
                .HasColumnName("DUE DATE COURIER SENT");
            entity.Property(e => e.DueDatePreAlert)
                .HasColumnType("datetime")
                .HasColumnName("DUE DATE PRE ALERT");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.InvoiceAttachedOn)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ATTACHED ON");
            entity.Property(e => e.InvoiceRaisedOn)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE RAISED ON");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PreAlertSentOn)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT ON");
            entity.Property(e => e.User)
                .HasMaxLength(100)
                .HasColumnName("USER");
        });

        modelBuilder.Entity<VwStatusReportAirChn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_statusReportAirCHN");

            entity.Property(e => e.AgeingClearanceDone).HasColumnName("AGEING CLEARANCE DONE");
            entity.Property(e => e.AgeingCourierSent).HasColumnName("AGEING COURIER SENT");
            entity.Property(e => e.AgeingPreAlert).HasColumnName("AGEING PRE ALERT");
            entity.Property(e => e.BillingPatry)
                .HasMaxLength(100)
                .HasColumnName("BILLING PATRY");
            entity.Property(e => e.ClearanceBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE BILL RECEIVED");
            entity.Property(e => e.ClearanceDone)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE DONE");
            entity.Property(e => e.CourierSentOn)
                .HasColumnType("datetime")
                .HasColumnName("COURIER SENT ON");
            entity.Property(e => e.DueDateClearanceDone)
                .HasColumnType("datetime")
                .HasColumnName("DUE DATE CLEARANCE DONE");
            entity.Property(e => e.DueDateCourierSent)
                .HasColumnType("datetime")
                .HasColumnName("DUE DATE COURIER SENT");
            entity.Property(e => e.DueDatePreAlert)
                .HasColumnType("datetime")
                .HasColumnName("DUE DATE PRE ALERT");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.InvoiceAttachedOn)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ATTACHED ON");
            entity.Property(e => e.InvoiceRaisedOn)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE RAISED ON");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PreAlertSentOn)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT ON");
        });

        modelBuilder.Entity<VwStatusReportOcean>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_statusReportOcean");

            entity.Property(e => e.AgeingCourierSent).HasColumnName("AGEING COURIER SENT");
            entity.Property(e => e.AgeingPreAlert).HasColumnName("AGEING PRE ALERT");
            entity.Property(e => e.BillingPatry)
                .HasMaxLength(100)
                .HasColumnName("BILLING PATRY");
            entity.Property(e => e.ClearanceBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE BILL RECEIVED");
            entity.Property(e => e.ClearanceDone)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE DONE");
            entity.Property(e => e.CourierSentOn)
                .HasColumnType("datetime")
                .HasColumnName("COURIER SENT ON");
            entity.Property(e => e.DueDateClearanceDone)
                .HasColumnType("datetime")
                .HasColumnName("DUE DATE CLEARANCE DONE");
            entity.Property(e => e.DueDateCourierSent)
                .HasColumnType("datetime")
                .HasColumnName("DUE DATE COURIER SENT");
            entity.Property(e => e.DueDatePreAlert)
                .HasColumnType("datetime")
                .HasColumnName("DUE DATE PRE ALERT");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.InvoiceAttachedOn)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ATTACHED ON");
            entity.Property(e => e.InvoiceRaisedOn)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE RAISED ON");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PreAlertSentOn)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT ON");
            entity.Property(e => e.User)
                .HasMaxLength(100)
                .HasColumnName("USER");
        });

        modelBuilder.Entity<VwStatusReportOceanChn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_statusReportOceanCHN");

            entity.Property(e => e.AgeingClearanceDone).HasColumnName("AGEING CLEARANCE DONE");
            entity.Property(e => e.AgeingCourierSent).HasColumnName("AGEING COURIER SENT");
            entity.Property(e => e.AgeingPreAlert).HasColumnName("AGEING PRE ALERT");
            entity.Property(e => e.BillingPatry)
                .HasMaxLength(100)
                .HasColumnName("BILLING PATRY");
            entity.Property(e => e.ClearanceBillReceived)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE BILL RECEIVED");
            entity.Property(e => e.ClearanceDone)
                .HasColumnType("datetime")
                .HasColumnName("CLEARANCE DONE");
            entity.Property(e => e.CourierSentOn)
                .HasColumnType("datetime")
                .HasColumnName("COURIER SENT ON");
            entity.Property(e => e.DueDateClearanceDone)
                .HasColumnType("datetime")
                .HasColumnName("DUE DATE CLEARANCE DONE");
            entity.Property(e => e.DueDateCourierSent)
                .HasColumnType("datetime")
                .HasColumnName("DUE DATE COURIER SENT");
            entity.Property(e => e.DueDatePreAlert)
                .HasColumnType("datetime")
                .HasColumnName("DUE DATE PRE ALERT");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.InvoiceAttachedOn)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE ATTACHED ON");
            entity.Property(e => e.InvoiceRaisedOn)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE RAISED ON");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PreAlertSentOn)
                .HasColumnType("datetime")
                .HasColumnName("PRE ALERT SENT ON");
        });

        modelBuilder.Entity<VwTaskList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_TaskList");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.LeadId).HasColumnName("LeadID");
            entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");
            entity.Property(e => e.Priority)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(100);
            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.TaskStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaskTypeName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Tt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TT");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwTeu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_TEU");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.JobMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("JOB_MONTH");
            entity.Property(e => e.OceanCarrierName).HasMaxLength(30);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40ot).HasColumnName("40OT");
        });

        modelBuilder.Entity<VwTeuI>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_TEU_I");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.JobMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("JOB_MONTH");
            entity.Property(e => e.OceanCarrierName).HasMaxLength(30);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e._20ft).HasColumnName("20FT");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._20hc).HasColumnName("20HC");
            entity.Property(e => e._20ot).HasColumnName("20OT");
            entity.Property(e => e._40ft).HasColumnName("40FT");
            entity.Property(e => e._40gp).HasColumnName("40GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
            entity.Property(e => e._40ot).HasColumnName("40OT");
        });

        modelBuilder.Entity<VwTotalContainersPerCargo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_TotalContainersPerCargo");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
        });

        modelBuilder.Entity<VwTotalTeu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_TotalTEU");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Teu)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("TEU");
        });

        modelBuilder.Entity<VwVendorBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_VendorBills");

            entity.Property(e => e.BillStatus).HasMaxLength(100);
            entity.Property(e => e.BillUploaded)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("BILL_UPLOADED");
            entity.Property(e => e.CargoDocumentId).HasColumnName("CargoDocumentID");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PayingParty).HasMaxLength(100);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Remarks).HasMaxLength(100);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VendorBillAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VendorBillDate).HasColumnType("datetime");
            entity.Property(e => e.VendorBillNumber).HasMaxLength(20);
        });

        modelBuilder.Entity<VwWebArkasHbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WebArkasHBL");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.DestinationAgent).HasMaxLength(100);
            entity.Property(e => e.Hblid).HasColumnName("HBLID");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OriginAgent).HasMaxLength(100);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Shipper).HasMaxLength(100);
        });

        modelBuilder.Entity<VwWebCargoDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WebCargoDocuments");

            entity.Property(e => e.CargoDocumentId).HasColumnName("CargoDocumentID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.DocumentType).HasMaxLength(30);
            entity.Property(e => e.Ftplink)
                .HasMaxLength(4000)
                .HasColumnName("FTPLink");
            entity.Property(e => e.IsVisibleToCustomer).HasColumnName("isVisibleToCustomer");
            entity.Property(e => e.Remarks).HasMaxLength(100);
        });

        modelBuilder.Entity<VwWebCargoList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WebCargoList");

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.BookingNumber).HasMaxLength(60);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ConsigneeId).HasColumnName("ConsigneeID");
            entity.Property(e => e.CreatedBys)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cycle)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("CYCLE");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Invoiceno).HasColumnName("invoiceno");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBys)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OceanLine).HasMaxLength(60);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OpportunityOwnerId).HasColumnName("OpportunityOwnerID");
            entity.Property(e => e.OriginAgent).HasMaxLength(100);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Vessel).HasMaxLength(50);
        });

        modelBuilder.Entity<VwWebCargoListDelivered>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WebCargoListDelivered");

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.BookingNumber).HasMaxLength(60);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.ConsigneeId).HasColumnName("ConsigneeID");
            entity.Property(e => e.CreatedBys)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cycle)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("CYCLE");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Invoiceno).HasColumnName("invoiceno");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MasterNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBys)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OceanLine).HasMaxLength(60);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OpportunityOwnerId).HasColumnName("OpportunityOwnerID");
            entity.Property(e => e.OriginAgent).HasMaxLength(100);
            entity.Property(e => e.Pod)
                .HasMaxLength(50)
                .HasColumnName("POD");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .HasColumnName("POL");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
            entity.Property(e => e.TransportDirection)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Vessel).HasMaxLength(50);
        });

        modelBuilder.Entity<VwWebCargoPackage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WebCargoPackages");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoPackId).HasColumnName("CargoPackID");
            entity.Property(e => e.ContainerCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ContainerNumber).HasMaxLength(15);
            entity.Property(e => e.DisplayCommodityDescription).HasMaxLength(100);
            entity.Property(e => e.DisplayContainerText).HasMaxLength(48);
            entity.Property(e => e.DisplayDimensions)
                .HasMaxLength(63)
                .IsUnicode(false);
            entity.Property(e => e.DisplayGrossWeight)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DisplayInvoiceNo).HasMaxLength(30);
            entity.Property(e => e.DisplayNetWeight)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DisplayVolume)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DisplayVolumeWeight)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(30);
            entity.Property(e => e.Length).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PackageType).HasMaxLength(30);
            entity.Property(e => e.VolumeCbm)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("VolumeCBM");
            entity.Property(e => e.VolumeWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VwWebCargoStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WebCargoStatus");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoStatusDate).HasColumnType("datetime");
            entity.Property(e => e.CargoStatusId).HasColumnName("CargoStatusID");
            entity.Property(e => e.CargoStatusName).HasMaxLength(50);
            entity.Property(e => e.IsExpected).HasColumnName("isExpected");
            entity.Property(e => e.IsWebTracking).HasColumnName("isWebTracking");
            entity.Property(e => e.StatusRemarks).HasMaxLength(100);
        });

        modelBuilder.Entity<VwWebDoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WebDocs");

            entity.Property(e => e.CargoDocumentId).HasColumnName("CargoDocumentID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DocLink).HasMaxLength(4000);
            entity.Property(e => e.DocumentFileType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DocumentType).HasMaxLength(30);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasMaxLength(100);
        });

        modelBuilder.Entity<VwWebDocsRp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WebDocsRP");

            entity.Property(e => e.CargoDocumentId).HasColumnName("CargoDocumentID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DocLink).HasMaxLength(4000);
            entity.Property(e => e.DocumentFileType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DocumentType).HasMaxLength(30);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasMaxLength(100);
        });

        modelBuilder.Entity<VwWebStatusRp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WebStatusRP");

            entity.Property(e => e.BookingDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING_DATE");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CustomClearanceDate)
                .HasColumnType("datetime")
                .HasColumnName("CUSTOM_CLEARANCE_DATE");
            entity.Property(e => e.Delivered)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERED");
            entity.Property(e => e.VesselArrival)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL_ARRIVAL");
            entity.Property(e => e.VesselDeparture)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL_DEPARTURE");
        });

        modelBuilder.Entity<VwWildRepublicCharge>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WildRepublic_Charges");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.Cargoid).HasColumnName("CARGOID");
            entity.Property(e => e.Chargedesc)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("CHARGEDESC");
            entity.Property(e => e.Currencycode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CURRENCYCODE");
        });

        modelBuilder.Entity<VwWildRepublicChargesDsr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WildRepublic_Charges_DSR");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CustomClearanceCharges)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("CUSTOM CLEARANCE CHARGES");
            entity.Property(e => e.DestinationCharges)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("DESTINATION CHARGES");
            entity.Property(e => e.FreightCharges)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("FREIGHT CHARGES");
            entity.Property(e => e.OtherCharges)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("OTHER CHARGES");
        });

        modelBuilder.Entity<VwWildRepublicDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WildRepublic_Documents");

            entity.Property(e => e.CommercialInvoice)
                .HasColumnType("datetime")
                .HasColumnName("COMMERCIAL INVOICE");
            entity.Property(e => e.Consignee).HasMaxLength(100);
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.Hbl)
                .HasColumnType("datetime")
                .HasColumnName("HBL");
            entity.Property(e => e.Invoice)
                .HasColumnType("datetime")
                .HasColumnName("INVOICE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mbl)
                .HasColumnType("datetime")
                .HasColumnName("MBL");
            entity.Property(e => e.PackingList)
                .HasColumnType("datetime")
                .HasColumnName("PACKING LIST");
            entity.Property(e => e.Shipper).HasMaxLength(100);
        });

        modelBuilder.Entity<VwWildRepublicDsr1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WildRepublicDSR1");

            entity.Property(e => e.ContainerNo)
                .HasMaxLength(15)
                .HasColumnName("CONTAINER NO");
            entity.Property(e => e.ContainerSize)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CONTAINER SIZE");
            entity.Property(e => e.ContainerValue)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CONTAINER VALUE");
            entity.Property(e => e.CustomerPo)
                .HasMaxLength(50)
                .HasColumnName("CUSTOMER PO");
            entity.Property(e => e.EstimatedAtPort)
                .HasColumnType("datetime")
                .HasColumnName("ESTIMATED AT PORT");
            entity.Property(e => e.EstimatedClearance)
                .HasColumnType("datetime")
                .HasColumnName("ESTIMATED CLEARANCE");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.Hbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL");
            entity.Property(e => e.Invoiceno)
                .HasMaxLength(20)
                .HasColumnName("INVOICENO");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.PortOfUnloading)
                .HasMaxLength(50)
                .HasColumnName("PORT OF UNLOADING");
            entity.Property(e => e.Remarks)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("REMARKS");
            entity.Property(e => e.Shipper).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Vessel)
                .HasMaxLength(50)
                .HasColumnName("VESSEL");
        });

        modelBuilder.Entity<VwWildRepublicDsr2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WildRepublicDSR2");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.ContainerNo)
                .HasMaxLength(15)
                .HasColumnName("CONTAINER NO");
            entity.Property(e => e.ContainerSize)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CONTAINER SIZE");
            entity.Property(e => e.ContainerValue)
                .HasMaxLength(4000)
                .HasColumnName("CONTAINER VALUE");
            entity.Property(e => e.CustomsClearanceCharges)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("CUSTOMS CLEARANCE CHARGES");
            entity.Property(e => e.DateDeliveredToWarehouse)
                .HasColumnType("datetime")
                .HasColumnName("DATE DELIVERED TO WAREHOUSE");
            entity.Property(e => e.DateOfBooking)
                .HasColumnType("datetime")
                .HasColumnName("DATE OF BOOKING");
            entity.Property(e => e.DateOfClearance)
                .HasColumnType("datetime")
                .HasColumnName("DATE OF CLEARANCE");
            entity.Property(e => e.DateOfDeliveryToPort)
                .HasColumnType("datetime")
                .HasColumnName("DATE OF DELIVERY TO PORT");
            entity.Property(e => e.DateOfDispatch)
                .HasColumnType("datetime")
                .HasColumnName("DATE OF DISPATCH");
            entity.Property(e => e.DestinationCharges)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("DESTINATION CHARGES");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.FreightCharges)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("FREIGHT CHARGES");
            entity.Property(e => e.Hbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL");
            entity.Property(e => e.InvoiceNoFretlog)
                .HasMaxLength(20)
                .HasColumnName("Invoice No - FRETLOG");
            entity.Property(e => e.InvoiceNoWildRepublic).HasColumnName("Invoice No - Wild Republic");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MBL");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.OtherChargesIfAny)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("OTHER CHARGES - IF ANY");
            entity.Property(e => e.PortOfUnloading)
                .HasMaxLength(50)
                .HasColumnName("PORT OF UNLOADING");
            entity.Property(e => e.Remarks).HasColumnName("REMARKS");
            entity.Property(e => e.Shipper).HasMaxLength(4000);
            entity.Property(e => e.Status)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Vessel)
                .HasMaxLength(50)
                .HasColumnName("VESSEL");
        });

        modelBuilder.Entity<VwWildRepublicPartDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WildRepublic_PartDetails");

            entity.Property(e => e.CargoPackId).HasColumnName("CargoPackID");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MarksAndNumbers)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.PackageDescription).HasMaxLength(100);
            entity.Property(e => e.PartNumber).HasMaxLength(128);
            entity.Property(e => e.PartQty).HasMaxLength(128);
            entity.Property(e => e.Ponumber)
                .HasMaxLength(128)
                .HasColumnName("PONumber");
        });

        modelBuilder.Entity<VwWildRepublicStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WildRepublic_Status");

            entity.Property(e => e.BookingDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOKING_DATE");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CustomClearanceDate)
                .HasColumnType("datetime")
                .HasColumnName("CUSTOM_CLEARANCE_DATE");
            entity.Property(e => e.Delivered)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERED");
            entity.Property(e => e.VesselArrival)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL_ARRIVAL");
            entity.Property(e => e.VesselDeparture)
                .HasColumnType("datetime")
                .HasColumnName("VESSEL_DEPARTURE");
        });

        modelBuilder.Entity<VwWildRepublicWebDoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_WildRepublic_WebDocs");

            entity.Property(e => e.CargoDocumentId).HasColumnName("CargoDocumentID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DocLink).HasMaxLength(4000);
            entity.Property(e => e.DocumentFileType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DocumentType).HasMaxLength(30);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasMaxLength(100);
        });

        modelBuilder.Entity<VwXingdaReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_XingdaReport");

            entity.Property(e => e.Ata)
                .HasColumnType("date")
                .HasColumnName("ATA");
            entity.Property(e => e.Atd)
                .HasColumnType("date")
                .HasColumnName("ATD");
            entity.Property(e => e.Bl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BL");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.Hbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.Invoicedate)
                .HasColumnType("datetime")
                .HasColumnName("INVOICEDATE");
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pallets).HasColumnName("PALLETS");
            entity.Property(e => e.Plant)
                .HasMaxLength(100)
                .HasColumnName("PLANT");
            entity.Property(e => e.Separators).HasColumnName("SEPARATORS");
            entity.Property(e => e.Spools).HasColumnName("SPOOLS");
            entity.Property(e => e._40hc).HasColumnName("40HC");
        });

        modelBuilder.Entity<VwXingdaReportMumbai>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_XingdaReport_Mumbai");

            entity.Property(e => e.ArrivalDateIntoCfs)
                .HasColumnType("datetime")
                .HasColumnName("ARRIVAL DATE INTO CFS");
            entity.Property(e => e.Ata)
                .HasColumnType("date")
                .HasColumnName("ATA");
            entity.Property(e => e.Atd)
                .HasColumnType("date")
                .HasColumnName("ATD");
            entity.Property(e => e.Bl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BL");
            entity.Property(e => e.CargoPickupDate)
                .HasColumnType("datetime")
                .HasColumnName("CARGO PICKUP DATE");
            entity.Property(e => e.ContainerNos).HasColumnName("ContainerNOS");
            entity.Property(e => e.CustomsClearanceDate)
                .HasColumnType("datetime")
                .HasColumnName("CUSTOMS CLEARANCE DATE");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.Hbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(30);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pallet).HasColumnName("PALLET");
            entity.Property(e => e.Plant)
                .HasMaxLength(100)
                .HasColumnName("PLANT");
            entity.Property(e => e.SbdateOutput).HasColumnName("SBDate_Output");
            entity.Property(e => e.SbnoOutput).HasColumnName("SBNO_Output");
            entity.Property(e => e.Seperator).HasColumnName("SEPERATOR");
            entity.Property(e => e.ShipperInformDate)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPER INFORM DATE");
            entity.Property(e => e.Spools).HasColumnName("SPOOLS");
            entity.Property(e => e.StuffingDateAtCfs)
                .HasColumnType("datetime")
                .HasColumnName("STUFFING DATE AT CFS");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._40hc).HasColumnName("40HC");
        });

        modelBuilder.Entity<VwXingdaReportNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_XingdaReport_new");

            entity.Property(e => e.ArrivalDateIntoCfs)
                .HasColumnType("datetime")
                .HasColumnName("arrival date into cfs");
            entity.Property(e => e.Ata)
                .HasColumnType("date")
                .HasColumnName("ATA");
            entity.Property(e => e.Atd)
                .HasColumnType("date")
                .HasColumnName("ATD");
            entity.Property(e => e.Bl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BL");
            entity.Property(e => e.CargoPickupDate)
                .HasColumnType("datetime")
                .HasColumnName("cargo pickup date");
            entity.Property(e => e.ContainerNos).HasColumnName("ContainerNOS");
            entity.Property(e => e.CustomsClearanceDate)
                .HasColumnType("datetime")
                .HasColumnName("customs clearance date");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.Hbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL");
            entity.Property(e => e.Invoicedate)
                .HasColumnType("datetime")
                .HasColumnName("invoicedate");
            entity.Property(e => e.Invoicenumber)
                .HasMaxLength(30)
                .HasColumnName("invoicenumber");
            entity.Property(e => e.Jobno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("jobno");
            entity.Property(e => e.Pallet).HasColumnName("pallet");
            entity.Property(e => e.Plant)
                .HasMaxLength(100)
                .HasColumnName("PLANT");
            entity.Property(e => e.SbdateOutput).HasColumnName("sbdate_output");
            entity.Property(e => e.SbnoOutput).HasColumnName("sbno_output");
            entity.Property(e => e.Seperator).HasColumnName("seperator");
            entity.Property(e => e.ShipperInformDate)
                .HasColumnType("datetime")
                .HasColumnName("shipper inform date");
            entity.Property(e => e.Spools).HasColumnName("spools");
            entity.Property(e => e.StuffingDateAtCfs)
                .HasColumnType("datetime")
                .HasColumnName("stuffing date at cfs");
            entity.Property(e => e._20gp).HasColumnName("20GP");
            entity.Property(e => e._40hc).HasColumnName("40hc");
        });

        modelBuilder.Entity<VwXingdaReportNew2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_XingdaReport_new2");

            entity.Property(e => e.Ata)
                .HasColumnType("date")
                .HasColumnName("ATA");
            entity.Property(e => e.Atd)
                .HasColumnType("date")
                .HasColumnName("ATD");
            entity.Property(e => e.Bl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BL");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Eta)
                .HasColumnType("date")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("date")
                .HasColumnName("ETD");
            entity.Property(e => e.Hbl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBL");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(30);
            entity.Property(e => e.JobNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pallet).HasColumnName("PALLET");
            entity.Property(e => e.Plant)
                .HasMaxLength(100)
                .HasColumnName("PLANT");
            entity.Property(e => e.Seperator).HasColumnName("SEPERATOR");
            entity.Property(e => e.Spools).HasColumnName("SPOOLS");
            entity.Property(e => e._40hc).HasColumnName("40HC");
        });

        modelBuilder.Entity<VwreportCustomerWiseProfitMonthly>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwreport_CustomerWiseProfitMonthly");

            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .HasColumnName("ACCOUNT_NAME");
            entity.Property(e => e.JobMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("JOB_MONTH");
            entity.Property(e => e.Officename)
                .HasMaxLength(100)
                .HasColumnName("OFFICENAME");
            entity.Property(e => e.ProfitInr)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("PROFIT(INR)");
        });

        modelBuilder.Entity<VwreportTopCustomersByProfit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwreport_TopCustomersByProfit");

            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .HasColumnName("ACCOUNT_NAME");
            entity.Property(e => e.Officename)
                .HasMaxLength(100)
                .HasColumnName("OFFICENAME");
            entity.Property(e => e.Profit)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("PROFIT");
        });

        modelBuilder.Entity<WebReportAccess>(entity =>
        {
            entity.ToTable("WebReportAccess");

            entity.Property(e => e.WebReportAccessId).HasColumnName("WebReportAccessID");
            entity.Property(e => e.WebReportId).HasColumnName("WebReportID");
            entity.Property(e => e.WebUserId).HasColumnName("WebUserID");

            entity.HasOne(d => d.WebReport).WithMany(p => p.WebReportAccesses)
                .HasForeignKey(d => d.WebReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WebReportAccess_WebReportMaster");
        });

        modelBuilder.Entity<WebReportFilter>(entity =>
        {
            entity.Property(e => e.WebReportFilterId).HasColumnName("WebReportFilterID");
            entity.Property(e => e.IsRequired).HasColumnName("isRequired");
            entity.Property(e => e.ReportColumnName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReportColumnType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WebReportId).HasColumnName("WebReportID");

            entity.HasOne(d => d.WebReport).WithMany(p => p.WebReportFilters)
                .HasForeignKey(d => d.WebReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WebReportFilters_WebReportMaster");
        });

        modelBuilder.Entity<WebReportMaster>(entity =>
        {
            entity.HasKey(e => e.WebReportId);

            entity.ToTable("WebReportMaster");

            entity.Property(e => e.WebReportId).HasColumnName("WebReportID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.WebReportName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebRpair>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("webRPAir");

            entity.Property(e => e.Airline).HasMaxLength(255);
            entity.Property(e => e.Awb)
                .HasMaxLength(255)
                .HasColumnName("AWB");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoPackId).HasColumnName("CargoPackID");
            entity.Property(e => e.CargoPickupDate).HasColumnType("datetime");
            entity.Property(e => e.Consignee).HasMaxLength(255);
            entity.Property(e => e.CustomsClearanceDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.JobNo).HasMaxLength(255);
            entity.Property(e => e.Pod)
                .HasMaxLength(255)
                .HasColumnName("POD");
            entity.Property(e => e.Remarks).HasMaxLength(1000);
            entity.Property(e => e.Shipper).HasMaxLength(255);
            entity.Property(e => e.ShipperInvoiceNo).HasMaxLength(255);
            entity.Property(e => e.Status)
                .HasMaxLength(1000)
                .HasColumnName("STATUS");
            entity.Property(e => e.Weight).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<WebRpsea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("webRPSea");

            entity.Property(e => e.ArrivalAtPort).HasColumnType("datetime");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CargoPackId).HasColumnName("CargoPackID");
            entity.Property(e => e.JobNo).HasMaxLength(255);
            entity.Property(e => e.PickupDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(1000);
            entity.Property(e => e.Shipper).HasMaxLength(255);
            entity.Property(e => e.ShipperInvoiceNo).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.StuffingDate).HasColumnType("datetime");
            entity.Property(e => e.Weight).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<WebUser>(entity =>
        {
            entity.Property(e => e.WebUserId).HasColumnName("WebUserID");
            entity.Property(e => e.CompanyDisplayName).HasMaxLength(150);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateDeleted)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DateLocked).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.LinkedDesktopUserId).HasColumnName("LinkedDesktopUserID");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.UserDisplayName).HasMaxLength(50);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserType)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebUserAccess>(entity =>
        {
            entity.ToTable("WebUserAccess");

            entity.Property(e => e.WebUserAccessId).HasColumnName("WebUserAccessID");
            entity.Property(e => e.WebUserCompanyId).HasColumnName("WebUserCompanyID");
            entity.Property(e => e.WebUserId).HasColumnName("WebUserID");

            entity.HasOne(d => d.WebUser).WithMany(p => p.WebUserAccesses)
                .HasForeignKey(d => d.WebUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WebUserAccess_WebUsers");
        });

        modelBuilder.Entity<WorldCity>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AccentCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Column10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 10");
            entity.Property(e => e.Column11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 11");
            entity.Property(e => e.Column7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 7");
            entity.Property(e => e.Column8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 8");
            entity.Property(e => e.Column9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 9");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Latitude)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Longitude)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Population)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
