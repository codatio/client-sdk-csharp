# PaymentMethodsSDK
(*PaymentMethods*)

## Overview

Payment methods

### Available Operations

* [Get](#get) - Get payment method
* [List](#list) - List payment methods

## Get

The *Get payment method* endpoint returns a single payment method for a given `paymentMethodId`.

[Payment methods](https://docs.codat.io/sync-for-payables-api#/schemas/PaymentMethod) are used to pay a Bill. Payment Methods are referenced on [Bill Payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) and [Payments](https://docs.codat.io/sync-for-payables-api#/schemas/Payment).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=paymentMethods) for integrations that support getting a specific payment method.

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

var res = await sdk.PaymentMethods.GetAsync(new GetPaymentMethodRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentMethodId = "string",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetPaymentMethodRequest](../../models/operations/GetPaymentMethodRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[GetPaymentMethodResponse](../../models/operations/GetPaymentMethodResponse.md)**


## List

The *List payment methods* endpoint returns a list of [payment methods](https://docs.codat.io/sync-for-payables-api#/schemas/PaymentMethod) for a given company's connection.

[Payment methods](https://docs.codat.io/sync-for-payables-api#/schemas/PaymentMethod) are used to pay a Bill. Payment Methods are referenced on [Bill Payments](https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment) and [Payments](https://docs.codat.io/sync-for-payables-api#/schemas/Payment).

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

var res = await sdk.PaymentMethods.ListAsync(new ListPaymentMethodsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListPaymentMethodsRequest](../../models/operations/ListPaymentMethodsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[ListPaymentMethodsResponse](../../models/operations/ListPaymentMethodsResponse.md)**

