# CodatLendingTransfers
(*LoanWriteback.Transfers*)

## Overview

### Available Operations

* [GetCreateModel](#getcreatemodel) - Get create transfer model
* [Create](#create) - Create transfer

## GetCreateModel

The *Get create transfer model* endpoint returns the expected data for the request payload when creating a [transfer](https://docs.codat.io/lending-api#/schemas/Transfer) for a given company and integration.

[Transfers](https://docs.codat.io/lending-api#/schemas/Transfer) record the movement of money between two bank accounts, or between a bank account and a nominal account.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateTransfersModelRequest req = new GetCreateTransfersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Transfers.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetCreateTransfersModelRequest](../../Models/Requests/GetCreateTransfersModelRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[GetCreateTransfersModelResponse](../../Models/Requests/GetCreateTransfersModelResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503        | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Create

The *Create transfer* endpoint creates a new [transfer](https://docs.codat.io/lending-api#/schemas/Transfer) for a given company's connection.

[Transfers](https://docs.codat.io/lending-api#/schemas/Transfer) record the movement of money between two bank accounts, or between a bank account and a nominal account.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create transfer model](https://docs.codat.io/lending-api#/operations/get-create-transfers-model).

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateTransferRequest req = new CreateTransferRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountingTransfer = new AccountingTransfer() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        Date = "2022-10-23T00:00:00Z",
        From = new TransferAccount() {
            AccountRef = new AccountingRecordRef() {
                DataType = "journalEntry",
            },
            Currency = "GBP",
        },
        To = new TransferAccount() {
            AccountRef = new AccountingRecordRef() {
                DataType = "transfer",
            },
            Currency = "EUR",
        },
        DepositedRecordRefs = new List<AccountingRecordRef>() {
            new AccountingRecordRef() {
                DataType = "journalEntry",
            },
        },
    },
};

var res = await sdk.LoanWriteback.Transfers.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CreateTransferRequest](../../Models/Requests/CreateTransferRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[CreateTransferResponse](../../Models/Requests/CreateTransferResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503   | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |