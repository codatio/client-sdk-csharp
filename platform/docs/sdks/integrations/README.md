# Integrations
(*Integrations*)

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
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetIntegrationRequest req = new GetIntegrationRequest() {
    PlatformKey = "gbol",
};

var res = await sdk.Integrations.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetIntegrationRequest](../../Models/Operations/GetIntegrationRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[GetIntegrationResponse](../../Models/Operations/GetIntegrationResponse.md)**


## GetBranding

Get branding for platform.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetIntegrationsBrandingRequest req = new GetIntegrationsBrandingRequest() {
    PlatformKey = "gbol",
};

var res = await sdk.Integrations.GetBrandingAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetIntegrationsBrandingRequest](../../Models/Operations/GetIntegrationsBrandingRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[GetIntegrationsBrandingResponse](../../Models/Operations/GetIntegrationsBrandingResponse.md)**


## List

List your available integrations

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListIntegrationsRequest req = new ListIntegrationsRequest() {
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.Integrations.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListIntegrationsRequest](../../Models/Operations/ListIntegrationsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListIntegrationsResponse](../../Models/Operations/ListIntegrationsResponse.md)**

