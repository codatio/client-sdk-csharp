# dataIntegrity

## Overview

Data integrity is important

### Available Operations

* [GetDataIntegrityStatus](#getdataintegritystatus) - Get data integrity status
* [GetDataIntegritySummaries](#getdataintegritysummaries) - Get data integrity summary
* [ListDataTypeDataIntegrityDetails](#listdatatypedataintegritydetails) - List data type data integrity

## GetDataIntegrityStatus

Gets match status for a given company and datatype.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.DataIntegrity;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.DataIntegrity.GetDataIntegrityStatus(request);
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `request`                                                                                    | [GetDataIntegrityStatusRequest](../../Models/DataIntegrity/GetDataIntegrityStatusRequest.md) | :heavy_check_mark:                                                                           | The request object to use for the request.                                                   |


### Response

**[GetDataIntegrityStatusResponse](../../Models/DataIntegrity/GetDataIntegrityStatusResponse.md)**


## GetDataIntegritySummaries

Gets match summary for a given company and datatype, optionally restricted by a Codat query string.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.DataIntegrity;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.DataIntegrity.GetDataIntegritySummaries(request);
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `request`                                                                                          | [GetDataIntegritySummariesRequest](../../Models/DataIntegrity/GetDataIntegritySummariesRequest.md) | :heavy_check_mark:                                                                                 | The request object to use for the request.                                                         |


### Response

**[GetDataIntegritySummariesResponse](../../Models/DataIntegrity/GetDataIntegritySummariesResponse.md)**


## ListDataTypeDataIntegrityDetails

Gets record-by-record match results for a given company and datatype, optionally restricted by a Codat query string.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.DataIntegrity;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.DataIntegrity.ListDataTypeDataIntegrityDetails(request);
```

### Parameters

| Parameter                                                                                                        | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                        | [ListDataTypeDataIntegrityDetailsRequest](../../Models/DataIntegrity/ListDataTypeDataIntegrityDetailsRequest.md) | :heavy_check_mark:                                                                                               | The request object to use for the request.                                                                       |


### Response

**[ListDataTypeDataIntegrityDetailsResponse](../../Models/DataIntegrity/ListDataTypeDataIntegrityDetailsResponse.md)**

