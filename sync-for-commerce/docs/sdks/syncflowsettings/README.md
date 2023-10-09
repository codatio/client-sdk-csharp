# SyncFlowSettingsSDK
(*SyncFlowSettings*)

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
    ClientId = "86fe9741-738d-4f2c-8e96-9c3f84156e91",
    PlatformKey = "gbol",
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
    { "West", new Localization() {} },
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
            "Coordinator",
        },
    },
    PlatformKey = "gbol",
});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [UpdateVisibleAccountsSyncFlowRequest](../../models/operations/UpdateVisibleAccountsSyncFlowRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |


### Response

**[UpdateVisibleAccountsSyncFlowResponse](../../models/operations/UpdateVisibleAccountsSyncFlowResponse.md)**

