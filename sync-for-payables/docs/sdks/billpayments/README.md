# BillPayments

## Overview

Bill payments

### Available Operations

* [Create](#create) - Create bill payments
* [Delete](#delete) - Delete bill payment
* [Get](#get) - Get bill payment
* [GetCreateModel](#getcreatemodel) - Get create bill payment model
* [List](#list) - List bill payments

## Create

The *Create bill payment* endpoint creates a new [bill payment](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) for a given company's connection.

[Bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) are an allocation of money within any customer accounts payable account.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create bill payment model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-billPayments-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billPayments) for integrations that support creating a bill payment.


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.BillPayments.CreateAsync(new CreateBillPaymentRequest() {
    BillPayment = new BillPayment() {
        AccountRef = new AccountRef() {
            Id = "82d68ea1-9f1d-4170-9133-9d08086a1840",
            Name = "Toni Fritsch",
        },
        Currency = "USD",
        CurrencyRate = 120.36M,
        Date = "2022-10-23T00:00:00.000Z",
        Id = "3d5a8e00-d108-4045-8823-7f342676cffa",
        Lines = new List<BillPaymentLine>() {
            new BillPaymentLine() {
                AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                Amount = 9816.4M,
                Links = new List<BillPaymentLineLink>() {
                    new BillPaymentLineLink() {
                        Amount = 6184.8M,
                        CurrencyRate = 2446.51M,
                        Id = "f5f0642d-ac7a-4f51-9cc4-13aa63aae8d6",
                        Type = CodatSyncPayables.Models.Shared.BillPaymentLineLinkType.CreditNote,
                    },
                },
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "Bill Payment against bill c13e37b6-dfaa-4894-b3be-9fe97bda9f44",
        PaymentMethodRef = "vel",
        Reference = "labore",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "facilis", new Dictionary<string, object>() {
                    { "cum", "commodi" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "75fd5e60-b375-4ed4-b6fb-ee41f33317fe",
            SupplierName = "consectetur",
        },
        TotalAmount = 1329.54M,
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 358107,
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [CreateBillPaymentRequest](../../models/operations/CreateBillPaymentRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[Models.Operations.CreateBillPaymentResponse](../../models/operations/CreateBillPaymentResponse.md)**


## Delete

﻿The *Delete bill payment* endpoint allows you to delete a specified bill payment from an accounting platform.

[Bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) are an allocation of money within any customer accounts payable account.

### Process
1. Pass the `{billPaymentId}` to the *Delete bill payment* endpoint and store the `pushOperationKey` returned.
2. Check the status of the delete operation by checking the status of push operation either via
    1. [Push operation webhook](https://docs.codat.io/introduction/webhooks/core-rules-types#push-operation-status-has-changed) (advised),
    2. [Push operation status endpoint](https://docs.codat.io/sync-for-payables-api#/operations/get-push-operation).

   A `Success` status indicates that the bill payment object was deleted from the accounting platform.
3. (Optional) Check that the bill payment was deleted from the accounting platform.

### Effect on related objects
Be aware that deleting a bill payment from an accounting platform might cause related objects to be modified.

## Integration specifics
Integrations that support soft delete do not permanently delete the object in the accounting platform.

| Integration | Soft Delete | Details                                                                                             |  
|-------------|-------------|-----------------------------------------------------------------------------------------------------|
| Oracle NetSuite   | No          | See [here](/integrations/accounting/netsuite/accounting-netsuite-how-deleting-bill-payments-works) to learn more. |


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.BillPayments.DeleteAsync(new DeleteBillPaymentRequest() {
    BillPaymentId = "harum",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [DeleteBillPaymentRequest](../../models/operations/DeleteBillPaymentRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[DeleteBillPaymentResponse](../../models/operations/DeleteBillPaymentResponse.md)**


## Get

The *Get bill payment* endpoint returns a single bill payment for a given `billPaymentId`.

[Bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) are an allocation of money within any customer accounts payable account.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billPayments) for integrations that support getting a specific bill payment.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.BillPayments.GetAsync(new GetBillPaymentsRequest() {
    BillPaymentId = "laboriosam",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetBillPaymentsRequest](../../models/operations/GetBillPaymentsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[GetBillPaymentsResponse](../../models/operations/GetBillPaymentsResponse.md)**


## GetCreateModel

The *Get create bill payment model* endpoint returns the expected data for the request payload when creating a [bill payment](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) for a given company and integration.

[Bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) are an allocation of money within any customer accounts payable account.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=billPayments) for integrations that support creating a bill payment.


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.BillPayments.GetCreateModelAsync(new GetCreateBillPaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetCreateBillPaymentModelRequest](../../models/operations/GetCreateBillPaymentModelRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[GetCreateBillPaymentModelResponse](../../models/operations/GetCreateBillPaymentModelResponse.md)**


## List

The *List bill payments* endpoint returns a list of [bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) for a given company's connection.

[Bill payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) are an allocation of money within any customer accounts payable account.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.BillPayments.ListAsync(new ListBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "ipsa",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListBillPaymentsRequest](../../models/operations/ListBillPaymentsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListBillPaymentsResponse](../../models/operations/ListBillPaymentsResponse.md)**

