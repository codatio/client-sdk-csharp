# CustomDataType
(*CustomDataType*)

## Overview

Configure and pull additional data types that are not included in Codat's standardized data model.

### Available Operations

* [Configure](#configure) - Configure custom data type
* [GetConfiguration](#getconfiguration) - Get custom data configuration
* [Refresh](#refresh) - Refresh custom data type
* [List](#list) - List custom data type records

## Configure

The *Configure custom data type* endpoint allows you to maintain or change the configuration required to return a custom data type for a specific integration. 

A [custom data type](https://docs.codat.io/using-the-api/custom-data) is an additional data type you can create that is not included in Codat's standardized data model.

### Tips and traps

- You can only configure a single custom data type for a single platform at a time. Use the endpoint multiple times if you need to configure it for multiple platforms. 

- You can only indicate a single data source for each customer data type. 

- Make your custom configuration as similar as possible to our standard data types so you can interact with them in exactly the same way.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;
using System.Collections.Generic;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ConfigureCustomDataTypeRequest req = new ConfigureCustomDataTypeRequest() {
    PlatformKey = "gbol",
    CustomDataIdentifier = "DynamicsPurchaseOrders",
    CustomDataTypeConfiguration = new CustomDataTypeConfiguration() {
        DataSource = "api/purchaseOrders?$filter=currencyCode eq 'NOK'",
        RequiredData = new Dictionary<string, string>() {
            { "currencyCode", "$[*].currencyCode" },
            { "id", "$[*].id" },
            { "number", "$[*].number" },
            { "orderDate", "$[*].orderDate" },
            { "totalAmountExcludingTax", "$[*].totalAmountExcludingTax" },
            { "totalTaxAmount", "$[*].totalTaxAmount" },
            { "vendorName", "$[*].number" },
        },
        KeyBy = new List<string>() {
            "$[*].id",
        },
        SourceModifiedDate = new List<string>() {
            "$[*].lastModifiedDateTime",
        },
    },
};

var res = await sdk.CustomDataType.ConfigureAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ConfigureCustomDataTypeRequest](../../Models/Requests/ConfigureCustomDataTypeRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[ConfigureCustomDataTypeResponse](../../Models/Requests/ConfigureCustomDataTypeResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## GetConfiguration

The *Get custom data configuration* endpoint returns existing configuration details for the specified custom data type and integration pair you previously configured.

A [custom data type](https://docs.codat.io/using-the-api/custom-data) is an additional data type you can create that is not included in Codat's standardized data model.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomDataTypeConfigurationRequest req = new GetCustomDataTypeConfigurationRequest() {
    PlatformKey = "gbol",
    CustomDataIdentifier = "DynamicsPurchaseOrders",
};

var res = await sdk.CustomDataType.GetConfigurationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [GetCustomDataTypeConfigurationRequest](../../Models/Requests/GetCustomDataTypeConfigurationRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[GetCustomDataTypeConfigurationResponse](../../Models/Requests/GetCustomDataTypeConfigurationResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## Refresh

The *Refresh custom data type* endpoint refreshes the specified custom data type for a given company. This is an asynchronous operation that will sync updated data from the linked integration into Codat for you to view.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

RefreshCustomDataTypeRequest req = new RefreshCustomDataTypeRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    CustomDataIdentifier = "DynamicsPurchaseOrders",
};

var res = await sdk.CustomDataType.RefreshAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [RefreshCustomDataTypeRequest](../../Models/Requests/RefreshCustomDataTypeRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[RefreshCustomDataTypeResponse](../../Models/Requests/RefreshCustomDataTypeResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,451,500,503           | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## List

The *List custom data type records* endpoint returns a paginated list of records pulled for the specified custom data type you previously configured.

A [custom data type](https://docs.codat.io/using-the-api/custom-data) is an additional data type you can create that is not included in Codat's standardized data model.s endpoint returns a paginated list of records whose schema is defined [Configure custom data type](https://docs.codat.io/platform-api#/operations/configure-custom-data-type)

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomDataTypeRecordsRequest req = new ListCustomDataTypeRecordsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    CustomDataIdentifier = "DynamicsPurchaseOrders",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.CustomDataType.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [ListCustomDataTypeRecordsRequest](../../Models/Requests/ListCustomDataTypeRecordsRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[ListCustomDataTypeRecordsResponse](../../Models/Requests/ListCustomDataTypeRecordsResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400,401,402,403,404,429,451,500,503       | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |
