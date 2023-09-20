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
            DataType = "quos",
            Id = "02d502a9-4bb4-4f63-8969-e9a3efa77dfb",
        },
        Currency = "GBP",
        CurrencyRate = 2974.37M,
        Id = "cd66ae39-5efb-49ba-88f3-a66997074ba4",
        IssueDate = "2022-10-23T00:00:00.000Z",
        LineItems = new List<DirectCostLineItem>() {
            new DirectCostLineItem() {
                AccountRef = new AccountRef() {
                    Id = "69b6e214-1959-4890-afa5-63e2516fe4c8",
                    Name = "Dr. Arnold Bradtke",
                },
                Description = "expedita",
                DiscountAmount = 4692.49M,
                DiscountPercentage = 9988.48M,
                ItemRef = new ItemRef() {
                    Id = "d2ed0289-21cd-4dc6-9260-1fb576b0d5f0",
                    Name = "Vincent Anderson",
                },
                Quantity = 9441.24M,
                SubTotal = 7299.91M,
                TaxAmount = 7499.99M,
                TaxRateRef = new TaxRateRef() {
                    EffectiveTaxRate = 1716.29M,
                    Id = "58705320-2c73-4d5f-a9b9-0c28909b3fe4",
                    Name = "Omar Leuschke",
                },
                TotalAmount = 7508.44M,
                Tracking = new Tracking() {
                    InvoiceTo = new RecordRef() {
                        DataType = "accountTransaction",
                        Id = "f4863332-3f9b-477f-ba41-00674ebf6928",
                    },
                    RecordRefs = new List<RecordRef>() {
                        new RecordRef() {
                            DataType = "journalEntry",
                            Id = "d1ba77a8-9ebf-4737-ae42-03ce5e6a95d8",
                        },
                    },
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "a0d446ce-2af7-4a73-8f3b-e453f870b326",
                        Name = "Glen Oberbrunner",
                    },
                },
                UnitAmount = 2776.28M,
            },
        },
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Note = "cupiditate",
        PaymentAllocations = new List<AccountingPaymentAllocation>() {
            new AccountingPaymentAllocation() {
                Allocation = new AccountingPaymentAllocationAllocation() {
                    AllocatedOnDate = "2022-10-23T00:00:00.000Z",
                    Currency = "EUR",
                    CurrencyRate = 7470.8M,
                    TotalAmount = 1175.31M,
                },
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "a8422bb6-79d2-4322-b15b-f0cbb1e31b8b",
                        Name = "Kevin Willms",
                    },
                    Currency = "GBP",
                    CurrencyRate = 2408.29M,
                    Id = "a1108e0a-dcf4-4b92-9879-fce953f73ef7",
                    Note = "hic",
                    PaidOnDate = "2022-10-23T00:00:00.000Z",
                    Reference = "quod",
                    TotalAmount = 4861.6M,
                },
            },
        },
        Reference = "similique",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        SubTotal = 8742.88M,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "ducimus", new Dictionary<string, object>() {
                    { "dolore", "quibusdam" },
                } },
            },
        },
        TaxAmount = 8489.44M,
        TotalAmount = 1943.42M,
    },
    AllowSyncOnPushComplete = false,
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    TimeoutInMinutes = 617877,
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

