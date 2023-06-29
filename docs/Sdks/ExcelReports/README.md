# excelReports

## Overview

Downloadable reports

### Available Operations

* [GenerateExcelReport](#generateexcelreport) - Generate Excel report
* [GetAccountingMarketingMetrics](#getaccountingmarketingmetrics) - Get marketing metrics report
* [GetExcelReport](#getexcelreport) - Download Excel report
* [GetExcelReportGenerationStatus](#getexcelreportgenerationstatus) - Get Excel report status

## GenerateExcelReport

Generate an Excel report which can subsequently be downloaded.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.ExcelReports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.ExcelReports.GenerateExcelReport(request);
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GenerateExcelReportRequest](../../Models/ExcelReports/GenerateExcelReportRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[GenerateExcelReportResponse](../../Models/ExcelReports/GenerateExcelReportResponse.md)**


## GetAccountingMarketingMetrics

Get the marketing metrics from an accounting source for a given company.

Request an Excel report for download.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.ExcelReports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.ExcelReports.GetAccountingMarketingMetrics(request);
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [GetAccountingMarketingMetricsRequest](../../Models/ExcelReports/GetAccountingMarketingMetricsRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[GetAccountingMarketingMetricsResponse](../../Models/ExcelReports/GetAccountingMarketingMetricsResponse.md)**


## GetExcelReport

Download the previously generated Excel report to a local drive.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.ExcelReports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.ExcelReports.GetExcelReport(request);
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetExcelReportRequest](../../Models/ExcelReports/GetExcelReportRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[GetExcelReportResponse](../../Models/ExcelReports/GetExcelReportResponse.md)**


## GetExcelReportGenerationStatus

Returns the status of the latest report requested.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.ExcelReports;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.ExcelReports.GetExcelReportGenerationStatus(request);
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [GetExcelReportGenerationStatusRequest](../../Models/ExcelReports/GetExcelReportGenerationStatusRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |


### Response

**[GetExcelReportGenerationStatusResponse](../../Models/ExcelReports/GetExcelReportGenerationStatusResponse.md)**

