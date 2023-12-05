# Sync for Payroll

<!-- Start Codat Library Description -->
Push payroll to accounting platforms.
<!-- End Codat Library Description -->

<!-- Start SDK Installation -->
## SDK Installation

### Nuget

```bash
dotnet add package Codat.Sync.Payroll
```
<!-- End SDK Installation -->

## Example Usage
<!-- Start SDK Example Usage -->
```csharp
using CodatSyncPayroll;
using CodatSyncPayroll.Models.Shared;
using CodatSyncPayroll.Models.Operations;

var sdk = new CodatSyncPayrollSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Accounts.CreateAsync(new CreateAccountRequest() {
    Account = new Account() {
        Currency = "USD",
        CurrentBalance = 0M,
        Description = "Invoices the business has issued but has not yet collected payment on.",
        FullyQualifiedCategory = "Asset.Current",
        FullyQualifiedName = "Cash On Hand",
        Id = "1b6266d1-1e44-46c5-8eb5-a8f98e03124e",
        Metadata = new AccountMetadata() {},
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Name = "Accounts Receivable",
        NominalCode = "610",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayroll.Models.Shared.AccountStatus.Active,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "Money", new Dictionary<string, object>() {
                    { "blue", "shred" },
                } },
            },
        },
        Type = CodatSyncPayroll.Models.Shared.AccountType.Asset,
        ValidDatatypeLinks = new List<AccountValidDataTypeLinks>() {
            new AccountValidDataTypeLinks() {
                Links = new List<string>() {
                    "abnormally",
                },
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```
<!-- End SDK Example Usage -->

<!-- Start SDK Available Operations -->
## Available Resources and Operations


### [Accounts](docs/sdks/accounts/README.md)

* [Create](docs/sdks/accounts/README.md#create) - Create account
* [Get](docs/sdks/accounts/README.md#get) - Get account
* [GetCreateModel](docs/sdks/accounts/README.md#getcreatemodel) - Get create account model
* [List](docs/sdks/accounts/README.md#list) - List accounts

### [Companies](docs/sdks/companies/README.md)

* [Create](docs/sdks/companies/README.md#create) - Create company
* [Delete](docs/sdks/companies/README.md#delete) - Delete a company
* [Get](docs/sdks/companies/README.md#get) - Get company
* [List](docs/sdks/companies/README.md#list) - List companies
* [Update](docs/sdks/companies/README.md#update) - Update company

### [CompanyInfo](docs/sdks/companyinfo/README.md)

* [GetAccountingProfile](docs/sdks/companyinfo/README.md#getaccountingprofile) - Get company accounting profile

### [Connections](docs/sdks/connections/README.md)

* [Create](docs/sdks/connections/README.md#create) - Create connection
* [Delete](docs/sdks/connections/README.md#delete) - Delete connection
* [Get](docs/sdks/connections/README.md#get) - Get connection
* [List](docs/sdks/connections/README.md#list) - List connections
* [Unlink](docs/sdks/connections/README.md#unlink) - Unlink connection

### [JournalEntries](docs/sdks/journalentries/README.md)

* [Create](docs/sdks/journalentries/README.md#create) - Create journal entry
* [Delete](docs/sdks/journalentries/README.md#delete) - Delete journal entry
* [Get](docs/sdks/journalentries/README.md#get) - Get journal entry
* [GetCreateModel](docs/sdks/journalentries/README.md#getcreatemodel) - Get create journal entry model
* [List](docs/sdks/journalentries/README.md#list) - List journal entries

### [Journals](docs/sdks/journals/README.md)

* [Create](docs/sdks/journals/README.md#create) - Create journal
* [Get](docs/sdks/journals/README.md#get) - Get journal
* [GetCreateModel](docs/sdks/journals/README.md#getcreatemodel) - Get create journal model
* [List](docs/sdks/journals/README.md#list) - List journals

### [ManageData](docs/sdks/managedata/README.md)

* [GetDataStatus](docs/sdks/managedata/README.md#getdatastatus) - Get data status
* [GetPullOperation](docs/sdks/managedata/README.md#getpulloperation) - Get pull operation
* [GetPushOperation](docs/sdks/managedata/README.md#getpushoperation) - Get push operation
* [List](docs/sdks/managedata/README.md#list) - List push operations
* [ListPullOperations](docs/sdks/managedata/README.md#listpulloperations) - List pull operations
* [RefreshAllDataTypes](docs/sdks/managedata/README.md#refreshalldatatypes) - Refresh all data
* [RefreshDataType](docs/sdks/managedata/README.md#refreshdatatype) - Refresh data type

### [TrackingCategories](docs/sdks/trackingcategories/README.md)

* [Get](docs/sdks/trackingcategories/README.md#get) - Get tracking categories
* [List](docs/sdks/trackingcategories/README.md#list) - List tracking categories
<!-- End SDK Available Operations -->

<!-- Start Dev Containers -->