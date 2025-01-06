# CodatLendingDirectCosts
(*LoanWriteback.DirectCosts*)

## Overview

### Available Operations

* [GetCreateModel](#getcreatemodel) - Get create direct cost model
* [Create](#create) - Create direct cost

## GetCreateModel

The *Get create direct cost model* endpoint returns the expected data for the request payload when creating a [direct cost](https://docs.codat.io/lending-api#/schemas/DirectCost) for a given company and integration.

[Direct costs](https://docs.codat.io/lending-api#/schemas/DirectCost) are purchases of items that are paid off at the point of the purchase.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateDirectCostsModelRequest req = new GetCreateDirectCostsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.DirectCosts.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetCreateDirectCostsModelRequest](../../Models/Requests/GetCreateDirectCostsModelRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[GetCreateDirectCostsModelResponse](../../Models/Requests/GetCreateDirectCostsModelResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503        | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Create

The *Create direct cost* endpoint creates a new [direct cost](https://docs.codat.io/lending-api#/schemas/DirectCost) for a given company's connection.

[Direct costs](https://docs.codat.io/lending-api#/schemas/DirectCost) are the expenses associated with a business' operations. For example, purchases of raw materials that are paid off at the point of the purchase and service fees are considered direct costs.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create direct cost model](https://docs.codat.io/lending-api#/operations/get-create-directCosts-model).

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateDirectCostRequest req = new CreateDirectCostRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectCostPrototype = new DirectCostPrototype() {
        IssueDate = "2022-10-23T00:00:00Z",
        Currency = "USD",
        LineItems = new List<DirectCostLineItem>() {
            new DirectCostLineItem() {
                UnitAmount = 4174.58M,
                Quantity = 1343.65M,
                AccountRef = new AccountRef() {},
                Tracking = new Tracking() {
                    RecordRefs = new List<TrackingRecordRef>() {
                        new TrackingRecordRef() {
                            DataType = TrackingRecordRefDataType.TrackingCategories,
                        },
                    },
                    InvoiceTo = new AccountingRecordRef() {
                        DataType = "journalEntry",
                    },
                },
            },
        },
        PaymentAllocations = new List<AccountingPaymentAllocation>() {
            new AccountingPaymentAllocation() {
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {},
                    Currency = "EUR",
                    PaidOnDate = "2022-10-23T00:00:00Z",
                },
                Allocation = new Allocation() {
                    Currency = "GBP",
                    AllocatedOnDate = "2022-10-23T00:00:00Z",
                },
            },
        },
        SubTotal = 899.64M,
        TaxAmount = 7926.20M,
        TotalAmount = 8165.87M,
    },
};

var res = await sdk.LoanWriteback.DirectCosts.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [CreateDirectCostRequest](../../Models/Requests/CreateDirectCostRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[CreateDirectCostResponse](../../Models/Requests/CreateDirectCostResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503   | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |