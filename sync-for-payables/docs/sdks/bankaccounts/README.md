# BankAccounts

## Overview

Create a bank account for a given company's connection.

### Available Operations

* [Create](#create) - Create bank account

## Create

The *Create bank account* endpoint creates a new [bank account](https://docs.codat.io/sync-for-payables-api#/schemas/BankAccount) for a given company's connection.

[Bank accounts](https://docs.codat.io/sync-for-payables-api#/schemas/BankAccount) are financial accounts maintained by a bank or other financial institution.

### Example Usage: Bank account example

<!-- UsageSnippet language="csharp" operationID="create-bank-account" method="post" path="/companies/{companyId}/connections/{connectionId}/payables/bankAccounts" example="Bank account example" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBankAccountRequest req = new CreateBankAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BankAccountPrototype = new BankAccountPrototype() {
        NominalCode = "22",
        Name = "Plutus - Payables - Bank Account 12",
        AccountType = BankAccountType.Debit,
        AccountNumber = "0120 0440",
        SortCode = "50-50-50",
        Currency = "GBP",
    },
};

var res = await sdk.BankAccounts.CreateAsync(req);

// handle response
```
### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-bank-account" method="post" path="/companies/{companyId}/connections/{connectionId}/payables/bankAccounts" example="Malformed query" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBankAccountRequest req = new CreateBankAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BankAccountPrototype = new BankAccountPrototype() {
        Name = "<value>",
        AccountType = BankAccountType.Debit,
        AccountNumber = "<value>",
        Currency = "GBP",
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
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |