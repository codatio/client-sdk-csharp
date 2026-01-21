# ManageReports

## Overview

Generate and review generated reports for a company.

### Available Operations

* [GenerateReport](#generatereport) - Generate report
* [ListReports](#listreports) - List reports

## GenerateReport

Use the *Generate report* endpoint to initiate the generation of a report specified by the `reportType` parameter.

This action triggers the system to refresh and pull the necessary data from the company's data sources to ensure the report contains the most up-to-date information.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="generate-report" method="post" path="/companies/{companyId}/reports/{reportType}" -->
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
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429        | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## ListReports

Use the *List reports* endpoint to return details (such as generation's current status, date of request, and date of generation) about all reports generated for a company. The query parameter can be used to filter the results.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="list-reports" method="get" path="/companies/{companyId}/reports" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListReportsRequest req = new ListReportsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
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
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |