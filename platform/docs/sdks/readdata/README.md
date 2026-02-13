# ReadData

## Overview

View validation outcomes for completed read data operations.

### Available Operations

* [GetValidationResults](#getvalidationresults) - Get validation results

## GetValidationResults

Use the **Get validation results** endpoint to review warnings and errors encountered during the data type validation phase.

The validation result [schema](https://docs.codat.io/platform-api#/schemas/ValidationResult) contains two message arrays:

- **`warnings`** array lists potential issues with the data type that may require attention but don't block usage.
- **`errors`** array contains critical issues that must be resolved before the data type can be used.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-read-validation-results" method="get" path="/companies/{companyId}/sync/{datasetId}/validation" example="Validation result" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetReadValidationResultsRequest req = new GetReadValidationResultsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    DatasetId = "0812af6e-436a-491f-9056-db91cb961ad3",
};

var res = await sdk.ReadData.GetValidationResultsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetReadValidationResultsRequest](../../Models/Requests/GetReadValidationResultsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[GetReadValidationResultsResponse](../../Models/Requests/GetReadValidationResultsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |