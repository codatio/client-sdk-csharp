# BillPayments

## Overview

Get, create, and update Bill payments.

### Available Operations

* [GetPaymentOptions](#getpaymentoptions) - Get payment mapping options
* [Create](#create) - Create bill payment

## GetPaymentOptions

Use the *Get mapping options - Payments* endpoint to return a list of available mapping options for a given company's connection ID.

By default, this endpoint returns a list of active bank accounts. You can use [querying](https://docs.codat.io/using-the-api/querying) to change that.

Mapping options are a set of bank accounts used to configure the SMB's payables integration.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-mapping-options-payments" method="get" path="/companies/{companyId}/connections/{connectionId}/payables/mappingOptions/payments" example="Mapping options" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetMappingOptionsPaymentsRequest req = new GetMappingOptionsPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ContinuationToken = "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    StatusQuery = "status=Archived",
};

var res = await sdk.BillPayments.GetPaymentOptionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetMappingOptionsPaymentsRequest](../../Models/Requests/GetMappingOptionsPaymentsRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[GetMappingOptionsPaymentsResponse](../../Models/Requests/GetMappingOptionsPaymentsResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Create

The *Create bill payment* endpoint creates a new [bill payment](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) for a given company's connection.

[Bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) are an allocation of money within any Accounts Payable account.

### Example Usage: Bill payment

<!-- UsageSnippet language="csharp" operationID="create-bill-payment" method="post" path="/companies/{companyId}/connections/{connectionId}/payables/bills/{billId}/payment" example="Bill payment" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBillPaymentRequest req = new CreateBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    BillPaymentPrototype = new BillPaymentPrototype() {
        Amount = 1329.54M,
        Date = "2022-10-23T00:00:00Z",
        Reference = "Bill Payment against bill c13e37b6-dfaa-4894-b3be-9fe97bda9f44",
        AccountRef = new BillPaymentAccountRef() {
            Id = "<id>",
        },
    },
};

var res = await sdk.BillPayments.CreateAsync(req);

// handle response
```
### Example Usage: Bill payment example

<!-- UsageSnippet language="csharp" operationID="create-bill-payment" method="post" path="/companies/{companyId}/connections/{connectionId}/payables/bills/{billId}/payment" example="Bill payment example" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBillPaymentRequest req = new CreateBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    BillPaymentPrototype = new BillPaymentPrototype() {
        Amount = 22M,
        Date = "2022-10-23T00:00:00.000Z",
        Reference = "Bill Payment against bill c13e37b6 dfaa-4894-b3be-9fe97bda9f44",
        AccountRef = new BillPaymentAccountRef() {
            Id = "7bda9f44sr56",
        },
        CurrencyRate = 1M,
    },
};

var res = await sdk.BillPayments.CreateAsync(req);

// handle response
```
### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-bill-payment" method="post" path="/companies/{companyId}/connections/{connectionId}/payables/bills/{billId}/payment" example="Malformed query" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBillPaymentRequest req = new CreateBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    BillPaymentPrototype = new BillPaymentPrototype() {
        Amount = 1329.54M,
        Date = "2022-10-23T00:00:00Z",
        Reference = "Bill Payment against bill c13e37b6-dfaa-4894-b3be-9fe97bda9f44",
        AccountRef = new BillPaymentAccountRef() {
            Id = "<id>",
        },
    },
};

var res = await sdk.BillPayments.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [CreateBillPaymentRequest](../../Models/Requests/CreateBillPaymentRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[CreateBillPaymentResponse](../../Models/Requests/CreateBillPaymentResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429              | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |