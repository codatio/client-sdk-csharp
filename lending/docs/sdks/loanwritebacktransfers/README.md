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
            DataType = "laborum",
            Id = "c366c8dd-6b14-4429-8747-4778a7bd466d",
        },
        Date = "2022-10-23T00:00:00.000Z",
        DepositedRecordRefs = new List<RecordRef>() {
            new RecordRef() {
                DataType = "accountTransaction",
                Id = "c10ab3cd-ca42-4519-84e5-23c7e0bc7178",
            },
        },
        Description = "accusamus",
        From = new TransferAccount() {
            AccountRef = new AccountRef() {
                Id = "4796f2a7-0c68-4828-aaa4-82562f222e98",
                Name = "Tamara Vandervort IV",
            },
            Amount = 8003.79M,
            Currency = "EUR",
        },
        Id = "e61e6b7b-95bc-40ab-bc20-c4f3789fd871",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "sint", new Dictionary<string, object>() {
                    { "pariatur", "possimus" },
                } },
            },
        },
        To = new TransferAccount() {
            AccountRef = new AccountRef() {
                Id = "2efd121a-a6f1-4e67-8bdb-04f15756082d",
                Name = "Cassandra Ward V",
            },
            Amount = 9453.02M,
            Currency = "GBP",
        },
        TrackingCategoryRefs = new List<TrackingCategoryRef>() {
            new TrackingCategoryRef() {
                Id = "d1705133-9d08-4086-a184-0394c26071f9",
                Name = "Camille Hirthe III",
            },
        },
    },
    AllowSyncOnPushComplete = false,
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    TimeoutInMinutes = 310067,
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

