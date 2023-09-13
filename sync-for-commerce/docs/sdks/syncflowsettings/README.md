# syncFlowSettings

## Overview

Configure preferences for any given Sync for Commerce company using sync flow.

### Available Operations

* [GetConfigTextSyncFlow](#getconfigtextsyncflow) - Get preferences for text fields
* [GetVisibleAccounts](#getvisibleaccounts) - List visible accounts
* [UpdateConfigTextSyncFlow](#updateconfigtextsyncflow) - Update preferences for text fields
* [UpdateVisibleAccountsSyncFlow](#updatevisibleaccountssyncflow) - Update visible accounts

## GetConfigTextSyncFlow

Return preferences set for the text fields on sync flow.

### Example Usage

```csharp
using CodatSyncCommerce;
using CodatSyncCommerce.Models.Shared;

var sdk = new CodatSyncCommerceSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SyncFlowSettings.GetConfigTextSyncFlowAsync();

// handle response
```


### Response

**[GetConfigTextSyncFlowResponse](../../models/operations/GetConfigTextSyncFlowResponse.md)**


## GetVisibleAccounts

Return accounts which are visible on sync flow.

### Example Usage

```csharp
using CodatSyncCommerce;
using CodatSyncCommerce.Models.Shared;
using CodatSyncCommerce.Models.Operations;

var sdk = new CodatSyncCommerceSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SyncFlowSettings.GetVisibleAccountsAsync(new GetVisibleAccountsRequest() {
    ClientId = "e0f467cc-8796-4ed1-91a0-5dfc2ddf7cc7",
    PlatformKey = "8ca1ba92-8fc8-4167-82cb-739205929396",
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetVisibleAccountsRequest](../../models/operations/GetVisibleAccountsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetVisibleAccountsResponse](../../models/operations/GetVisibleAccountsResponse.md)**


## UpdateConfigTextSyncFlow

Set preferences for the text fields on sync flow.

### Example Usage

```csharp
using CodatSyncCommerce;
using CodatSyncCommerce.Models.Shared;

var sdk = new CodatSyncCommerceSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SyncFlowSettings.UpdateConfigTextSyncFlowAsync(new Dictionary<string, Localization>() {
    { "hic", new Localization() {
        Required = false,
        Text = "saepe",
    } },
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | Dictionary<String, [Localization](../../models/shared/Localization.md)> | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[UpdateConfigTextSyncFlowResponse](../../models/operations/UpdateConfigTextSyncFlowResponse.md)**


## UpdateVisibleAccountsSyncFlow

Update which accounts are visible on sync flow.

### Example Usage

```csharp
using CodatSyncCommerce;
using CodatSyncCommerce.Models.Shared;
using CodatSyncCommerce.Models.Operations;

var sdk = new CodatSyncCommerceSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SyncFlowSettings.UpdateVisibleAccountsSyncFlowAsync(new UpdateVisibleAccountsSyncFlowRequest() {
    VisibleAccounts = new VisibleAccounts() {
        VisibleAccounts = new List<string>() {
            "fuga",
        },
    },
    PlatformKey = "7596eb10-faaa-4235-ac59-55907aff1a3a",
});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [UpdateVisibleAccountsSyncFlowRequest](../../models/operations/UpdateVisibleAccountsSyncFlowRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |


### Response

**[UpdateVisibleAccountsSyncFlowResponse](../../models/operations/UpdateVisibleAccountsSyncFlowResponse.md)**
