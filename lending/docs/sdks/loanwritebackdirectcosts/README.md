# LoanWritebackDirectCostsSDK
(*LoanWriteback.DirectCosts*)

### Available Operations

* [Create](#create) - Create direct cost
* [GetCreateModel](#getcreatemodel) - Get create direct cost model

## Create

The *Create direct cost* endpoint creates a new [direct cost](https://docs.codat.io/lending-api#/schemas/DirectCost) for a given company's connection.

[Direct costs](https://docs.codat.io/lending-api#/schemas/DirectCost) are the expenses associated with a business' operations. For example, purchases of raw materials that are paid off at the point of the purchase and service fees are considered direct costs.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create direct cost model](https://docs.codat.io/lending-api#/operations/get-create-directCosts-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=directCosts) for integrations that support creating an account.


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

var res = await sdk.LoanWriteback.DirectCosts.CreateAsync(new CreateDirectCostRequest() {
    AccountingDirectCost = new AccountingDirectCost() {
        ContactRef = new ContactRef() {
            DataType = CodatLending.Models.Shared.DataType.Invoices,
            Id = "502a94bb-4f63-4c96-9e9a-3efa77dfb14c",
        },
        Currency = "EUR",
        CurrencyRate = 4118.2M,
        Id = "6ae395ef-b9ba-488f-ba66-997074ba4469",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<DirectCostLineItem>() {
            new DirectCostLineItem() {
                AccountRef = new AccountRef() {
                    Id = "6e214195-9890-4afa-963e-2516fe4c8b71",
                    Name = "Elvira Herman",
                },
                Description = "repellat",
                DiscountAmount = 8411.4M,
                DiscountPercentage = 1494.48M,
                ItemRef = new ItemRef() {
                    Id = "ed028921-cddc-4692-a01f-b576b0d5f0d3",
                    Name = "Erma Hessel",
                },
                Quantity = 7499.99M,
                SubTotal = 1716.29M,
                TaxAmount = 3394.04M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 5210.37M,
                    Id = "7053202c-73d5-4fe9-b90c-28909b3fe49a",
                    Name = "Ervin McLaughlin",
                },
                TotalAmount = 9644.9M,
                Tracking = new Tracking() {
                    InvoiceTo = new RecordRef() {
                        DataType = "invoice",
                        Id = "8633323f-9b77-4f3a-8100-674ebf69280d",
                    },
                    RecordRefs = new List<RecordRef>() {
                        new RecordRef() {
                            DataType = "journalEntry",
                            Id = "ba77a89e-bf73-47ae-8203-ce5e6a95d8a0",
                        },
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "d446ce2a-f7a7-43cf-bbe4-53f870b326b5",
                        Name = "Darryl Emard",
                    },
                },
                UnitAmount = 5867.84M,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "pariatur",
        PaymentAllocations = new List<AccountingPaymentAllocation>() {
            new AccountingPaymentAllocation() {
                Allocation = new AccountingPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "GBP",
                    CurrencyRate = 6748.48M,
                    TotalAmount = 5173.79M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "422bb679-d232-4271-9bf0-cbb1e31b8b90",
                        Name = "Mike Greenholt",
                    },
                    Currency = "EUR",
                    CurrencyRate = 1002.94M,
                    Id = "108e0adc-f4b9-4218-b9fc-e953f73ef7fb",
                    Note = "quod",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "similique",
                    TotalAmount = 7085.48M,
                },
            },
        },
        Reference = "vero",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        SubTotal = 2930.2M,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "quibusdam", new Dictionary<string, object>() {
                    { "illum", "sequi" },
                } },
            },
        },
        TaxAmount = 6178.77M,
        TotalAmount = 7733.26M,
    },
    AllowSyncOnPushComplete = false,
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 13236,
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [CreateDirectCostRequest](../../models/operations/CreateDirectCostRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[CreateDirectCostResponse](../../models/operations/CreateDirectCostResponse.md)**


## GetCreateModel

The *Get create direct cost model* endpoint returns the expected data for the request payload when creating a [direct cost](https://docs.codat.io/lending-api#/schemas/DirectCost) for a given company and integration.

[Direct costs](https://docs.codat.io/lending-api#/schemas/DirectCost) are purchases of items that are paid off at the point of the purchase.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=directCosts) for integrations that support creating a direct cost.


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

var res = await sdk.LoanWriteback.DirectCosts.GetCreateModelAsync(new GetCreateDirectCostsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetCreateDirectCostsModelRequest](../../models/operations/GetCreateDirectCostsModelRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[GetCreateDirectCostsModelResponse](../../models/operations/GetCreateDirectCostsModelResponse.md)**

