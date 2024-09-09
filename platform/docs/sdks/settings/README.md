# Settings
(*Settings*)

## Overview

Manage company profile configuration, sync settings, and API keys.

### Available Operations

* [CreateApiKey](#createapikey) - Create API key
* [DeleteApiKey](#deleteapikey) - Delete API key
* [GetProfile](#getprofile) - Get profile
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
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CreateApiKey req = new CreateApiKey() {
    Name = "azure-invoice-finance-processor",
};

var res = await sdk.Settings.CreateApiKeyAsync(req);

// handle response
```

### Parameters

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `request`                                           | [CreateApiKey](../../Models/Shared/CreateApiKey.md) | :heavy_check_mark:                                  | The request object to use for the request.          |

### Response

**[CreateApiKeyResponse](../../Models/Operations/CreateApiKeyResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400,401,402,403,409,429,500,503           | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## DeleteApiKey

Use the *Delete API keys* endpoint to delete an existing API key, providing its valid `id` as a parameter. Note that this operation is not reversible.

[API keys](https://docs.codat.io/platform-api#/schemas/apiKeys) are tokens used to control access to the API. Include this token in the `Authorization` header parameter when making API calls, following the word "Basic" and a space with your API key.

You can [read more](https://docs.codat.io/using-the-api/authentication) about authentication at Codat and managing API keys via the Portal UI or API.

### Tips and pitfalls

* It is possible to delete the last remaining API key. If this happens, a new key can be created via the [API key management page](https://app.codat.io/developers/api-keys) of the Portal.
* It is possible to delete the API key used to authenticate the *Delete API key* request.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Operations;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

DeleteApiKeyRequest req = new DeleteApiKeyRequest() {
    ApiKeyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Settings.DeleteApiKeyAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [DeleteApiKeyRequest](../../Models/Operations/DeleteApiKeyRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[DeleteApiKeyResponse](../../Models/Operations/DeleteApiKeyResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## GetProfile

Fetch your Codat profile.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

var res = await sdk.Settings.GetProfileAsync();

// handle response
```

### Response

**[GetProfileResponse](../../Models/Operations/GetProfileResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,429,500,503                   | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## GetSyncSettings

Retrieve the [sync settings](https://docs.codat.io/knowledge-base/advanced-sync-settings) for your client. This includes how often data types should be queued to be updated, and how much history should be fetched.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

var res = await sdk.Settings.GetSyncSettingsAsync();

// handle response
```

### Response

**[GetProfileSyncSettingsResponse](../../Models/Operations/GetProfileSyncSettingsResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,429,500,503                   | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## ListApiKeys

Use the *List API keys* endpoint to return a list of all API keys that currently exist for your client. This includes keys created via the Portal UI or the *Create API keys* endpoint.

[API keys](https://docs.codat.io/platform-api#/schemas/apiKeys) are tokens used to control access to the API. Include this token in the `Authorization` header parameter when making API calls, following the word "Basic" and a space with your API key.

You can [read more](https://docs.codat.io/using-the-api/authentication) about authentication at Codat and managing API keys via the Portal UI or API.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

var res = await sdk.Settings.ListApiKeysAsync();

// handle response
```

### Response

**[ListApiKeysResponse](../../Models/Operations/ListApiKeysResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,429,500,503                   | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## UpdateProfile

Update your Codat profile

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

Profile req = new Profile() {
    AlertAuthHeader = "Bearer tXEiHiRK7XCtI8TNHbpGs1LI1pumdb4Cl1QIo7B2",
    ConfirmCompanyName = true,
    IconUrl = "https://client-images.codat.io/icon/042399f5-d104-4f38-9ce8-cac3524f4e88_3f5623af-d992-4c22-bc08-e58c520a8526.ico",
    LogoUrl = "https://client-images.codat.io/logo/042399f5-d104-4f38-9ce8-cac3524f4e88_5806cb1f-7342-4c0e-a0a8-99bfbc47b0ff.png",
    Name = "Bob's Burgers",
    RedirectUrl = "https://bobs-burgers.{countrySuffix}/{companyId}",
    WhiteListUrls = new List<string>() {
        "https://bobs-burgers.com",
        "https://bobs-burgers.co.uk",
    },
};

var res = await sdk.Settings.UpdateProfileAsync(req);

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | [Profile](../../Models/Shared/Profile.md)  | :heavy_check_mark:                         | The request object to use for the request. |

### Response

**[UpdateProfileResponse](../../Models/Operations/UpdateProfileResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,429,500,503                   | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## UpdateSyncSettings

Update sync settings for all data types.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Operations;
using System.Collections.Generic;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

UpdateProfileSyncSettingsRequestBody req = new UpdateProfileSyncSettingsRequestBody() {
    ClientId = "ce429104-79f0-4085-a720-e2d40fcc800f",
    Settings = new List<SyncSetting>() {
        new SyncSetting() {
            DataType = Codat.Platform.Models.Shared.DataType.Invoices,
            FetchOnFirstLink = true,
            IsLocked = true,
            MonthsToSync = 24,
            SyncFromUtc = "2020-01-01T12:00:00.000Z",
            SyncFromWindow = 24,
            SyncOrder = 0,
            SyncSchedule = 24,
        },
    },
};

var res = await sdk.Settings.UpdateSyncSettingsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [UpdateProfileSyncSettingsRequestBody](../../Models/Operations/UpdateProfileSyncSettingsRequestBody.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[UpdateProfileSyncSettingsResponse](../../Models/Operations/UpdateProfileSyncSettingsResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,429,500,503                   | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |
