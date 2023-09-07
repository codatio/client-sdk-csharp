# excelReports

## Overview

Downloadable reports

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
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.ExcelReports.DownloadAsync(new DownloadExcelReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportType = CodatLending.Models.Shared.ExcelReportTypes.EnhancedCashFlow,
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [DownloadExcelReportRequest](../../models/operations/DownloadExcelReportRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[DownloadExcelReportResponse](../../models/operations/DownloadExcelReportResponse.md)**


## Generate

﻿The *Generate Excel report* endpoint requests the production of a downloadable Excel file for a report type specified in the `reportType` query parameter.

In response, the endpoint returns the [status](https://docs.codat.io/lending-api#/schemas/ExcelStatus) detailing the current state of the report generation request.

You can [learn more](https://docs.codat.io/lending/excel/overview) about valid Excel report types.





### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.ExcelReports.GenerateAsync(new GenerateExcelReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportType = CodatLending.Models.Shared.ExcelReportTypes.EnhancedInvoices,
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GenerateExcelReportRequest](../../models/operations/GenerateExcelReportRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GenerateExcelReportResponse](../../models/operations/GenerateExcelReportResponse.md)**


## GetStatus

﻿The *Get Excel report status* returns the status of the report mostly recently requested for Excel generation. It does not return the status of any historical report requests. 

Poll this endpoint to check the progress of the report once you have requested its generation. This will not affect the generation of the report. 

When the report generation completes successfully, the `inProgress` property will be marked as `false` and the `success` field will be marked as `true`.

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.ExcelReports.GetStatusAsync(new GetExcelReportGenerationStatusRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportType = CodatLending.Models.Shared.ExcelReportTypes.Audit,
});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [GetExcelReportGenerationStatusRequest](../../models/operations/GetExcelReportGenerationStatusRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[GetExcelReportGenerationStatusResponse](../../models/operations/GetExcelReportGenerationStatusResponse.md)**
