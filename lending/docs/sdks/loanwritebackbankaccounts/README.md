# LoanWriteback.BankAccounts

### Available Operations

* [Create](#create) - Create bank account
* [GetCreateUpdateModel](#getcreateupdatemodel) - Get create/update bank account model

## Create

The *Create bank account* endpoint creates a new [bank account](https://docs.codat.io/accounting-api#/schemas/BankAccount) for a given company's connection.

[Bank accounts](https://docs.codat.io/accounting-api#/schemas/BankAccount) are financial accounts maintained by a bank or other financial institution.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update bank account model](https://docs.codat.io/accounting-api#/operations/get-create-update-bankAccounts-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bankAccounts) for integrations that support creating an account.

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.LoanWriteback.BankAccounts.CreateAsync(new CreateBankAccountRequest() {
    AccountingBankAccount = new AccountingBankAccount() {
        AccountName = "in",
        AccountNumber = "corporis",
        AccountType = CodatLending.Models.Shared.AccountingBankAccountType.Credit,
        AvailableBalance = 4370.32M,
        Balance = 9023.49M,
        Currency = "EUR",
        IBan = "architecto",
        Id = "0faaa235-2c59-4559-87af-f1a3a2fa9467",
        Institution = "molestiae",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        NominalCode = "error",
        OverdraftLimit = 1589.69M,
        SortCode = "quis",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
    },
    AllowSyncOnPushComplete = false,
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    TimeoutInMinutes = 674752,
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [CreateBankAccountRequest](../../models/operations/CreateBankAccountRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[CreateBankAccountResponse](../../models/operations/CreateBankAccountResponse.md)**


## GetCreateUpdateModel

The *Get create/update bank account model* endpoint returns the expected data for the request payload when creating and updating a [bank account](https://docs.codat.io/accounting-api#/schemas/BankAccount) for a given company and integration.

[Bank accounts](https://docs.codat.io/accounting-api#/schemas/BankAccount) are financial accounts maintained by a bank or other financial institution.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bankAccounts) for integrations that support creating and updating a bank account.


### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.LoanWriteback.BankAccounts.GetCreateUpdateModelAsync(new GetCreateUpdateBankAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [GetCreateUpdateBankAccountsModelRequest](../../models/operations/GetCreateUpdateBankAccountsModelRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |


### Response

**[GetCreateUpdateBankAccountsModelResponse](../../models/operations/GetCreateUpdateBankAccountsModelResponse.md)**

