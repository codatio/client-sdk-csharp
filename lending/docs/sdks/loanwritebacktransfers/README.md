# LoanWriteback.Transfers

### Available Operations

* [Create](#create) - Create transfer
* [GetCreateModel](#getcreatemodel) - Get create transfer model

## Create

The *Create transfer* endpoint creates a new [transfer](https://docs.codat.io/accounting-api#/schemas/Transfer) for a given company's connection.

[Transfers](https://docs.codat.io/accounting-api#/schemas/Transfer) record the movement of money between two bank accounts, or between a bank account and a nominal account.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create transfer model](https://docs.codat.io/accounting-api#/operations/get-create-transfers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=transfers) for integrations that support creating an account.


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

var res = await sdk.LoanWriteback.Transfers.CreateAsync(new CreateTransferRequest() {
    AccountingTransfer = new AccountingTransfer() {
        ContactRef = new AccountingTransferContactRef() {
            DataType = "velit",
            Id = "66c8dd6b-1442-4907-8747-78a7bd466d28",
        },
        Date = "2022-10-23T00:00:00.000Z",
        DepositedRecordRefs = new List<RecordRef>() {
            new RecordRef() {
                DataType = "journalEntry",
                Id = "0ab3cdca-4251-4904-a523-c7e0bc7178e4",
            },
        },
        Description = "odio",
        From = new TransferAccount() {
            AccountRef = new AccountRef() {
                Id = "96f2a70c-6882-482a-a482-562f222e9817",
                Name = "Sheldon Boehm",
            },
            Amount = 7241.68M,
            Currency = "EUR",
        },
        Id = "61e6b7b9-5bc0-4ab3-820c-4f3789fd871f",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "pariatur", new Dictionary<string, object>() {
                    { "possimus", "quia" },
                } },
            },
        },
        To = new TransferAccount() {
            AccountRef = new AccountRef() {
                Id = "efd121aa-6f1e-4674-bdb0-4f15756082d6",
                Name = "Miss Percy Parisian",
            },
            Amount = 984.78M,
            Currency = "EUR",
        },
        TrackingCategoryRefs = new List<TrackingCategoryRef>() {
            new TrackingCategoryRef() {
                Id = "17051339-d080-486a-9840-394c26071f93",
                Name = "Ms. Glen Zboncak",
            },
        },
    },
    AllowSyncOnPushComplete = false,
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    TimeoutInMinutes = 162954,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [CreateTransferRequest](../../models/operations/CreateTransferRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[CreateTransferResponse](../../models/operations/CreateTransferResponse.md)**


## GetCreateModel

The *Get create transfer model* endpoint returns the expected data for the request payload when creating a [transfer](https://docs.codat.io/accounting-api#/schemas/Transfer) for a given company and integration.

[Transfers](https://docs.codat.io/accounting-api#/schemas/Transfer) record the movement of money between two bank accounts, or between a bank account and a nominal account.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=transfers) for integrations that support creating a transfer.


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

var res = await sdk.LoanWriteback.Transfers.GetCreateModelAsync(new GetCreateTransfersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetCreateTransfersModelRequest](../../models/operations/GetCreateTransfersModelRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[GetCreateTransfersModelResponse](../../models/operations/GetCreateTransfersModelResponse.md)**

