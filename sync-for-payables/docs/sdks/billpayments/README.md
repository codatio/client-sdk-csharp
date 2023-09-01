# billPayments

## Overview

Bill payments

### Available Operations

* [Create](#create) - Create bill payments
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
            Id = "18544ec4-2def-4cce-8f19-77773e63562a",
            Name = "Ms. Verna Gislason",
        },
        Currency = "GBP",
        CurrencyRate = 3314.52F,
        Date = "2022-10-23T00:00:00.000Z",
        Id = "3d5a8e00-d108-4045-8823-7f342676cffa",
        Lines = new List<BillPaymentLine>() {
            new BillPaymentLine() {
                AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                Amount = 3071.73F,
                Links = new List<BillPaymentLineLink>() {
                    new BillPaymentLineLink() {
                        Amount = 9847.73F,
                        CurrencyRate = 8518.09F,
                        Id = "af313a1f-5fd9-4425-9c0b-36f25ea944f3",
                        Type = CodatSyncPayables.Models.Shared.BillPaymentLineLinkType.Refund,
                    },
                    new BillPaymentLineLink() {
                        Amount = 4483.86F,
                        CurrencyRate = 3296.51F,
                        Id = "6c11f6c3-7a51-4262-8383-5bbc05a23a45",
                        Type = CodatSyncPayables.Models.Shared.BillPaymentLineLinkType.ManualJournal,
                    },
                    new BillPaymentLineLink() {
                        Amount = 9322.5F,
                        CurrencyRate = 9555.69F,
                        Id = "c5fde10a-0ce2-4169-a510-019c6dc5e347",
                        Type = CodatSyncPayables.Models.Shared.BillPaymentLineLinkType.Other,
                    },
                },
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "Bill Payment against bill c13e37b6-dfaa-4894-b3be-9fe97bda9f44",
        PaymentMethodRef = "odio",
        Reference = "natus",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "doloribus", new Dictionary<string, object>() {
                    { "quidem", "itaque" },
                    { "laboriosam", "unde" },
                    { "modi", "perspiciatis" },
                } },
                { "hic", new Dictionary<string, object>() {
                    { "aspernatur", "libero" },
                    { "nam", "incidunt" },
                    { "recusandae", "quod" },
                } },
                { "id", new Dictionary<string, object>() {
                    { "autem", "quo" },
                    { "nesciunt", "illum" },
                    { "nemo", "illum" },
                    { "facilis", "non" },
                } },
            },
        },
        SupplierRef = new SupplierRef() {
            Id = "adebd5da-ea4c-4506-a8aa-94c02644cf5e",
            SupplierName = "unde",
        },
        TotalAmount = 1329.54F,
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 860311,
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [CreateBillPaymentRequest](../../models/operations/CreateBillPaymentRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[Models.Operations.CreateBillPaymentResponse](../../models/operations/CreateBillPaymentResponse.md)**


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
    BillPaymentId = "error",
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
    Query = "mollitia",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListBillPaymentsRequest](../../models/operations/ListBillPaymentsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListBillPaymentsResponse](../../models/operations/ListBillPaymentsResponse.md)**

