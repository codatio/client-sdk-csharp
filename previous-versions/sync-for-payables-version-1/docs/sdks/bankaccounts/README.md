# BankAccounts
(*BankAccounts*)

## Overview

Get, create, and update Bank accounts.

### Available Operations

* [GetCreateModel](#getcreatemodel) - Get create/update bank account model
* [Create](#create) - Create bank account

## GetCreateModel

The *Get create/update bank account model* endpoint returns the expected data for the request payload when creating and updating a [bank account](https://docs.codat.io/sync-for-payables-api#/schemas/BankAccount) for a given company and integration.

[Bank accounts](https://docs.codat.io/sync-for-payables-api#/schemas/BankAccount) are financial accounts maintained by a bank or other financial institution.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bankAccounts) for integrations that support creating and updating a bank account.


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateBankAccountsModelRequest req = new GetCreateBankAccountsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BankAccounts.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetCreateBankAccountsModelRequest](../../Models/Requests/GetCreateBankAccountsModelRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[GetCreateBankAccountsModelResponse](../../Models/Requests/GetCreateBankAccountsModelResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                       | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## Create

The *Create bank account* endpoint creates a new [bank account](https://docs.codat.io/sync-for-payables-api#/schemas/BankAccount) for a given company's connection.

[Bank accounts](https://docs.codat.io/sync-for-payables-api#/schemas/BankAccount) are financial accounts maintained by a bank or other financial institution.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update bank account model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-update-bankAccounts-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bankAccounts) for integrations that support creating an account.

### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBankAccountRequest req = new CreateBankAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BankAccountPrototype = new BankAccountPrototype() {
        Currency = "USD",
        Status = Codat.Sync.Payables.V1.Models.Components.BankAccountStatus.Active,
    },
};

var res = await sdk.BankAccounts.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [CreateBankAccountRequest](../../Models/Requests/CreateBankAccountRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[CreateBankAccountResponse](../../Models/Requests/CreateBankAccountResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                   | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |
