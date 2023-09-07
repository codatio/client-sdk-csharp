<!-- Start SDK Example Usage -->


```csharp
using CodatSyncExpenses;
using CodatSyncExpenses.Models.Shared;
using CodatSyncExpenses.Models.Operations;

var sdk = new CodatSyncExpensesSDK(
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
        FullyQualifiedName = "Fixed Asset",
        Id = "1b6266d1-1e44-46c5-8eb5-a8f98e03124e",
        IsBankAccount = false,
        Metadata = new AccountMetadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Name = "Accounts Receivable",
        NominalCode = "610",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncExpenses.Models.Shared.AccountStatus.Active,
        Type = CodatSyncExpenses.Models.Shared.AccountType.Asset,
        ValidDatatypeLinks = new List<AccountValidDataTypeLinks>() {
            new AccountValidDataTypeLinks() {
                Links = new List<string>() {
                    "unde",
                },
                Property = "nulla",
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 544883,
});

// handle response
```
<!-- End SDK Example Usage -->