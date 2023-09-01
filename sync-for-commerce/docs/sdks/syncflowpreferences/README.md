# syncFlowPreferences

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

var res = await sdk.SyncFlowPreferences.GetConfigTextSyncFlowAsync();

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

var res = await sdk.SyncFlowPreferences.GetVisibleAccountsAsync(new GetVisibleAccountsRequest() {
    ClientId = "67cc8796-ed15-41a0-9dfc-2ddf7cc78ca1",
    PlatformKey = "ba928fc8-1674-42cb-b392-05929396fea7",
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

var res = await sdk.SyncFlowPreferences.UpdateConfigTextSyncFlowAsync(new Dictionary<string, Localization>() {
    { "iste", new Localization() {
        Required = false,
        Text = "iure",
    } },
    { "saepe", new Localization() {
        Required = false,
        Text = "quidem",
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

var res = await sdk.SyncFlowPreferences.UpdateVisibleAccountsSyncFlowAsync(new UpdateVisibleAccountsSyncFlowRequest() {
    VisibleAccounts = new VisibleAccounts() {
        VisibleAccounts = new List<string>() {
            "ipsa",
        },
    },
    PlatformKey = "faaa2352-c595-4590-baff-1a3a2fa94677",
});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [UpdateVisibleAccountsSyncFlowRequest](../../models/operations/UpdateVisibleAccountsSyncFlowRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |


### Response

**[UpdateVisibleAccountsSyncFlowResponse](../../models/operations/UpdateVisibleAccountsSyncFlowResponse.md)**

