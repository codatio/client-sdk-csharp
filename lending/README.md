# Lending

<!-- Start Codat Library Description -->
Lending helps you make smarter credit decisions on small businesses by enabling you to pull your customers' latest data from the operating systems they are already using. You can use that data for automating decisioning and surfacing new insights on the customer, all via one API.
<!-- End Codat Library Description -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### Nuget

```bash
dotnet add package Codat.Lending
```
<!-- End SDK Installation [installation] -->

## Example Usage
<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CompanyRequestBody req = new CompanyRequestBody() {
    Description = "Requested early access to the new financing scheme.",
    Name = "Bank of Dave",
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

### [Companies](docs/sdks/companies/README.md)

* [Create](docs/sdks/companies/README.md#create) - Create company
* [Delete](docs/sdks/companies/README.md#delete) - Delete a company
* [Get](docs/sdks/companies/README.md#get) - Get company
* [List](docs/sdks/companies/README.md#list) - List companies
* [Update](docs/sdks/companies/README.md#update) - Update company

### [Connections](docs/sdks/connections/README.md)

* [Create](docs/sdks/connections/README.md#create) - Create connection
* [Delete](docs/sdks/connections/README.md#delete) - Delete connection
* [Get](docs/sdks/connections/README.md#get) - Get connection
* [List](docs/sdks/connections/README.md#list) - List connections
* [Unlink](docs/sdks/connections/README.md#unlink) - Unlink connection


### [Transactions.AccountTransactions](docs/sdks/accounttransactions/README.md)

* [Get](docs/sdks/accounttransactions/README.md#get) - Get account transaction
* [List](docs/sdks/accounttransactions/README.md#list) - List account transactions

### [Transactions.DirectCosts](docs/sdks/codatlendingdirectcosts/README.md)

* [DownloadAttachment](docs/sdks/codatlendingdirectcosts/README.md#downloadattachment) - Download direct cost attachment
* [Get](docs/sdks/codatlendingdirectcosts/README.md#get) - Get direct cost
* [GetAttachment](docs/sdks/codatlendingdirectcosts/README.md#getattachment) - Get direct cost attachment
* [List](docs/sdks/codatlendingdirectcosts/README.md#list) - List direct costs
* [ListAttachments](docs/sdks/codatlendingdirectcosts/README.md#listattachments) - List direct cost attachments

### [Transactions.Transfers](docs/sdks/codatlendingtransfers/README.md)

* [Get](docs/sdks/codatlendingtransfers/README.md#get) - Get transfer
* [List](docs/sdks/codatlendingtransfers/README.md#list) - List transfers

### [Transactions.JournalEntries](docs/sdks/journalentries/README.md)

* [Get](docs/sdks/journalentries/README.md#get) - Get journal entry
* [List](docs/sdks/journalentries/README.md#list) - List journal entries

### [Transactions.Journals](docs/sdks/journals/README.md)

* [Get](docs/sdks/journals/README.md#get) - Get journal
* [List](docs/sdks/journals/README.md#list) - List journals

### [AccountingBankData](docs/sdks/codatlendingaccountingbankdata/README.md)

* [ListTransactions](docs/sdks/codatlendingaccountingbankdata/README.md#listtransactions) - List bank account transactions

### [AccountingBankData.Accounts](docs/sdks/accounts/README.md)

* [Get](docs/sdks/accounts/README.md#get) - Get bank account
* [List](docs/sdks/accounts/README.md#list) - List bank accounts


### [Banking.AccountBalances](docs/sdks/accountbalances/README.md)

* [List](docs/sdks/accountbalances/README.md#list) - List account balances

### [Banking.Accounts](docs/sdks/codatlendingaccounts/README.md)

* [Get](docs/sdks/codatlendingaccounts/README.md#get) - Get account
* [List](docs/sdks/codatlendingaccounts/README.md#list) - List accounts

### [Banking.TransactionCategories](docs/sdks/transactioncategories/README.md)

* [Get](docs/sdks/transactioncategories/README.md#get) - Get transaction category
* [List](docs/sdks/transactioncategories/README.md#list) - List transaction categories

### [Banking.Transactions](docs/sdks/codatlendingbankingtransactions/README.md)

* [Get](docs/sdks/codatlendingbankingtransactions/README.md#get) - Get bank transaction
* [List](docs/sdks/codatlendingbankingtransactions/README.md#list) - List transactions

### [Banking.CategorizedStatement](docs/sdks/categorizedstatement/README.md)

* [Get](docs/sdks/categorizedstatement/README.md#get) - Get categorized bank statement


### [AccountsPayable.Bills](docs/sdks/bills/README.md)

* [DownloadAttachment](docs/sdks/bills/README.md#downloadattachment) - Download bill attachment
* [Get](docs/sdks/bills/README.md#get) - Get bill
* [GetAttachment](docs/sdks/bills/README.md#getattachment) - Get bill attachment
* [List](docs/sdks/bills/README.md#list) - List bills
* [ListAttachments](docs/sdks/bills/README.md#listattachments) - List bill attachments

### [AccountsPayable.Suppliers](docs/sdks/suppliers/README.md)

* [DownloadAttachment](docs/sdks/suppliers/README.md#downloadattachment) - Download supplier attachment
* [Get](docs/sdks/suppliers/README.md#get) - Get supplier
* [GetAttachment](docs/sdks/suppliers/README.md#getattachment) - Get supplier attachment
* [List](docs/sdks/suppliers/README.md#list) - List suppliers
* [ListAttachments](docs/sdks/suppliers/README.md#listattachments) - List supplier attachments

### [AccountsPayable.BillCreditNotes](docs/sdks/billcreditnotes/README.md)

* [Get](docs/sdks/billcreditnotes/README.md#get) - Get bill credit note
* [List](docs/sdks/billcreditnotes/README.md#list) - List bill credit notes

### [AccountsPayable.BillPayments](docs/sdks/billpayments/README.md)

* [Get](docs/sdks/billpayments/README.md#get) - Get bill payment
* [List](docs/sdks/billpayments/README.md#list) - List bill payments


### [Sales.Customers](docs/sdks/codatlendingcustomers/README.md)

* [Get](docs/sdks/codatlendingcustomers/README.md#get) - Get customer
* [List](docs/sdks/codatlendingcustomers/README.md#list) - List customers

### [Sales.Disputes](docs/sdks/disputes/README.md)

* [Get](docs/sdks/disputes/README.md#get) - Get dispute
* [List](docs/sdks/disputes/README.md#list) - List disputes

### [Sales.Locations](docs/sdks/locations/README.md)

* [Get](docs/sdks/locations/README.md#get) - Get location
* [List](docs/sdks/locations/README.md#list) - List locations

### [Sales.Orders](docs/sdks/orders/README.md)

* [Get](docs/sdks/orders/README.md#get) - Get order
* [List](docs/sdks/orders/README.md#list) - List orders

### [Sales.PaymentMethods](docs/sdks/paymentmethods/README.md)

* [Get](docs/sdks/paymentmethods/README.md#get) - Get payment method
* [List](docs/sdks/paymentmethods/README.md#list) - List payment methods

### [Sales.Payments](docs/sdks/codatlendingsalespayments/README.md)

* [Get](docs/sdks/codatlendingsalespayments/README.md#get) - Get payment
* [List](docs/sdks/codatlendingsalespayments/README.md#list) - List payments

### [Sales.ProductCategories](docs/sdks/productcategories/README.md)

* [Get](docs/sdks/productcategories/README.md#get) - Get product category
* [List](docs/sdks/productcategories/README.md#list) - List product categories

### [Sales.Products](docs/sdks/products/README.md)

* [Get](docs/sdks/products/README.md#get) - Get product
* [List](docs/sdks/products/README.md#list) - List products

### [Sales.Transactions](docs/sdks/codatlendingtransactions/README.md)

* [Get](docs/sdks/codatlendingtransactions/README.md#get) - Get transaction
* [List](docs/sdks/codatlendingtransactions/README.md#list) - List transactions

### [Sales.Metrics](docs/sdks/metrics/README.md)

* [GetCustomerRetention](docs/sdks/metrics/README.md#getcustomerretention) - Get customer retention metrics
* [GetLifetimeValue](docs/sdks/metrics/README.md#getlifetimevalue) - Get lifetime value metrics
* [GetRevenue](docs/sdks/metrics/README.md#getrevenue) - Get commerce revenue metrics

### [Sales.Reports](docs/sdks/codatlendingreports/README.md)

* [GetOrders](docs/sdks/codatlendingreports/README.md#getorders) - Get orders report
* [GetRefunds](docs/sdks/codatlendingreports/README.md#getrefunds) - Get refunds report

### [CompanyInfo](docs/sdks/companyinfo/README.md)

* [GetAccountingProfile](docs/sdks/companyinfo/README.md#getaccountingprofile) - Get company accounting profile
* [GetCommerceProfile](docs/sdks/companyinfo/README.md#getcommerceprofile) - Get company commerce profile


### [AccountsReceivable.Customers](docs/sdks/customers/README.md)

* [DownloadAttachment](docs/sdks/customers/README.md#downloadattachment) - Download customer attachment
* [Get](docs/sdks/customers/README.md#get) - Get customer
* [GetAttachment](docs/sdks/customers/README.md#getattachment) - Get customer attachment
* [List](docs/sdks/customers/README.md#list) - List customers
* [ListAttachments](docs/sdks/customers/README.md#listattachments) - List customer attachments

### [AccountsReceivable.DirectIncomes](docs/sdks/directincomes/README.md)

* [DownloadAttachment](docs/sdks/directincomes/README.md#downloadattachment) - Download direct income attachment
* [Get](docs/sdks/directincomes/README.md#get) - Get direct income
* [GetAttachment](docs/sdks/directincomes/README.md#getattachment) - Get direct income attachment
* [List](docs/sdks/directincomes/README.md#list) - List direct incomes
* [ListAttachments](docs/sdks/directincomes/README.md#listattachments) - List direct income attachments

### [AccountsReceivable.Invoices](docs/sdks/invoices/README.md)

* [DownloadAttachment](docs/sdks/invoices/README.md#downloadattachment) - Download invoice attachment
* [DownloadPdf](docs/sdks/invoices/README.md#downloadpdf) - Get invoice as PDF
* [Get](docs/sdks/invoices/README.md#get) - Get invoice
* [GetAttachment](docs/sdks/invoices/README.md#getattachment) - Get invoice attachment
* [List](docs/sdks/invoices/README.md#list) - List invoices
* [ListAttachments](docs/sdks/invoices/README.md#listattachments) - List invoice attachments
* [ListReconciled](docs/sdks/invoices/README.md#listreconciled) - List reconciled invoices

### [AccountsReceivable.CreditNotes](docs/sdks/creditnotes/README.md)

* [Get](docs/sdks/creditnotes/README.md#get) - Get credit note
* [List](docs/sdks/creditnotes/README.md#list) - List credit notes

### [AccountsReceivable.Payments](docs/sdks/payments/README.md)

* [Get](docs/sdks/payments/README.md#get) - Get payment
* [List](docs/sdks/payments/README.md#list) - List payments

### [AccountsReceivable.Reports](docs/sdks/reports/README.md)

* [GetAgedCreditors](docs/sdks/reports/README.md#getagedcreditors) - Aged creditors report
* [GetAgedDebtors](docs/sdks/reports/README.md#getageddebtors) - Aged debtors report
* [IsAgedCreditorsAvailable](docs/sdks/reports/README.md#isagedcreditorsavailable) - Aged creditors report available
* [IsAgedDebtorsAvailable](docs/sdks/reports/README.md#isageddebtorsavailable) - Aged debtors report available

### [FileUpload](docs/sdks/fileupload/README.md)

* [Download](docs/sdks/fileupload/README.md#download) - Download all files for a company
* [ListUploaded](docs/sdks/fileupload/README.md#listuploaded) - List all files uploaded by a company
* [Upload](docs/sdks/fileupload/README.md#upload) - Upload files for a company


### [LoanWriteback.BankAccounts](docs/sdks/bankaccounts/README.md)

* [Create](docs/sdks/bankaccounts/README.md#create) - Create bank account
* [GetCreateUpdateModel](docs/sdks/bankaccounts/README.md#getcreateupdatemodel) - Get create/update bank account model

### [LoanWriteback.BankTransactions](docs/sdks/banktransactions/README.md)

* [Create](docs/sdks/banktransactions/README.md#create) - Create bank account transactions
* [GetCreateModel](docs/sdks/banktransactions/README.md#getcreatemodel) - Get create bank account transactions model

### [LoanWriteback.Accounts](docs/sdks/codatlendingloanwritebackaccounts/README.md)

* [Create](docs/sdks/codatlendingloanwritebackaccounts/README.md#create) - Create account
* [GetCreateModel](docs/sdks/codatlendingloanwritebackaccounts/README.md#getcreatemodel) - Get create account model

### [LoanWriteback.DirectCosts](docs/sdks/directcosts/README.md)

* [Create](docs/sdks/directcosts/README.md#create) - Create direct cost
* [GetCreateModel](docs/sdks/directcosts/README.md#getcreatemodel) - Get create direct cost model

### [LoanWriteback.Payments](docs/sdks/codatlendingpayments/README.md)

* [Create](docs/sdks/codatlendingpayments/README.md#create) - Create payment
* [GetCreateModel](docs/sdks/codatlendingpayments/README.md#getcreatemodel) - Get create payment model

### [LoanWriteback.Suppliers](docs/sdks/codatlendingsuppliers/README.md)

* [Create](docs/sdks/codatlendingsuppliers/README.md#create) - Create supplier
* [GetCreateUpdateModel](docs/sdks/codatlendingsuppliers/README.md#getcreateupdatemodel) - Get create/update supplier model

### [LoanWriteback.Transfers](docs/sdks/transfers/README.md)

* [Create](docs/sdks/transfers/README.md#create) - Create transfer
* [GetCreateModel](docs/sdks/transfers/README.md#getcreatemodel) - Get create transfer model

### [LoanWriteback.CreateOperations](docs/sdks/createoperations/README.md)

* [Get](docs/sdks/createoperations/README.md#get) - Get create operation
* [List](docs/sdks/createoperations/README.md#list) - List create operations


### [FinancialStatements.Accounts](docs/sdks/codatlendingfinancialstatementsaccounts/README.md)

* [Get](docs/sdks/codatlendingfinancialstatementsaccounts/README.md#get) - Get account
* [List](docs/sdks/codatlendingfinancialstatementsaccounts/README.md#list) - List accounts

### [FinancialStatements.BalanceSheet](docs/sdks/balancesheet/README.md)

* [Get](docs/sdks/balancesheet/README.md#get) - Get balance sheet
* [GetCategorizedAccounts](docs/sdks/balancesheet/README.md#getcategorizedaccounts) - Get categorized balance sheet statement

### [FinancialStatements.CashFlow](docs/sdks/cashflow/README.md)

* [Get](docs/sdks/cashflow/README.md#get) - Get cash flow statement

### [FinancialStatements.ProfitAndLoss](docs/sdks/profitandloss/README.md)

* [Get](docs/sdks/profitandloss/README.md#get) - Get profit and loss
* [GetCategorizedAccounts](docs/sdks/profitandloss/README.md#getcategorizedaccounts) - Get categorized profit and loss statement

### [ManageData](docs/sdks/managedata/README.md)

* [GetStatus](docs/sdks/managedata/README.md#getstatus) - Get data status

### [ManageData.Refresh](docs/sdks/refresh/README.md)

* [AllDataTypes](docs/sdks/refresh/README.md#alldatatypes) - Refresh all data
* [DataType](docs/sdks/refresh/README.md#datatype) - Refresh data type

### [ManageData.PullOperations](docs/sdks/pulloperations/README.md)

* [Get](docs/sdks/pulloperations/README.md#get) - Get pull operation
* [List](docs/sdks/pulloperations/README.md#list) - List pull operations

### [Liabilities](docs/sdks/liabilities/README.md)

* [GenerateLoanSummary](docs/sdks/liabilities/README.md#generateloansummary) - Generate loan summaries report
* [GenerateLoanTransactions](docs/sdks/liabilities/README.md#generateloantransactions) - Generate loan transactions report
* [GetLoanSummary](docs/sdks/liabilities/README.md#getloansummary) - Get loan summaries
* [ListLoanTransactions](docs/sdks/liabilities/README.md#listloantransactions) - List loan transactions

### [DataIntegrity](docs/sdks/dataintegrity/README.md)

* [Details](docs/sdks/dataintegrity/README.md#details) - List data integrity details
* [Status](docs/sdks/dataintegrity/README.md#status) - Get data integrity status
* [Summaries](docs/sdks/dataintegrity/README.md#summaries) - Get data integrity summaries

### [ExcelReports](docs/sdks/excelreports/README.md)

* [Download](docs/sdks/excelreports/README.md#download) - Download Excel report
* [Generate](docs/sdks/excelreports/README.md#generate) - Generate Excel report
* [GetStatus](docs/sdks/excelreports/README.md#getstatus) - Get Excel report status
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `https://api.codat.io` | None |




### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

<!-- Start Codat Support Notes -->
<!-- End Codat Support Notes -->

<!-- Start Codat Generated By -->