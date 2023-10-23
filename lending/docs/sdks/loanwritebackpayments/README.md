# LoanWritebackPaymentsSDK
(*LoanWriteback.Payments*)

### Available Operations

* [Create](#create) - Create payment
* [GetCreateModel](#getcreatemodel) - Get create payment model

## Create

The *Create payment* endpoint creates a new [payment](https://docs.codat.io/lending-api#/schemas/Payment) for a given company's connection.

[Payments](https://docs.codat.io/lending-api#/schemas/Payment) represent an allocation of money within any customer accounts receivable account.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create payment model](https://docs.codat.io/lending-api#/operations/get-create-payments-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=payments) for integrations that support creating an account.


### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.LoanWriteback.Payments.CreateAsync(new CreatePaymentRequest() {
    AccountingPayment = new AccountingPayment() {
        AccountRef = new AccountRef() {},
        Currency = "USD",
        CustomerRef = new AccountingCustomerRef() {
            Id = "<ID>",
        },
        Date = "2022-10-23T00:00:00.000Z",
        Lines = new List<PaymentLine>() {
            new PaymentLine() {
                AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                Amount = 8592.13M,
                Links = new List<PaymentLineLink>() {
                    new PaymentLineLink() {
                        Type = CodatLending.Models.Shared.PaymentLinkType.Other,
                    },
                },
            },
        },
        Metadata = new Metadata() {},
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        PaymentMethodRef = new PaymentMethodRef() {
            Id = "<ID>",
        },
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "key", new Dictionary<string, object>() {
                    { "key", "string" },
                } },
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CreatePaymentRequest](../../models/operations/CreatePaymentRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[CreatePaymentResponse](../../models/operations/CreatePaymentResponse.md)**


## GetCreateModel

The *Get create payment model* endpoint returns the expected data for the request payload when creating a [payment](https://docs.codat.io/lending-api#/schemas/Payment) for a given company and integration.

[Payments](https://docs.codat.io/lending-api#/schemas/Payment) represent an allocation of money within any customer accounts receivable account.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=payments) for integrations that support creating a payment.


### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(new GetCreatePaymentsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetCreatePaymentsModelRequest](../../models/operations/GetCreatePaymentsModelRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[GetCreatePaymentsModelResponse](../../models/operations/GetCreatePaymentsModelResponse.md)**

