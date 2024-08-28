# BillPayments
(*BillPayments*)

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

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.BillPayments.GetPaymentOptionsAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    connectionId: "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    continuationToken: "continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==",
    statusQuery: "status=Archived");

// handle response
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    | Example                                                                                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CompanyId`                                                                                                                                                                    | *string*                                                                                                                                                                       | :heavy_check_mark:                                                                                                                                                             | Unique identifier for a company.                                                                                                                                               | 8a210b68-6988-11ed-a1eb-0242ac120002                                                                                                                                           |
| `ConnectionId`                                                                                                                                                                 | *string*                                                                                                                                                                       | :heavy_check_mark:                                                                                                                                                             | Unique identifier for a connection.                                                                                                                                            | 2e9d2c44-f675-40ba-8049-353bfcb5e171                                                                                                                                           |
| `ContinuationToken`                                                                                                                                                            | *string*                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                             | Retrieve the next page of results using the continuation token from the previous response.                                                                                     | continuationToken=eyJwYWdlIjoyLCJwYWdlU2l6ZSI6MTAwLCJwYWdlQ291bnQiOjExfQ==                                                                                                     |
| `StatusQuery`                                                                                                                                                                  | *string*                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                             | Codat query string allows you to filter by `status` (`status=Active\|\|status=Archived`). [Learn more](https://docs.codat.io/using-the-api/querying) about Codat's query string. | status=Archived                                                                                                                                                                |

### Response

**[GetMappingOptionsPaymentsResponse](../../Models/Requests/GetMappingOptionsPaymentsResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503    | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |


## Create

The *Create bill payment* endpoint creates a new [bill payment](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) for a given company's connection.

[Bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) are an allocation of money within any Accounts Payable account.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBillPaymentRequest req = new CreateBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "9wg4lep4ush5cxs79pl8sozmsndbaukll3ind4g7buqbm1h2",
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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| Openapi.Models.Errors.ErrorMessage  | 400,401,402,403,404,409,429,500,503 | application/json                    |
| Openapi.Models.Errors.SDKException  | 4xx-5xx                             | */*                                 |
