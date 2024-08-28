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
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.BankAccounts.CreateAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    connectionId: "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    idempotencyKey: "<value>",
    bankAccountPrototype: new BankAccountPrototype() {
    Name = "<value>",
    AccountType = Openapi.Models.Components.AccountType.Credit,
    AccountNumber = "<value>",
    Currency = "USD",
});

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 | Example                                                                     |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `CompanyId`                                                                 | *string*                                                                    | :heavy_check_mark:                                                          | Unique identifier for a company.                                            | 8a210b68-6988-11ed-a1eb-0242ac120002                                        |
| `ConnectionId`                                                              | *string*                                                                    | :heavy_check_mark:                                                          | Unique identifier for a connection.                                         | 2e9d2c44-f675-40ba-8049-353bfcb5e171                                        |
| `IdempotencyKey`                                                            | *string*                                                                    | :heavy_minus_sign:                                                          | A unique identifier to ensure idempotent behaviour for subsequent requests. |                                                                             |
| `BankAccountPrototype`                                                      | [BankAccountPrototype](../../Models/Components/BankAccountPrototype.md)     | :heavy_minus_sign:                                                          | N/A                                                                         |                                                                             |

### Response

**[CreateBankAccountResponse](../../Models/Requests/CreateBankAccountResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503    | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |
