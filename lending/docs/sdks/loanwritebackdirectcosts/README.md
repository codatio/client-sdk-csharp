# LoanWriteback.DirectCosts

### Available Operations

* [Create](#create) - Create direct cost
* [GetCreateModel](#getcreatemodel) - Get create direct cost model

## Create

The *Create direct cost* endpoint creates a new [direct cost](https://docs.codat.io/accounting-api#/schemas/DirectCost) for a given company's connection.

[Direct costs](https://docs.codat.io/accounting-api#/schemas/DirectCost) are the expenses associated with a business' operations. For example, purchases of raw materials that are paid off at the point of the purchase and service fees are considered direct costs.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create direct cost model](https://docs.codat.io/accounting-api#/operations/get-create-directCosts-model).

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
            DataType = "magni",
            Id = "d502a94b-b4f6-43c9-a9e9-a3efa77dfb14",
        },
        Currency = "EUR",
        CurrencyRate = 8137.98M,
        Id = "66ae395e-fb9b-4a88-b3a6-6997074ba446",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<DirectCostLineItem>() {
            new DirectCostLineItem() {
                AccountRef = new AccountRef() {
                    Id = "b6e21419-5989-40af-a563-e2516fe4c8b7",
                    Name = "Diane VonRueden",
                },
                Description = "nihil",
                DiscountAmount = 9988.48M,
                DiscountPercentage = 8411.4M,
                ItemRef = new ItemRef() {
                    Id = "2ed02892-1cdd-4c69-a601-fb576b0d5f0d",
                    Name = "Jennifer Runolfsdottir",
                },
                Quantity = 7299.91M,
                SubTotal = 7499.99M,
                TaxAmount = 1716.29M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 3394.04M,
                    Id = "87053202-c73d-45fe-9b90-c28909b3fe49",
                    Name = "Casey Stracke",
                },
                TotalAmount = 7301.22M,
                Tracking = new Tracking() {
                    InvoiceTo = new RecordRef() {
                        DataType = "transfer",
                        Id = "48633323-f9b7-47f3-a410-0674ebf69280",
                    },
                    RecordRefs = new List<RecordRef>() {
                        new RecordRef() {
                            DataType = "transfer",
                            Id = "1ba77a89-ebf7-437a-a420-3ce5e6a95d8a",
                        },
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "0d446ce2-af7a-473c-b3be-453f870b326b",
                        Name = "Joanna Kohler",
                    },
                },
                UnitAmount = 1864.58M,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "maxime",
        PaymentAllocations = new List<AccountingPaymentAllocation>() {
            new AccountingPaymentAllocation() {
                Allocation = new AccountingPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "EUR",
                    CurrencyRate = 1175.31M,
                    TotalAmount = 6748.48M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "8422bb67-9d23-4227-95bf-0cbb1e31b8b9",
                        Name = "Dixie Durgan",
                    },
                    Currency = "GBP",
                    CurrencyRate = 6772.63M,
                    Id = "1108e0ad-cf4b-4921-879f-ce953f73ef7f",
                    Note = "distinctio",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "odio",
                    TotalAmount = 6304.48M,
                },
            },
        },
        Reference = "facilis",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        SubTotal = 4981.4M,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "dolore", new Dictionary<string, object>() {
                    { "quibusdam", "illum" },
                } },
            },
        },
        TaxAmount = 1943.42M,
        TotalAmount = 6178.77M,
    },
    AllowSyncOnPushComplete = false,
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    TimeoutInMinutes = 773326,
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

The *Get create direct cost model* endpoint returns the expected data for the request payload when creating a [direct cost](https://docs.codat.io/accounting-api#/schemas/DirectCost) for a given company and integration.

[Direct costs](https://docs.codat.io/accounting-api#/schemas/DirectCost) are purchases of items that are paid off at the point of the purchase.

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

