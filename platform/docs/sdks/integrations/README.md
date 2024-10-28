# Integrations
(*Integrations*)

## Overview

Get a list of integrations supported by Codat and their logos.

### Available Operations

* [List](#list) - List integrations
* [Get](#get) - Get integration
* [GetBranding](#getbranding) - Get branding

## List

List your available integrations

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListIntegrationsRequest req = new ListIntegrationsRequest() {
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Integrations.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListIntegrationsRequest](../../Models/Requests/ListIntegrationsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListIntegrationsResponse](../../Models/Requests/ListIntegrationsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400, 401, 402, 403, 429, 500, 503         | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## Get

Get single integration, by platformKey

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetIntegrationRequest req = new GetIntegrationRequest() {
    PlatformKey = "gbol",
};

var res = await sdk.Integrations.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetIntegrationRequest](../../Models/Requests/GetIntegrationRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[GetIntegrationResponse](../../Models/Requests/GetIntegrationResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503         | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## GetBranding

Get branding for platform.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetIntegrationsBrandingRequest req = new GetIntegrationsBrandingRequest() {
    PlatformKey = "gbol",
};

var res = await sdk.Integrations.GetBrandingAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetIntegrationsBrandingRequest](../../Models/Requests/GetIntegrationsBrandingRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[GetIntegrationsBrandingResponse](../../Models/Requests/GetIntegrationsBrandingResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503         | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |