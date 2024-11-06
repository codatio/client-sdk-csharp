# ExcelReports
(*ExcelReports*)

## Overview

Download reports in Excel format.

### Available Operations

* [Generate](#generate) - Generate Excel report
* [GetStatus](#getstatus) - Get Excel report status
* [Download](#download) - Download Excel report

## Generate

The *Generate Excel report* endpoint requests the production of a downloadable Excel file for a report type specified in the `reportType` query parameter.

In response, the endpoint returns the [status](https://docs.codat.io/lending-api#/schemas/ExcelStatus) detailing the current state of the report generation request.

### Report types

| reportType                                                                           | Description                                                                                                                                   |
|--------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------|
| `audit`                          | Identifies inaccurate or out-of-date accounts, helping you to make decisions with confidence.                                                   || [audit](https://docs.codat.io/lending/excel/audit-report)                            | Identify inaccurate or out-of-date accounts, helping you to make decisions with confidence.                                                   |
| `enhancedCashFlow`    | Provides a fully categorized list of bank transactions for a company, allowing lenders to accurately forecast a company's cash flow.  |
| `enhancedFinancials` | Supports decision-making using fully categorized financial statements to allow lenders to automate their underwriting processes.                |
| `enhancedInvoices`     | Helps verify that payments have been made against historic invoices. Great for invoice finance lenders.                                       |

[Learn more](https://docs.codat.io/lending/features/excel-download-overview#feature-components) about valid Excel report types.




### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GenerateExcelReportRequest req = new GenerateExcelReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportType = Codat.Lending.Models.Components.ExcelReportTypes.EnhancedInvoices,
};

var res = await sdk.ExcelReports.GenerateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GenerateExcelReportRequest](../../Models/Requests/GenerateExcelReportRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[GenerateExcelReportResponse](../../Models/Requests/GenerateExcelReportResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503   | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## GetStatus

﻿The *Get Excel report status* returns the status of the report mostly recently requested for Excel generation. It does not return the status of any historical report requests. 

Poll this endpoint to check the progress of the report once you have requested its generation. This will not affect the generation of the report. 

When the report generation completes successfully, the `inProgress` property will be marked as `false` and the `success` field will be marked as `true`.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetExcelReportGenerationStatusRequest req = new GetExcelReportGenerationStatusRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportType = Codat.Lending.Models.Components.ExcelReportTypes.EnhancedCashFlow,
};

var res = await sdk.ExcelReports.GetStatusAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [GetExcelReportGenerationStatusRequest](../../Models/Requests/GetExcelReportGenerationStatusRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[GetExcelReportGenerationStatusResponse](../../Models/Requests/GetExcelReportGenerationStatusResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503   | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Download

﻿The *Download Excel report* endpoint downloads the latest successfully generated Excel report of a specified report type for a given company. 

The downloadable Excel file is returned in the response. You can save it to your local machine.

You can [learn more](https://docs.codat.io/lending/features/excel-download-overview#feature-components) about valid Excel report types.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

DownloadExcelReportRequest req = new DownloadExcelReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportType = Codat.Lending.Models.Components.ExcelReportTypes.EnhancedFinancials,
};

var res = await sdk.ExcelReports.DownloadAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [DownloadExcelReportRequest](../../Models/Requests/DownloadExcelReportRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[DownloadExcelReportResponse](../../Models/Requests/DownloadExcelReportResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503   | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |