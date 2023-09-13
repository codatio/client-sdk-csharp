# companyInfo

## Overview

View company information fetched from the source platform.

### Available Operations

* [FromAccountingPlatform](#fromaccountingplatform) - Get company info
* [FromCommercePlatform](#fromcommerceplatform) - Get company info

## FromAccountingPlatform

Gets the latest basic info for a company.

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

var res = await sdk.CompanyInfo.FromAccountingPlatformAsync(new GetAccountingCompanyInfoRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetAccountingCompanyInfoRequest](../../models/operations/GetAccountingCompanyInfoRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[GetAccountingCompanyInfoResponse](../../models/operations/GetAccountingCompanyInfoResponse.md)**


## FromCommercePlatform

Retrieve information about the company, as seen in the commerce platform.

This may include information like addresses, tax registration details and social media or website information.

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

var res = await sdk.CompanyInfo.FromCommercePlatformAsync(new GetCommerceCompanyInfoRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetCommerceCompanyInfoRequest](../../models/operations/GetCommerceCompanyInfoRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[GetCommerceCompanyInfoResponse](../../models/operations/GetCommerceCompanyInfoResponse.md)**

