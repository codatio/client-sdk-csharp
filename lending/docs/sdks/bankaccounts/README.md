# BankAccounts
(*LoanWriteback.BankAccounts*)

### Available Operations

* [Create](#create) - Create bank account
* [GetCreateUpdateModel](#getcreateupdatemodel) - Get create/update bank account model

## Create

The *Create bank account* endpoint creates a new [bank account](https://docs.codat.io/lending-api#/schemas/BankAccount) for a given company's connection.

[Bank accounts](https://docs.codat.io/lending-api#/schemas/BankAccount) are financial accounts maintained by a bank or other financial institution.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update bank account model](https://docs.codat.io/lending-api#/operations/get-create-update-bankAccounts-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bankAccounts) for integrations that support creating an account.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateBankAccountRequest req = new CreateBankAccountRequest() {
    AccountingBankAccount = new AccountingBankAccount() {
        Currency = "USD",
        Metadata = new Metadata() {},
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "key", new Dictionary<string, object>() {
                    { "key", "string" },
                } },
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.BankAccounts.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [CreateBankAccountRequest](../../Models/Operations/CreateBankAccountRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[CreateBankAccountResponse](../../Models/Operations/CreateBankAccountResponse.md)**


## GetCreateUpdateModel

The *Get create/update bank account model* endpoint returns the expected data for the request payload when creating and updating a [bank account](https://docs.codat.io/lending-api#/schemas/BankAccount) for a given company and integration.

[Bank accounts](https://docs.codat.io/lending-api#/schemas/BankAccount) are financial accounts maintained by a bank or other financial institution.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bankAccounts) for integrations that support creating and updating a bank account.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetCreateUpdateBankAccountsModelRequest req = new GetCreateUpdateBankAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.BankAccounts.GetCreateUpdateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [GetCreateUpdateBankAccountsModelRequest](../../Models/Operations/GetCreateUpdateBankAccountsModelRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |


### Response

**[GetCreateUpdateBankAccountsModelResponse](../../Models/Operations/GetCreateUpdateBankAccountsModelResponse.md)**

