# ManageReports
(*ManageReports*)

## Overview

Endpoints to manage generation of reports

### Available Operations

* [GenerateReport](#generatereport) - Generate report
* [ListReports](#listreports) - List reports

## GenerateReport

> **Available as beta release**
>
> This endpoint is part of a beta release. Please contact your account manager if you want to enable it.

Use the *Generate report* endpoint to initiate the generation of a report specified by the `reportType` parameter.

This action triggers the system to refresh and pull the necessary data from the company's data sources to ensure the report contains the most up-to-date information.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GenerateReportRequest req = new GenerateReportRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportType = ReportType.CategorizedBankStatement,
};

var res = await sdk.ManageReports.GenerateReportAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GenerateReportRequest](../../Models/Requests/GenerateReportRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[GenerateReportResponse](../../Models/Requests/GenerateReportResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503   | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## ListReports

> **Available as beta release**
>
> This endpoint is part of a beta release. Please contact your account manager if you want to enable it.

Use the *List reports* endpoint to return details about all reports generated for a company. The query parameter can be used to filter the results.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListReportsRequest req = new ListReportsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.ManageReports.ListReportsAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListReportsRequest](../../Models/Requests/ListReportsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[ListReportsResponse](../../Models/Requests/ListReportsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503   | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |