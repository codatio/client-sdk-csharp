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
            Id = "<ID>",
        },
        Currency = "USD",
        CurrencyRate = 4893.82M,
        Id = "<ID>",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<DirectCostLineItem>() {
            new DirectCostLineItem() {
                AccountRef = new AccountRef() {
                    Id = "<ID>",
                    Name = "Money blue shred",
                },
                Description = "Implemented web-enabled success",
                DiscountAmount = 0.86M,
                DiscountPercentage = 4552.22M,
                ItemRef = new ItemRef() {
                    Id = "<ID>",
                    Name = "evolve",
                },
                Quantity = 7150.4M,
                SubTotal = 7926.2M,
                TaxAmount = 8559.52M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 8165.88M,
                    Id = "<ID>",
                    Name = "Screen mobile",
                },
                TotalAmount = 6562.56M,
                Tracking = new Tracking() {
                    InvoiceTo = new RecordRef() {
                        DataType = "invoice",
                        Id = "<ID>",
                    },
                    RecordRefs = new List<RecordRef>() {
                        new RecordRef() {
                            DataType = "journalEntry",
                            Id = "<ID>",
                        },
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "<ID>",
                        Name = "after",
                    },
                },
                UnitAmount = 5190.28M,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "Fish",
        PaymentAllocations = new List<AccountingPaymentAllocation>() {
            new AccountingPaymentAllocation() {
                Allocation = new AccountingPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "EUR",
                    CurrencyRate = 3229.97M,
                    TotalAmount = 8946.95M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "<ID>",
                        Name = "Account",
                    },
                    Currency = "GBP",
                    CurrencyRate = 3577.62M,
                    Id = "<ID>",
                    Note = "Kentucky animated",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "though East",
                    TotalAmount = 1687.57M,
                },
            },
        },
        Reference = "or",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        SubTotal = 276.19M,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "tempora", new Dictionary<string, object>() {
                    { "id", "Global" },
                } },
            },
        },
        TaxAmount = 7870.96M,
        TotalAmount = 9065.37M,
    },
    AllowSyncOnPushComplete = false,
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 425694,
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

