# Settings

## Overview

Manage your Codat instance.

### Available Operations

* [CreateApiKey](#createapikey) - Create API key
* [DeleteApiKey](#deleteapikey) - Delete api key
* [~~GetProfile~~](#getprofile) - Get profile :warning: **Deprecated**
* [GetSyncSettings](#getsyncsettings) - Get sync settings
* [ListApiKeys](#listapikeys) - List API keys
* [UpdateProfile](#updateprofile) - Update profile
* [UpdateSyncSettings](#updatesyncsettings) - Update all sync settings

## CreateApiKey

Use the *Create API keys* endpoint to generate a new API key for your client.

[API keys](https://docs.codat.io/platform-api#/schemas/apiKeys) are tokens used to control access to the API. Include this token in the `Authorization` header parameter when making API calls, following the word "Basic" and a space with your API key.

You can [read more](https://docs.codat.io/using-the-api/authentication) about authentication at Codat and managing API keys via the Portal UI or API.

### Tips and pitfalls

* Your first API key is created for you. Access this key via [Codat's Portal](https://app.codat.io/developers/api-keys).
* If you require multiple API keys, perform multiple calls to the *Create API keys* endpoint. 
* The number of API keys is limited to 10. If you have reached the maximum amount of keys, use the *Delete API key* endpoint to delete an unused key first.

### Example Usage

```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Settings.CreateApiKeyAsync(new CreateApiKey() {
    Name = "azure-invoice-finance-processor",
});

// handle response
```

### Parameters

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `request`                                           | [CreateApiKey](../../models/shared/CreateApiKey.md) | :heavy_check_mark:                                  | The request object to use for the request.          |


### Response

**[CreateApiKeyResponse](../../models/operations/CreateApiKeyResponse.md)**


## DeleteApiKey

Use the *Delete API keys* endpoint to delete an existing API key, providing its valid `id` as a parameter. Note that this operation is not reversible.

[API keys](https://docs.codat.io/platform-api#/schemas/apiKeys) are tokens used to control access to the API. Include this token in the `Authorization` header parameter when making API calls, following the word "Basic" and a space with your API key.

You can [read more](https://docs.codat.io/using-the-api/authentication) about authentication at Codat and managing API keys via the Portal UI or API.

### Tips and pitfalls

* It is possible to delete the last remaining API key. If this happens, a new key can be created via the [API key management page](https://app.codat.io/developers/api-keys) of the Portal.
* It is possible to delete the API key used to authenticate the *Delete API key* request.

### Example Usage

```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;
using CodatPlatform.Models.Operations;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Settings.DeleteApiKeyAsync(new DeleteApiKeyRequest() {
    ApiKeyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [DeleteApiKeyRequest](../../models/operations/DeleteApiKeyRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[DeleteApiKeyResponse](../../models/operations/DeleteApiKeyResponse.md)**


## ~~GetProfile~~

Fetch your Codat profile.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Settings.GetProfileAsync();

// handle response
```


### Response

**[GetProfileResponse](../../models/operations/GetProfileResponse.md)**


## GetSyncSettings

Retrieve the [sync settings](https://docs.codat.io/knowledge-base/advanced-sync-settings) for your client. This includes how often data types should be queued to be updated, and how much history should be fetched.

### Example Usage

```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Settings.GetSyncSettingsAsync();

// handle response
```


### Response

**[GetProfileSyncSettingsResponse](../../models/operations/GetProfileSyncSettingsResponse.md)**


## ListApiKeys

Use the *List API keys* endpoint to return a list of all API keys that currently exist for your client. This includes keys created via the Portal UI or the *Create API keys* endpoint.

[API keys](https://docs.codat.io/platform-api#/schemas/apiKeys) are tokens used to control access to the API. Include this token in the `Authorization` header parameter when making API calls, following the word "Basic" and a space with your API key.

You can [read more](https://docs.codat.io/using-the-api/authentication) about authentication at Codat and managing API keys via the Portal UI or API.

### Example Usage

```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Settings.ListApiKeysAsync();

// handle response
```


### Response

**[ListApiKeysResponse](../../models/operations/ListApiKeysResponse.md)**


## UpdateProfile

Update your Codat profile

### Example Usage

```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Settings.UpdateProfileAsync(new Profile() {
    AlertAuthHeader = "Bearer tXEiHiRK7XCtI8TNHbpGs1LI1pumdb4Cl1QIo7B2",
    ApiKey = "sartANTjHAkLdbyDfaynoTQb7pkmj6hXHmnQKMrB",
    ConfirmCompanyName = false,
    IconUrl = "https://client-images.codat.io/icon/042399f5-d104-4f38-9ce8-cac3524f4e88_3f5623af-d992-4c22-bc08-e58c520a8526.ico",
    LogoUrl = "https://client-images.codat.io/logo/042399f5-d104-4f38-9ce8-cac3524f4e88_5806cb1f-7342-4c0e-a0a8-99bfbc47b0ff.png",
    Name = "Bob's Burgers",
    RedirectUrl = "https://bobs-burgers.{countrySuffix}/{companyId}",
    WhiteListUrls = new List<string>() {
        "https://bobs-burgers.com",
    },
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | [Profile](../../models/shared/Profile.md)  | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[UpdateProfileResponse](../../models/operations/UpdateProfileResponse.md)**


## UpdateSyncSettings

Update sync settings for all data types.

### Example Usage

```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;
using CodatPlatform.Models.Operations;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Settings.UpdateSyncSettingsAsync(new UpdateProfileSyncSettingsRequestBody() {
    ClientId = "07aff1a3-a2fa-4946-b739-251aa52c3f5a",
    OverridesDefaults = false,
    Settings = new List<SyncSetting>() {
        new SyncSetting() {
            DataType = CodatPlatform.Models.Shared.DataType.Invoices,
            FetchOnFirstLink = false,
            IsLocked = false,
            MonthsToSync = 24,
            SyncFromUtc = "2022-10-23T00:00:00.000Z",
            SyncFromWindow = 24,
            SyncOrder = 13571,
            SyncSchedule = 24,
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [UpdateProfileSyncSettingsRequestBody](../../models/operations/UpdateProfileSyncSettingsRequestBody.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |


### Response

**[UpdateProfileSyncSettingsResponse](../../models/operations/UpdateProfileSyncSettingsResponse.md)**

