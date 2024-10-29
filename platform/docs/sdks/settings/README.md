# Settings
(*Settings*)

## Overview

Manage company profile configuration, sync settings, and API keys.

### Available Operations

* [GetProfile](#getprofile) - Get profile
* [UpdateProfile](#updateprofile) - Update profile
* [GetSyncSettings](#getsyncsettings) - Get sync settings
* [UpdateSyncSettings](#updatesyncsettings) - Update all sync settings
* [ListApiKeys](#listapikeys) - List API keys
* [CreateApiKey](#createapikey) - Create API key
* [DeleteApiKey](#deleteapikey) - Delete API key

## GetProfile

Fetch your Codat profile.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Settings.GetProfileAsync();

// handle response
```

### Response

**[GetProfileResponse](../../Models/Requests/GetProfileResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 429, 500, 503              | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## UpdateProfile

Update your Codat profile

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using System.Collections.Generic;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

Profile req = new Profile() {
    Name = "Bob's Burgers",
    LogoUrl = "https://client-images.codat.io/logo/042399f5-d104-4f38-9ce8-cac3524f4e88_5806cb1f-7342-4c0e-a0a8-99bfbc47b0ff.png",
    IconUrl = "https://client-images.codat.io/icon/042399f5-d104-4f38-9ce8-cac3524f4e88_3f5623af-d992-4c22-bc08-e58c520a8526.ico",
    RedirectUrl = "https://bobs-burgers.{countrySuffix}/{companyId}",
    WhiteListUrls = new List<string>() {
        "https://bobs-burgers.com",
        "https://bobs-burgers.co.uk",
    },
    AlertAuthHeader = "Bearer tXEiHiRK7XCtI8TNHbpGs1LI1pumdb4Cl1QIo7B2",
    ConfirmCompanyName = true,
};

var res = await sdk.Settings.UpdateProfileAsync(req);

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `request`                                     | [Profile](../../Models/Components/Profile.md) | :heavy_check_mark:                            | The request object to use for the request.    |

### Response

**[UpdateProfileResponse](../../Models/Requests/UpdateProfileResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 429, 500, 503              | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## GetSyncSettings

Retrieve the [sync settings](https://docs.codat.io/knowledge-base/advanced-sync-settings) for your client. This includes how often data types should be queued to be updated, and how much history should be fetched.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Settings.GetSyncSettingsAsync();

// handle response
```

### Response

**[GetProfileSyncSettingsResponse](../../Models/Requests/GetProfileSyncSettingsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 429, 500, 503              | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## UpdateSyncSettings

Update sync settings for all data types.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Requests;
using System.Collections.Generic;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateProfileSyncSettingsRequestBody req = new UpdateProfileSyncSettingsRequestBody() {
    ClientId = "c4907f05-7024-4fc0-bf55-4785be5c9671",
    Settings = new List<SyncSetting>() {
        new SyncSetting() {
            DataType = Codat.Platform.Models.Components.PropertieDataType.Invoices,
            FetchOnFirstLink = true,
            SyncSchedule = 24,
            SyncOrder = 0,
            SyncFromUtc = "2020-01-01T12:00:00.000Z",
            SyncFromWindow = 24,
            MonthsToSync = 24,
            IsLocked = true,
        },
    },
};

var res = await sdk.Settings.UpdateSyncSettingsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [UpdateProfileSyncSettingsRequestBody](../../Models/Requests/UpdateProfileSyncSettingsRequestBody.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[UpdateProfileSyncSettingsResponse](../../Models/Requests/UpdateProfileSyncSettingsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 429, 500, 503              | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## ListApiKeys

Use the *List API keys* endpoint to return a list of all API keys that currently exist for your client. This includes keys created via the Portal UI or the *Create API keys* endpoint.

[API keys](https://docs.codat.io/platform-api#/schemas/apiKeys) are tokens used to control access to the API. Include this token in the `Authorization` header parameter when making API calls, following the word "Basic" and a space with your API key.

You can [read more](https://docs.codat.io/using-the-api/authentication) about authentication at Codat and managing API keys via the Portal UI or API.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Settings.ListApiKeysAsync();

// handle response
```

### Response

**[ListApiKeysResponse](../../Models/Requests/ListApiKeysResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 429, 500, 503              | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

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
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateApiKey req = new CreateApiKey() {
    Name = "azure-invoice-finance-processor",
};

var res = await sdk.Settings.CreateApiKeyAsync(req);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `request`                                               | [CreateApiKey](../../Models/Components/CreateApiKey.md) | :heavy_check_mark:                                      | The request object to use for the request.              |

### Response

**[CreateApiKeyResponse](../../Models/Requests/CreateApiKeyResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400, 401, 402, 403, 409, 429, 500, 503    | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

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
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

DeleteApiKeyRequest req = new DeleteApiKeyRequest() {
    ApiKeyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Settings.DeleteApiKeyAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [DeleteApiKeyRequest](../../Models/Requests/DeleteApiKeyRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[DeleteApiKeyResponse](../../Models/Requests/DeleteApiKeyResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503         | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |