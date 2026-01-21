# LoanWriteback.Payments

## Overview

### Available Operations

* [GetCreateModel](#getcreatemodel) - Get create payment model
* [Create](#create) - Create payment

## GetCreateModel

The *Get create payment model* endpoint returns the expected data for the request payload when creating a [payment](https://docs.codat.io/lending-api#/schemas/Payment) for a given company and integration.

[Payments](https://docs.codat.io/lending-api#/schemas/Payment) represent an allocation of money within any customer accounts receivable account.

**Integration-specific behavior**

See the *response examples* for integration-specific indicative models.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetCreatePaymentModelRequest](../../Models/Requests/GetCreatePaymentModelRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetCreatePaymentModelResponse](../../Models/Requests/GetCreatePaymentModelResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                  | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Create

The *Create payment* endpoint creates a new [payment](https://docs.codat.io/lending-api#/schemas/Payment) for a given company's connection.

[Payments](https://docs.codat.io/lending-api#/schemas/Payment) represent an allocation of money within any customer accounts receivable account.

**Integration-specific behavior**

Required data may vary by integration. To see what data to post, first call [Get create payment model](https://docs.codat.io/lending-api#/operations/get-create-payments-model).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="create-payment" method="post" path="/companies/{companyId}/connections/{connectionId}/push/payments" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreatePaymentRequest req = new CreatePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountingPayment = new AccountingPayment() {
        CustomerRef = new AccountingCustomerRef() {
            Id = "80000002-1674552702",
            CompanyName = "string",
        },
        AccountRef = new AccountRef() {
            Id = "8000002E-1675267199",
            Name = "Undeposited Funds",
        },
        PaymentMethodRef = new PaymentMethodRef() {
            Id = "string",
            Name = "string",
        },
        TotalAmount = 28M,
        Currency = "USD",
        CurrencyRate = 1M,
        Date = "2023-02-10T11:47:04.792Z",
        Note = "note 14/02 1147",
        Lines = new List<PaymentLine>() {
            new PaymentLine() {
                Amount = 28M,
                Links = new List<PaymentLineLink>() {
                    new PaymentLineLink() {
                        Type = PaymentLinkType.Invoice,
                        Id = "181-1676374586",
                        Amount = -28M,
                        CurrencyRate = 1M,
                    },
                },
                AllocatedOnDate = "2023-02-11T11:47:04.792Z",
            },
        },
        Reference = "ref 14/02 1147",
    },
};

var res = await sdk.LoanWriteback.Payments.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [CreatePaymentRequest](../../Models/Requests/CreatePaymentRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[CreatePaymentResponse](../../Models/Requests/CreatePaymentResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |