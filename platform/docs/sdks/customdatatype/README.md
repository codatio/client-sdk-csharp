# CustomDataType
(*CustomDataType*)

## Overview

View and configure custom data types for supported integrations.

### Available Operations

* [Configure](#configure) - Configure custom data type
* [GetConfiguration](#getconfiguration) - Get custom data configuration
* [List](#list) - List custom data type records
* [Refresh](#refresh) - Refresh custom data type

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
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "<YOUR_API_KEY_HERE>",
    });

ConfigureCustomDataTypeRequest req = new ConfigureCustomDataTypeRequest() {
    CustomDataTypeConfiguration = new CustomDataTypeConfiguration() {
        DataSource = "api/purchaseOrders?$filter=currencyCode eq 'NOK'",
        KeyBy = new List<string>() {
            "$[*].id",
        },
        RequiredData = new Dictionary<string, string>() {
            { "currencyCode", "$[*].currencyCode" },
            { "id", "$[*].id" },
            { "number", "$[*].number" },
            { "orderDate", "$[*].orderDate" },
            { "totalAmountExcludingTax", "$[*].totalAmountExcludingTax" },
            { "totalTaxAmount", "$[*].totalTaxAmount" },
            { "vendorName", "$[*].number" },
        },
        SourceModifiedDate = new List<string>() {
            "$[*].lastModifiedDateTime",
        },
    },
    CustomDataIdentifier = "DynamicsPurchaseOrders",
    PlatformKey = "gbol",
};

var res = await sdk.CustomDataType.ConfigureAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ConfigureCustomDataTypeRequest](../../Models/Operations/ConfigureCustomDataTypeRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[ConfigureCustomDataTypeResponse](../../Models/Operations/ConfigureCustomDataTypeResponse.md)**


## GetConfiguration

The *Get custom data configuration* endpoint returns existing configuration details for the specified custom data type and integration pair you previously configured.

A [custom data type](https://docs.codat.io/using-the-api/custom-data) is an additional data type you can create that is not included in Codat's standardized data model.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "<YOUR_API_KEY_HERE>",
    });

GetCustomDataTypeConfigurationRequest req = new GetCustomDataTypeConfigurationRequest() {
    CustomDataIdentifier = "DynamicsPurchaseOrders",
    PlatformKey = "gbol",
};

var res = await sdk.CustomDataType.GetConfigurationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [GetCustomDataTypeConfigurationRequest](../../Models/Operations/GetCustomDataTypeConfigurationRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[GetCustomDataTypeConfigurationResponse](../../Models/Operations/GetCustomDataTypeConfigurationResponse.md)**


## List

The *List custom data type records* endpoint returns a paginated list of records pulled for the specified custom data type you previously configured.

A [custom data type](https://docs.codat.io/using-the-api/custom-data) is an additional data type you can create that is not included in Codat's standardized data model.s endpoint returns a paginated list of records whose schema is defined [Configure custom data type](https://docs.codat.io/platform-api#/operations/configure-custom-data-type)

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "<YOUR_API_KEY_HERE>",
    });

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

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListCustomDataTypeRecordsRequest](../../Models/Operations/ListCustomDataTypeRecordsRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[ListCustomDataTypeRecordsResponse](../../Models/Operations/ListCustomDataTypeRecordsResponse.md)**


## Refresh

The *Refresh custom data type* endpoint refreshes the specified custom data type for a given company. This is an asynchronous operation that will sync updated data from the linked integration into Codat for you to view.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "<YOUR_API_KEY_HERE>",
    });

RefreshCustomDataTypeRequest req = new RefreshCustomDataTypeRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    CustomDataIdentifier = "DynamicsPurchaseOrders",
};

var res = await sdk.CustomDataType.RefreshAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [RefreshCustomDataTypeRequest](../../Models/Operations/RefreshCustomDataTypeRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[RefreshCustomDataTypeResponse](../../Models/Operations/RefreshCustomDataTypeResponse.md)**

