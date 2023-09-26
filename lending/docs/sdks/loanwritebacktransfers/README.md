# LoanWriteback.Transfers

### Available Operations

* [Create](#create) - Create transfer
* [GetCreateModel](#getcreatemodel) - Get create transfer model

## Create

The *Create transfer* endpoint creates a new [transfer](https://docs.codat.io/lending-api#/schemas/Transfer) for a given company's connection.

[Transfers](https://docs.codat.io/lending-api#/schemas/Transfer) record the movement of money between two bank accounts, or between a bank account and a nominal account.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create transfer model](https://docs.codat.io/lending-api#/operations/get-create-transfers-model).

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
            DataType = CodatLending.Models.Shared.DataType.Invoices,
            Id = "ac366c8d-d6b1-4442-9074-74778a7bd466",
        },
        Date = "2022-10-23T00:00:00.000Z",
        DepositedRecordRefs = new List<RecordRef>() {
            new RecordRef() {
                DataType = "journalEntry",
                Id = "8c10ab3c-dca4-4251-904e-523c7e0bc717",
            },
        },
        Description = "totam",
        From = new TransferAccount() {
            AccountRef = new AccountRef() {
                Id = "e4796f2a-70c6-4882-82aa-482562f222e9",
                Name = "Carl Koch",
            },
            Amount = 829.71M,
            Currency = "USD",
        },
        Id = "cbe61e6b-7b95-4bc0-ab3c-20c4f3789fd8",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "a", new Dictionary<string, object>() {
                    { "error", "sint" },
                } },
            },
        },
        To = new TransferAccount() {
            AccountRef = new AccountRef() {
                Id = "dd2efd12-1aa6-4f1e-a74b-db04f1575608",
                Name = "Rosemarie Jacobs",
            },
            Amount = 6802.7M,
            Currency = "GBP",
        },
        TrackingCategoryRefs = new List<TrackingCategoryRef>() {
            new TrackingCategoryRef() {
                Id = "9f1d1705-1339-4d08-886a-1840394c2607",
                Name = "Elisa Mosciski",
            },
        },
    },
    AllowSyncOnPushComplete = false,
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 374323,
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

The *Get create transfer model* endpoint returns the expected data for the request payload when creating a [transfer](https://docs.codat.io/lending-api#/schemas/Transfer) for a given company and integration.

[Transfers](https://docs.codat.io/lending-api#/schemas/Transfer) record the movement of money between two bank accounts, or between a bank account and a nominal account.

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

