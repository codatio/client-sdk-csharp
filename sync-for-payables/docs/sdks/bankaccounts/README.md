# BankAccounts
(*BankAccounts*)

## Overview

Create a bank account for a given company's connection.

### Available Operations

* [Create](#create) - Create bank account

## Create

The *Create bank account* endpoint creates a new [bank account](https://docs.codat.io/sync-for-payables-api#/schemas/BankAccount) for a given company's connection.

[Bank accounts](https://docs.codat.io/sync-for-payables-api#/schemas/BankAccount) are financial accounts maintained by a bank or other financial institution.

### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Requests;
using Codat.Sync.Payables.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBankAccountRequest req = new CreateBankAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BankAccountPrototype = new BankAccountPrototype() {
        Name = "<value>",
        AccountType = Codat.Sync.Payables.Models.Components.AccountType.Credit,
        AccountNumber = "<value>",
        Currency = "USD",
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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503         | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |