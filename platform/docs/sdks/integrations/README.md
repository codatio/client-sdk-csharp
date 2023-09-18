# Integrations

## Overview

View and manage your available integrations in Codat.

### Available Operations

* [Get](#get) - Get integration
* [GetBranding](#getbranding) - Get branding
* [List](#list) - List integrations

## Get

Get single integration, by platformKey

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

var res = await sdk.Integrations.GetAsync(new GetIntegrationRequest() {
    PlatformKey = "gbol",
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetIntegrationRequest](../../models/operations/GetIntegrationRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[GetIntegrationResponse](../../models/operations/GetIntegrationResponse.md)**


## GetBranding

Get branding for platform.

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

var res = await sdk.Integrations.GetBrandingAsync(new GetIntegrationsBrandingRequest() {
    PlatformKey = "gbol",
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetIntegrationsBrandingRequest](../../models/operations/GetIntegrationsBrandingRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[GetIntegrationsBrandingResponse](../../models/operations/GetIntegrationsBrandingResponse.md)**


## List

List your available integrations

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

var res = await sdk.Integrations.ListAsync(new ListIntegrationsRequest() {
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "corrupti",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListIntegrationsRequest](../../models/operations/ListIntegrationsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListIntegrationsResponse](../../models/operations/ListIntegrationsResponse.md)**

