# Integrations
(*Integrations*)

## Overview

View useful information about codat's integrations.

### Available Operations

* [GetBranding](#getbranding) - Get branding for an integration
* [List](#list) - List integrations

## GetBranding

Retrieve Integration branding assets.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetIntegrationBrandingRequest req = new GetIntegrationBrandingRequest() {
    PlatformKey = "gbol",
};

var res = await sdk.Integrations.GetBrandingAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetIntegrationBrandingRequest](../../Models/Operations/GetIntegrationBrandingRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[GetIntegrationBrandingResponse](../../Models/Operations/GetIntegrationBrandingResponse.md)**


## List

Retrieve a list of available integrations support by data type and state of release.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(security: new Security() {
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

