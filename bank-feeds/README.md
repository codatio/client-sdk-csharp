# Bank Feeds

<!-- Start Codat Library Description -->
﻿Bank Feeds API enables your SMB users to set up bank feeds from accounts in your application to supported accounting platforms.
<!-- End Codat Library Description -->

<!-- Start SDK Installation -->
## SDK Installation

### Nuget

```bash
dotnet add package Codat.BankFeeds
```
<!-- End SDK Installation -->

## Example Usage
<!-- Start SDK Example Usage -->
### Example

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Companies.CreateAsync(new CompanyRequestBody() {
    Description = "Requested early access to the new financing scheme.",
    Name = "Bank of Dave",
});

// handle response
```
<!-- End SDK Example Usage -->

<!-- Start SDK Available Operations -->
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

### [AccountMapping](docs/sdks/accountmapping/README.md)

* [Create](docs/sdks/accountmapping/README.md#create) - Create bank feed account mapping
* [Get](docs/sdks/accountmapping/README.md#get) - List bank feed account mappings

### [SourceAccounts](docs/sdks/sourceaccounts/README.md)

* [Create](docs/sdks/sourceaccounts/README.md#create) - Create source account
* [Delete](docs/sdks/sourceaccounts/README.md#delete) - Delete source account
* [DeleteCredentials](docs/sdks/sourceaccounts/README.md#deletecredentials) - Delete all source account credentials
* [GenerateCredentials](docs/sdks/sourceaccounts/README.md#generatecredentials) - Generate source account credentials
* [List](docs/sdks/sourceaccounts/README.md#list) - List source accounts
* [Update](docs/sdks/sourceaccounts/README.md#update) - Update source account

### [Transactions](docs/sdks/transactions/README.md)

* [Create](docs/sdks/transactions/README.md#create) - Create bank transactions
* [GetCreateOperation](docs/sdks/transactions/README.md#getcreateoperation) - Get create operation
* [ListCreateOperations](docs/sdks/transactions/README.md#listcreateoperations) - List create operations
<!-- End SDK Available Operations -->
