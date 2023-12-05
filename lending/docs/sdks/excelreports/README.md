# ExcelReports
(*ExcelReports*)

## Overview

Download reports in Excel format.

### Available Operations

* [Download](#download) - Download Excel report
* [Generate](#generate) - Generate Excel report
* [GetStatus](#getstatus) - Get Excel report status

## Download

﻿The *Download Excel report* endpoint downloads the latest successfully generated Excel report of a specified report type for a given company. 

The downloadable Excel file is returned in the response. You can save it to your local machine.

You can [learn more](https://docs.codat.io/lending/excel/overview) about valid Excel report types.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

DownloadExcelReportRequest req = new DownloadExcelReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportType = ExcelReportTypes.EnhancedFinancials,
};

var res = await sdk.ExcelReports.DownloadAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [DownloadExcelReportRequest](../../Models/Operations/DownloadExcelReportRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[DownloadExcelReportResponse](../../Models/Operations/DownloadExcelReportResponse.md)**


## Generate

The *Generate Excel report* endpoint requests the production of a downloadable Excel file for a report type specified in the `reportType` query parameter.

In response, the endpoint returns the [status](https://docs.codat.io/lending-api#/schemas/ExcelStatus) detailing the current state of the report generation request.

### Report types

| reportType                                                                           | Description                                                                                                                                   |
|--------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------|
| [audit](https://docs.codat.io/lending/excel/audit-report)                            | Identifies inaccurate or out-of-date accounts, helping you to make decisions with confidence.                                                   || [audit](https://docs.codat.io/lending/excel/audit-report)                            | Identify inaccurate or out-of-date accounts, helping you to make decisions with confidence.                                                   |
| [enhancedCashFlow](https://docs.codat.io/lending/excel/enhanced-invoices-report)     | Provides a fully categorized list of bank transactions for a company, allowing lenders to accurately forecast a company's cash flow.  |
| [enhancedFinancials](https://docs.codat.io/lending/excel/enhanced-financials-report) | Supports decision-making using fully categorized financial statements to allow lenders to automate their underwriting processes.                |
| [enhancedInvoices](https://docs.codat.io/lending/excel/enhanced-invoices-report)     | Helps verify that payments have been made against historic invoices. Great for invoice finance lenders.                                       |

[Learn more](https://docs.codat.io/lending/excel/overview) about valid Excel report types.




### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GenerateExcelReportRequest req = new GenerateExcelReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportType = ExcelReportTypes.EnhancedInvoices,
};

var res = await sdk.ExcelReports.GenerateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GenerateExcelReportRequest](../../Models/Operations/GenerateExcelReportRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GenerateExcelReportResponse](../../Models/Operations/GenerateExcelReportResponse.md)**


## GetStatus

﻿The *Get Excel report status* returns the status of the report mostly recently requested for Excel generation. It does not return the status of any historical report requests. 

Poll this endpoint to check the progress of the report once you have requested its generation. This will not affect the generation of the report. 

When the report generation completes successfully, the `inProgress` property will be marked as `false` and the `success` field will be marked as `true`.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetExcelReportGenerationStatusRequest req = new GetExcelReportGenerationStatusRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportType = ExcelReportTypes.EnhancedCashFlow,
};

var res = await sdk.ExcelReports.GetStatusAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [GetExcelReportGenerationStatusRequest](../../Models/Operations/GetExcelReportGenerationStatusRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[GetExcelReportGenerationStatusResponse](../../Models/Operations/GetExcelReportGenerationStatusResponse.md)**

