# Lending

<!-- Start Codat Library Description -->
Lending helps you make smarter credit decisions on small businesses by enabling you to pull your customers' latest data from the operating systems they are already using. You can use that data for automating decisioning and surfacing new insights on the customer, all via one API.
<!-- End Codat Library Description -->

<!-- Start Summary [summary] -->
## Summary

Lending API: Our Lending API helps you make smarter credit decisions on small businesses by enabling you to pull your customers' latest data from accounting, banking, and commerce software they are already using. It also includes features to help providers verify the accuracy of data and process it more efficiently.

The Lending API is built on top of the latest accounting, commerce, and banking data, providing you with the most important data points you need to get a full picture of SMB creditworthiness and make a comprehensive assessment of your customers.

[Explore product](https://docs.codat.io/lending/overview) | [See OpenAPI spec](https://github.com/codatio/oas)

<!-- Start Codat Tags Table -->
## Endpoints

| Endpoints | Description |
| :- |:- |
| Companies | Create and manage your SMB users' companies. |
| Connections | Create new and manage existing data connections for a company. |
| Bank statements | Retrieve banking data from linked bank accounts. |
| Sales | Retrieve standardized sales data from a linked commerce software. |
| Financial statements | Financial data and reports from a linked accounting software. |
| Liabilities | Debt and other liabilities. |
| Accounts payable | Data from a linked accounting software representing money the business owes money to its suppliers. |
| Accounts receivable | Data from a linked accounting software representing money owed to the business for sold goods or services. |
| Transactions | Data from a linked accounting software representing transactions. |
| Company info | View company information fetched from the source platform. |
| Data integrity | Match mutable accounting data with immutable banking data to increase confidence in financial data. |
| Excel reports | Download reports in Excel format. |
| Manage data | Control how data is retrieved from an integration. |
| File upload | Endpoints to manage uploaded files. |
| Loan writeback | Implement the [loan writeback](https://docs.codat.io/lending/guides/loan-writeback/introduction) procedure in your lending process to maintain an accurate position of a loan during the entire lending cycle. |
<!-- End Codat Tags Table -->
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents

* [SDK Installation](#sdk-installation)
* [SDK Example Usage](#sdk-example-usage)
* [Available Resources and Operations](#available-resources-and-operations)
* [Retries](#retries)
* [Error Handling](#error-handling)
* [Server Selection](#server-selection)
* [Authentication](#authentication)
<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### NuGet

To add the [NuGet](https://www.nuget.org/) package to a .NET project:
```bash
dotnet add package Codat.Lending
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference Codat/Lending/Codat.Lending.csproj
```
<!-- End SDK Installation [installation] -->

## Example Usage
<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [AccountingBankData](docs/sdks/accountingbankdata/README.md)

* [ListTransactions](docs/sdks/accountingbankdata/README.md#listtransactions) - List bank account transactions

#### [AccountingBankData.Accounts](docs/sdks/codatlendingaccounts/README.md)

* [List](docs/sdks/codatlendingaccounts/README.md#list) - List bank accounts
* [Get](docs/sdks/codatlendingaccounts/README.md#get) - Get bank account

### [AccountsPayable](docs/sdks/accountspayable/README.md)


#### [AccountsPayable.BillCreditNotes](docs/sdks/billcreditnotes/README.md)

* [List](docs/sdks/billcreditnotes/README.md#list) - List bill credit notes
* [Get](docs/sdks/billcreditnotes/README.md#get) - Get bill credit note

#### [AccountsPayable.BillPayments](docs/sdks/billpayments/README.md)

* [List](docs/sdks/billpayments/README.md#list) - List bill payments
* [Get](docs/sdks/billpayments/README.md#get) - Get bill payment

#### [AccountsPayable.Bills](docs/sdks/bills/README.md)

* [List](docs/sdks/bills/README.md#list) - List bills
* [Get](docs/sdks/bills/README.md#get) - Get bill
* [ListAttachments](docs/sdks/bills/README.md#listattachments) - List bill attachments
* [GetAttachment](docs/sdks/bills/README.md#getattachment) - Get bill attachment
* [DownloadAttachment](docs/sdks/bills/README.md#downloadattachment) - Download bill attachment

#### [AccountsPayable.Suppliers](docs/sdks/suppliers/README.md)

* [List](docs/sdks/suppliers/README.md#list) - List suppliers
* [Get](docs/sdks/suppliers/README.md#get) - Get supplier
* [ListAttachments](docs/sdks/suppliers/README.md#listattachments) - List supplier attachments
* [GetAttachment](docs/sdks/suppliers/README.md#getattachment) - Get supplier attachment
* [DownloadAttachment](docs/sdks/suppliers/README.md#downloadattachment) - Download supplier attachment

### [AccountsReceivable](docs/sdks/accountsreceivable/README.md)


#### [AccountsReceivable.CreditNotes](docs/sdks/creditnotes/README.md)

* [List](docs/sdks/creditnotes/README.md#list) - List credit notes
* [Get](docs/sdks/creditnotes/README.md#get) - Get credit note

#### [AccountsReceivable.Customers](docs/sdks/customers/README.md)

* [List](docs/sdks/customers/README.md#list) - List customers
* [Get](docs/sdks/customers/README.md#get) - Get customer
* [ListAttachments](docs/sdks/customers/README.md#listattachments) - List customer attachments
* [GetAttachment](docs/sdks/customers/README.md#getattachment) - Get customer attachment
* [DownloadAttachment](docs/sdks/customers/README.md#downloadattachment) - Download customer attachment

#### [AccountsReceivable.DirectIncomes](docs/sdks/directincomes/README.md)

* [List](docs/sdks/directincomes/README.md#list) - List direct incomes
* [Get](docs/sdks/directincomes/README.md#get) - Get direct income
* [GetAttachment](docs/sdks/directincomes/README.md#getattachment) - Get direct income attachment
* [DownloadAttachment](docs/sdks/directincomes/README.md#downloadattachment) - Download direct income attachment
* [ListAttachments](docs/sdks/directincomes/README.md#listattachments) - List direct income attachments

#### [AccountsReceivable.Invoices](docs/sdks/invoices/README.md)

* [ListReconciled](docs/sdks/invoices/README.md#listreconciled) - List reconciled invoices
* [List](docs/sdks/invoices/README.md#list) - List invoices
* [Get](docs/sdks/invoices/README.md#get) - Get invoice
* [DownloadPdf](docs/sdks/invoices/README.md#downloadpdf) - Get invoice as PDF
* [ListAttachments](docs/sdks/invoices/README.md#listattachments) - List invoice attachments
* [GetAttachment](docs/sdks/invoices/README.md#getattachment) - Get invoice attachment
* [DownloadAttachment](docs/sdks/invoices/README.md#downloadattachment) - Download invoice attachment

#### [AccountsReceivable.Payments](docs/sdks/payments/README.md)

* [List](docs/sdks/payments/README.md#list) - List payments
* [Get](docs/sdks/payments/README.md#get) - Get payment

#### [AccountsReceivable.Reports](docs/sdks/codatlendingreports/README.md)

* [IsAgedDebtorsAvailable](docs/sdks/codatlendingreports/README.md#isageddebtorsavailable) - Aged debtors report available
* [GetAgedDebtors](docs/sdks/codatlendingreports/README.md#getageddebtors) - Aged debtors report
* [IsAgedCreditorsAvailable](docs/sdks/codatlendingreports/README.md#isagedcreditorsavailable) - Aged creditors report available
* [GetAgedCreditors](docs/sdks/codatlendingreports/README.md#getagedcreditors) - Aged creditors report

### [Banking](docs/sdks/banking/README.md)


#### [Banking.AccountBalances](docs/sdks/accountbalances/README.md)

* [List](docs/sdks/accountbalances/README.md#list) - List account balances

#### [Banking.Accounts](docs/sdks/codatlendingbankingaccounts/README.md)

* [List](docs/sdks/codatlendingbankingaccounts/README.md#list) - List accounts
* [Get](docs/sdks/codatlendingbankingaccounts/README.md#get) - Get account

#### [Banking.CategorizedStatement](docs/sdks/categorizedstatement/README.md)

* [Get](docs/sdks/categorizedstatement/README.md#get) - Get categorized bank statement

#### [Banking.TransactionCategories](docs/sdks/transactioncategories/README.md)

* [List](docs/sdks/transactioncategories/README.md#list) - List transaction categories
* [Get](docs/sdks/transactioncategories/README.md#get) - Get transaction category

#### [Banking.Transactions](docs/sdks/codatlendingtransactions/README.md)

* [List](docs/sdks/codatlendingtransactions/README.md#list) - List transactions
* [Get](docs/sdks/codatlendingtransactions/README.md#get) - Get bank transaction

### [BankStatements](docs/sdks/bankstatements/README.md)

* [GetUploadConfiguration](docs/sdks/bankstatements/README.md#getuploadconfiguration) - Get upload configuration
* [SetUploadConfiguration](docs/sdks/bankstatements/README.md#setuploadconfiguration) - Set upload configuration
* [StartUploadSession](docs/sdks/bankstatements/README.md#startuploadsession) - Start upload session
* [UploadBankStatementData](docs/sdks/bankstatements/README.md#uploadbankstatementdata) - Upload data
* [EndUploadSession](docs/sdks/bankstatements/README.md#enduploadsession) - End upload session


### [Companies](docs/sdks/companies/README.md)

* [List](docs/sdks/companies/README.md#list) - List companies
* [Create](docs/sdks/companies/README.md#create) - Create company
* [Update](docs/sdks/companies/README.md#update) - Update company
* [Delete](docs/sdks/companies/README.md#delete) - Delete a company
* [Get](docs/sdks/companies/README.md#get) - Get company

### [CompanyInfo](docs/sdks/companyinfo/README.md)

* [GetAccountingProfile](docs/sdks/companyinfo/README.md#getaccountingprofile) - Get company accounting profile
* [GetCommerceProfile](docs/sdks/companyinfo/README.md#getcommerceprofile) - Get company commerce profile

### [Connections](docs/sdks/connections/README.md)

* [List](docs/sdks/connections/README.md#list) - List connections
* [Create](docs/sdks/connections/README.md#create) - Create connection
* [Get](docs/sdks/connections/README.md#get) - Get connection
* [Delete](docs/sdks/connections/README.md#delete) - Delete connection
* [Unlink](docs/sdks/connections/README.md#unlink) - Unlink connection

### [DataIntegrity](docs/sdks/dataintegrity/README.md)

* [Status](docs/sdks/dataintegrity/README.md#status) - Get data integrity status
* [Summaries](docs/sdks/dataintegrity/README.md#summaries) - Get data integrity summaries
* [Details](docs/sdks/dataintegrity/README.md#details) - List data integrity details

### [ExcelReports](docs/sdks/excelreports/README.md)

* [Generate](docs/sdks/excelreports/README.md#generate) - Generate Excel report
* [GetStatus](docs/sdks/excelreports/README.md#getstatus) - Get Excel report status
* [Download](docs/sdks/excelreports/README.md#download) - Download Excel report

### [FileUpload](docs/sdks/fileupload/README.md)

* [ListUploaded](docs/sdks/fileupload/README.md#listuploaded) - List all files uploaded by a company
* [Download](docs/sdks/fileupload/README.md#download) - Download all files for a company
* [Upload](docs/sdks/fileupload/README.md#upload) - Upload files for a company

### [FinancialStatements](docs/sdks/financialstatements/README.md)


#### [FinancialStatements.Accounts](docs/sdks/accounts/README.md)

* [List](docs/sdks/accounts/README.md#list) - List accounts
* [Get](docs/sdks/accounts/README.md#get) - Get account

#### [FinancialStatements.BalanceSheet](docs/sdks/balancesheet/README.md)

* [GetCategorizedAccounts](docs/sdks/balancesheet/README.md#getcategorizedaccounts) - Get categorized balance sheet statement
* [Get](docs/sdks/balancesheet/README.md#get) - Get balance sheet

#### [FinancialStatements.CashFlow](docs/sdks/cashflow/README.md)

* [Get](docs/sdks/cashflow/README.md#get) - Get cash flow statement

#### [FinancialStatements.ProfitAndLoss](docs/sdks/profitandloss/README.md)

* [GetCategorizedAccounts](docs/sdks/profitandloss/README.md#getcategorizedaccounts) - Get categorized profit and loss statement
* [Get](docs/sdks/profitandloss/README.md#get) - Get profit and loss

### [Liabilities](docs/sdks/liabilities/README.md)

* [GenerateLoanTransactions](docs/sdks/liabilities/README.md#generateloantransactions) - Generate loan transactions report
* [ListLoanTransactions](docs/sdks/liabilities/README.md#listloantransactions) - List loan transactions
* [GenerateLoanSummary](docs/sdks/liabilities/README.md#generateloansummary) - Generate loan summaries report
* [GetLoanSummary](docs/sdks/liabilities/README.md#getloansummary) - Get loan summaries

### [LoanWriteback](docs/sdks/loanwriteback/README.md)


#### [LoanWriteback.Accounts](docs/sdks/codatlendingloanwritebackaccounts/README.md)

* [GetCreateModel](docs/sdks/codatlendingloanwritebackaccounts/README.md#getcreatemodel) - Get create account model
* [Create](docs/sdks/codatlendingloanwritebackaccounts/README.md#create) - Create account

#### [LoanWriteback.BankAccounts](docs/sdks/bankaccounts/README.md)

* [GetCreateUpdateModel](docs/sdks/bankaccounts/README.md#getcreateupdatemodel) - Get create/update bank account model
* [Create](docs/sdks/bankaccounts/README.md#create) - Create bank account

#### [LoanWriteback.BankTransactions](docs/sdks/banktransactions/README.md)

* [GetCreateModel](docs/sdks/banktransactions/README.md#getcreatemodel) - Get create bank account transactions model
* [Create](docs/sdks/banktransactions/README.md#create) - Create bank account transactions

#### [LoanWriteback.CreateOperations](docs/sdks/createoperations/README.md)

* [Get](docs/sdks/createoperations/README.md#get) - Get create operation
* [List](docs/sdks/createoperations/README.md#list) - List create operations

#### [LoanWriteback.DirectCosts](docs/sdks/codatlendingdirectcosts/README.md)

* [GetCreateModel](docs/sdks/codatlendingdirectcosts/README.md#getcreatemodel) - Get create direct cost model
* [Create](docs/sdks/codatlendingdirectcosts/README.md#create) - Create direct cost

#### [LoanWriteback.Payments](docs/sdks/codatlendingloanwritebackpayments/README.md)

* [GetCreateModel](docs/sdks/codatlendingloanwritebackpayments/README.md#getcreatemodel) - Get create payment model
* [Create](docs/sdks/codatlendingloanwritebackpayments/README.md#create) - Create payment

#### [LoanWriteback.SourceAccounts](docs/sdks/sourceaccounts/README.md)

* [Create](docs/sdks/sourceaccounts/README.md#create) - Create source account
* [CreateMapping](docs/sdks/sourceaccounts/README.md#createmapping) - Create bank feed account mapping

#### [LoanWriteback.Suppliers](docs/sdks/codatlendingsuppliers/README.md)

* [GetCreateUpdateModel](docs/sdks/codatlendingsuppliers/README.md#getcreateupdatemodel) - Get create/update supplier model
* [Create](docs/sdks/codatlendingsuppliers/README.md#create) - Create supplier

#### [LoanWriteback.Transfers](docs/sdks/codatlendingtransfers/README.md)

* [GetCreateModel](docs/sdks/codatlendingtransfers/README.md#getcreatemodel) - Get create transfer model
* [Create](docs/sdks/codatlendingtransfers/README.md#create) - Create transfer

### [ManageData](docs/sdks/managedata/README.md)

* [GetStatus](docs/sdks/managedata/README.md#getstatus) - Get data status

#### [ManageData.PullOperations](docs/sdks/pulloperations/README.md)

* [List](docs/sdks/pulloperations/README.md#list) - List pull operations
* [Get](docs/sdks/pulloperations/README.md#get) - Get pull operation

#### [ManageData.Refresh](docs/sdks/refresh/README.md)

* [AllDataTypes](docs/sdks/refresh/README.md#alldatatypes) - Refresh all data
* [DataType](docs/sdks/refresh/README.md#datatype) - Refresh data type

### [ManageReports](docs/sdks/managereports/README.md)

* [GenerateReport](docs/sdks/managereports/README.md#generatereport) - Generate report
* [ListReports](docs/sdks/managereports/README.md#listreports) - List reports

### [Sales](docs/sdks/sales/README.md)


#### [Sales.Customers](docs/sdks/codatlendingcustomers/README.md)

* [List](docs/sdks/codatlendingcustomers/README.md#list) - List customers
* [Get](docs/sdks/codatlendingcustomers/README.md#get) - Get customer

#### [Sales.Disputes](docs/sdks/disputes/README.md)

* [List](docs/sdks/disputes/README.md#list) - List disputes
* [Get](docs/sdks/disputes/README.md#get) - Get dispute

#### [Sales.Locations](docs/sdks/locations/README.md)

* [List](docs/sdks/locations/README.md#list) - List locations
* [Get](docs/sdks/locations/README.md#get) - Get location

#### [Sales.Metrics](docs/sdks/metrics/README.md)

* [GetRevenue](docs/sdks/metrics/README.md#getrevenue) - Get commerce revenue metrics
* [GetCustomerRetention](docs/sdks/metrics/README.md#getcustomerretention) - Get customer retention metrics
* [GetLifetimeValue](docs/sdks/metrics/README.md#getlifetimevalue) - Get lifetime value metrics

#### [Sales.Orders](docs/sdks/orders/README.md)

* [List](docs/sdks/orders/README.md#list) - List orders
* [Get](docs/sdks/orders/README.md#get) - Get order

#### [Sales.PaymentMethods](docs/sdks/paymentmethods/README.md)

* [List](docs/sdks/paymentmethods/README.md#list) - List payment methods
* [Get](docs/sdks/paymentmethods/README.md#get) - Get payment method

#### [Sales.Payments](docs/sdks/codatlendingpayments/README.md)

* [List](docs/sdks/codatlendingpayments/README.md#list) - List payments
* [Get](docs/sdks/codatlendingpayments/README.md#get) - Get payment

#### [Sales.ProductCategories](docs/sdks/productcategories/README.md)

* [List](docs/sdks/productcategories/README.md#list) - List product categories
* [Get](docs/sdks/productcategories/README.md#get) - Get product category

#### [Sales.Products](docs/sdks/products/README.md)

* [List](docs/sdks/products/README.md#list) - List products
* [Get](docs/sdks/products/README.md#get) - Get product

#### [Sales.Reports](docs/sdks/reports/README.md)

* [GetOrders](docs/sdks/reports/README.md#getorders) - Get orders report
* [GetRefunds](docs/sdks/reports/README.md#getrefunds) - Get refunds report

#### [Sales.Transactions](docs/sdks/codatlendingsalestransactions/README.md)

* [List](docs/sdks/codatlendingsalestransactions/README.md#list) - List transactions
* [Get](docs/sdks/codatlendingsalestransactions/README.md#get) - Get transaction

### [Transactions](docs/sdks/transactions/README.md)


#### [Transactions.AccountTransactions](docs/sdks/accounttransactions/README.md)

* [List](docs/sdks/accounttransactions/README.md#list) - List account transactions
* [Get](docs/sdks/accounttransactions/README.md#get) - Get account transaction

#### [Transactions.DirectCosts](docs/sdks/directcosts/README.md)

* [List](docs/sdks/directcosts/README.md#list) - List direct costs
* [Get](docs/sdks/directcosts/README.md#get) - Get direct cost
* [GetAttachment](docs/sdks/directcosts/README.md#getattachment) - Get direct cost attachment
* [DownloadAttachment](docs/sdks/directcosts/README.md#downloadattachment) - Download direct cost attachment
* [ListAttachments](docs/sdks/directcosts/README.md#listattachments) - List direct cost attachments

#### [Transactions.JournalEntries](docs/sdks/journalentries/README.md)

* [List](docs/sdks/journalentries/README.md#list) - List journal entries
* [Get](docs/sdks/journalentries/README.md#get) - Get journal entry

#### [Transactions.Journals](docs/sdks/journals/README.md)

* [List](docs/sdks/journals/README.md#list) - List journals
* [Get](docs/sdks/journals/README.md#get) - Get journal

#### [Transactions.Transfers](docs/sdks/transfers/README.md)

* [List](docs/sdks/transfers/README.md#list) - List transfers
* [Get](docs/sdks/transfers/README.md#get) - Get transfer

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(
    serverUrl: "https://api.codat.io",
    authHeader: "Basic BASE_64_ENCODED(API_KEY)"
);

ListCompaniesRequest req = new ListCompaniesRequest() {
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name         | Type   | Scheme  |
| ------------ | ------ | ------- |
| `AuthHeader` | apiKey | API key |

To authenticate with the API the `AuthHeader` parameter must be set when initializing the SDK client instance. For example:
```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries. If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API. However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Companies.ListAsync(
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
    ),
    req
);

// handle response
```

If you'd like to override the default retry strategy for all operations that support retries, you can use the `RetryConfig` optional parameter when intitializing the SDK:
```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
    ),
    authHeader: "Basic BASE_64_ENCODED(API_KEY)"
);

ListCompaniesRequest req = new ListCompaniesRequest() {
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```
<!-- End Retries [retries] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `Codat.Lending.Models.Errors.SDKException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `StatusCode`  | *int*                 | The HTTP status code  |
| `RawResponse` | *HttpResponseMessage* | The raw HTTP response |
| `Body`        | *string*              | The response content  |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `ListAsync` method throws the following exceptions:

| Error Type                               | Status Code                            | Content Type     |
| ---------------------------------------- | -------------------------------------- | ---------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503 | application/json |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*            |

### Example

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;
using System;
using Codat.Lending.Models.Errors;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

try
{
    ListCompaniesRequest req = new ListCompaniesRequest() {
        Page = 1,
        PageSize = 100,
        Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
        OrderBy = "-modifiedDate",
    };

    var res = await sdk.Companies.ListAsync(req);

    // handle response
}
catch (Exception ex)
{
    if (ex is ErrorMessage)
    {
        // Handle exception data
        throw;
    }
    else if (ex is Codat.Lending.Models.Errors.SDKException)
    {
        // Handle default exception
        throw;
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

<!-- Start Codat Support Notes -->
### Support

If you encounter any challenges while utilizing our SDKs, please don't hesitate to reach out for assistance. 
You can raise any issues by contacting your dedicated Codat representative or reaching out to our [support team](mailto:support@codat.io).
We're here to help ensure a smooth experience for you.
<!-- End Codat Support Notes -->

<!-- Start Codat Generated By -->
### Library generated by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
<!-- End Codat Generated By -->