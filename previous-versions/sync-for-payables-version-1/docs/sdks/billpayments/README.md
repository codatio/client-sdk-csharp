# BillPayments
(*BillPayments*)

## Overview

Get, create, and update Bill payments.

### Available Operations

* [List](#list) - List bill payments
* [Get](#get) - Get bill payment
* [Delete](#delete) - Delete bill payment
* [GetCreateModel](#getcreatemodel) - Get create bill payment model
* [Create](#create) - Create bill payments

## List

The *List bill payments* endpoint returns a list of [bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) for a given company's connection.

[Bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) are an allocation of money within any Accounts Payable account.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListBillPaymentsRequest req = new ListBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.BillPayments.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListBillPaymentsRequest](../../Models/Requests/ListBillPaymentsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListBillPaymentsResponse](../../Models/Requests/ListBillPaymentsResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503               | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## Get

The *Get bill payment* endpoint returns a single bill payment for a given `billPaymentId`.

[Bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) are an allocation of money within any Accounts Payable account.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billPayments) for integrations that support getting a specific bill payment.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetBillPaymentsRequest req = new GetBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "<value>",
};

var res = await sdk.BillPayments.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetBillPaymentsRequest](../../Models/Requests/GetBillPaymentsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[GetBillPaymentsResponse](../../Models/Requests/GetBillPaymentsResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503                   | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## Delete

﻿The *Delete bill payment* endpoint allows you to delete a specified bill payment from an accounting software.

[Bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) are an allocation of money within any Accounts Payable account.

### Process
1. Pass the `{billPaymentId}` to the *Delete bill payment* endpoint and store the `pushOperationKey` returned.
2. Check the status of the delete operation by checking the status of the push operation either via
   1. [Push operation webhook](https://docs.codat.io/introduction/webhooks/core-rules-types#push-operation-status-has-changed) (advised),
   2. [Push operation status endpoint](https://docs.codat.io/sync-for-payables-api#/operations/get-push-operation).

   A `Success` status indicates that the bill payment object was deleted from the accounting software.
3. (Optional) Check that the bill payment was deleted from the accounting software.

### Effect on related objects
Be aware that deleting a bill payment from an accounting software might cause related objects to be modified.

## Integration specifics
Integrations that support soft delete do not permanently delete the object in the accounting software.

| Integration | Soft Delete | Details |
|-------------|-------------|---------|
| QuickBooks Online  | No  | -
| QuickBooks Desktop | No  | -
| Oracle NetSuite    | No  | See [here](/integrations/accounting/netsuite/accounting-netsuite-how-deleting-bill-payments-works) to learn more.
| Xero               | Yes | -     
| Sage Intacct       | No  | Some bill payments in Sage Intacct can only be deleted, whilst others can only be voided. Codat have applied logic to handle this complexity. 

> **Supported integrations**
>
> This functionality is currently supported for our QuickBooks Online, QuickBooks Desktop, Oracle NetSuite, Xero and Sage Intacct integrations.

### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

DeleteBillPaymentRequest req = new DeleteBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillPaymentId = "<value>",
};

var res = await sdk.BillPayments.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [DeleteBillPaymentRequest](../../Models/Requests/DeleteBillPaymentRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[DeleteBillPaymentResponse](../../Models/Requests/DeleteBillPaymentResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                       | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## GetCreateModel

The *Get create bill payment model* endpoint returns the expected data for the request payload when creating a [bill payment](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) for a given company and integration.

[Bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) are an allocation of money within any Accounts Payable account.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billPayments) for integrations that support creating a bill payment.


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateBillPaymentModelRequest req = new GetCreateBillPaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BillPayments.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetCreateBillPaymentModelRequest](../../Models/Requests/GetCreateBillPaymentModelRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[GetCreateBillPaymentModelResponse](../../Models/Requests/GetCreateBillPaymentModelResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                       | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## Create

The *Create bill payment* endpoint creates a new [bill payment](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) for a given company's connection.

[Bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) are an allocation of money within any customer accounts payable account.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create bill payment model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-billPayments-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billPayments) for integrations that support creating a bill payment.


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBillPaymentRequest req = new CreateBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillPayment = new BillPayment() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        Id = "3d5a8e00-d108-4045-8823-7f342676cffa",
        TotalAmount = 1000M,
        Currency = "EUR",
        Date = "2022-10-23T00:00:00Z",
        Note = "Bill Payment against bill c13e37b6-dfaa-4894-b3be-9fe97bda9f44",
        PaymentMethodRef = new PaymentMethodRef() {
            Id = "EILBDVJVNUAGVKRQ",
            Name = "AliPay",
        },
        Lines = new List<BillPaymentLine>() {
            new BillPaymentLine() {
                Amount = 1000M,
                Links = new List<BillPaymentLineLink>() {
                    new BillPaymentLineLink() {
                        Type = Codat.Sync.Payables.V1.Models.Components.BillPaymentLineLinkType.Bill,
                        Id = "x",
                        Amount = -1000M,
                    },
                },
                AllocatedOnDate = "2022-10-23T00:00:00Z",
            },
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

**[Models.Requests.CreateBillPaymentResponse](../../Models/Requests/CreateBillPaymentResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                   | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |
