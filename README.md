# openapi

<!-- Start SDK Installation -->
## SDK Installation

### Nuget

```bash
dotnet add reference path/to/Codat.csproj
```
<!-- End SDK Installation -->

## SDK Example Usage
<!-- Start SDK Example Usage -->
```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Categories;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Categories.GetAccountCategory(request);
```
<!-- End SDK Example Usage -->

<!-- Start SDK Available Operations -->
## Available Resources and Operations


### [categories](docs/Sdks/Categories/README.md)

* [~~GetAccountCategory~~](docs/Sdks/Categories/README.md#getaccountcategory) - Get suggested and/or confirmed category for a specific account :warning: **Deprecated**
* [~~ListAccountsCategories~~](docs/Sdks/Categories/README.md#listaccountscategories) - List suggested and confirmed account categories :warning: **Deprecated**
* [~~ListAvailableAccountCategories~~](docs/Sdks/Categories/README.md#listavailableaccountcategories) - List account categories :warning: **Deprecated**
* [~~UpdateAccountCategory~~](docs/Sdks/Categories/README.md#updateaccountcategory) - Update account categories :warning: **Deprecated**
* [~~UpdateAccountsCategories~~](docs/Sdks/Categories/README.md#updateaccountscategories) - Confirm categories for accounts :warning: **Deprecated**

### [dataIntegrity](docs/Sdks/DataIntegrity/README.md)

* [GetDataIntegrityStatus](docs/Sdks/DataIntegrity/README.md#getdataintegritystatus) - Get data integrity status
* [GetDataIntegritySummaries](docs/Sdks/DataIntegrity/README.md#getdataintegritysummaries) - Get data integrity summary
* [ListDataTypeDataIntegrityDetails](docs/Sdks/DataIntegrity/README.md#listdatatypedataintegritydetails) - List data type data integrity

### [excelReports](docs/Sdks/ExcelReports/README.md)

* [GenerateExcelReport](docs/Sdks/ExcelReports/README.md#generateexcelreport) - Generate Excel report
* [GetAccountingMarketingMetrics](docs/Sdks/ExcelReports/README.md#getaccountingmarketingmetrics) - Get marketing metrics report
* [GetExcelReport](docs/Sdks/ExcelReports/README.md#getexcelreport) - Download Excel report
* [GetExcelReportGenerationStatus](docs/Sdks/ExcelReports/README.md#getexcelreportgenerationstatus) - Get Excel report status

### [reports](docs/Sdks/Reports/README.md)

* [GetAccountsForEnhancedBalanceSheet](docs/Sdks/Reports/README.md#getaccountsforenhancedbalancesheet) - Get enhanced balance sheet accounts
* [GetAccountsForEnhancedProfitAndLoss](docs/Sdks/Reports/README.md#getaccountsforenhancedprofitandloss) - Get enhanced profit and loss accounts
* [GetCommerceCustomerRetentionMetrics](docs/Sdks/Reports/README.md#getcommercecustomerretentionmetrics) - Get customer retention metrics
* [GetCommerceLifetimeValueMetrics](docs/Sdks/Reports/README.md#getcommercelifetimevaluemetrics) - Get lifetime value metric
* [GetCommerceOrdersMetrics](docs/Sdks/Reports/README.md#getcommerceordersmetrics) - Get orders report
* [GetCommerceRefundsMetrics](docs/Sdks/Reports/README.md#getcommercerefundsmetrics) - Get refunds report
* [GetCommerceRevenueMetrics](docs/Sdks/Reports/README.md#getcommercerevenuemetrics) - Get commerce revenue metrics
* [~~GetEnhancedBalanceSheet~~](docs/Sdks/Reports/README.md#getenhancedbalancesheet) - Get enhanced balance sheet report :warning: **Deprecated**
* [GetEnhancedCashFlowTransactions](docs/Sdks/Reports/README.md#getenhancedcashflowtransactions) - Get enhanced cash flow report
* [~~GetEnhancedFinancialMetrics~~](docs/Sdks/Reports/README.md#getenhancedfinancialmetrics) - List financial metrics :warning: **Deprecated**
* [GetEnhancedInvoicesReport](docs/Sdks/Reports/README.md#getenhancedinvoicesreport) - Get enhanced invoices report
* [~~GetEnhancedProfitAndLoss~~](docs/Sdks/Reports/README.md#getenhancedprofitandloss) - Get enhanced profit and loss report :warning: **Deprecated**
* [GetRecurringRevenueMetrics](docs/Sdks/Reports/README.md#getrecurringrevenuemetrics) - Get key subscription revenue metrics
* [RequestRecurringRevenueMetrics](docs/Sdks/Reports/README.md#requestrecurringrevenuemetrics) - Generate key subscription revenue metrics
<!-- End SDK Available Operations -->

### Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

### Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release !

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
