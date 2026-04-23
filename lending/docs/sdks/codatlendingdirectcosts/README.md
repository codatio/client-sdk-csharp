# LoanWriteback.DirectCosts

## Overview

### Available Operations

* [GetCreateModel](#getcreatemodel) - Get create direct cost model
* [Create](#create) - Create direct cost

## GetCreateModel

The *Get create direct cost model* endpoint returns the expected data for the request payload when creating a [direct cost](https://docs.codat.io/lending-api#/schemas/DirectCost) for a given company and integration.

[Direct costs](https://docs.codat.io/lending-api#/schemas/DirectCost) are business expenses that don't impact Accounts Payable.

**Integration-specific behavior**

See the *response examples* for integration-specific indicative models.


### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-create-directCosts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/directCosts" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateDirectCostsModelRequest req = new GetCreateDirectCostsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.DirectCosts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="get-create-directCosts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/directCosts" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateDirectCostsModelRequest req = new GetCreateDirectCostsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.DirectCosts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-create-directCosts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/directCosts" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateDirectCostsModelRequest req = new GetCreateDirectCostsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.DirectCosts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-create-directCosts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/directCosts" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateDirectCostsModelRequest req = new GetCreateDirectCostsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.DirectCosts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-create-directCosts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/directCosts" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateDirectCostsModelRequest req = new GetCreateDirectCostsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.DirectCosts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-create-directCosts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/directCosts" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateDirectCostsModelRequest req = new GetCreateDirectCostsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.DirectCosts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-create-directCosts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/directCosts" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateDirectCostsModelRequest req = new GetCreateDirectCostsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.DirectCosts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-create-directCosts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/directCosts" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateDirectCostsModelRequest req = new GetCreateDirectCostsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.DirectCosts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Sandbox

<!-- UsageSnippet language="csharp" operationID="get-create-directCosts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/directCosts" example="Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateDirectCostsModelRequest req = new GetCreateDirectCostsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.DirectCosts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-create-directCosts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/directCosts" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateDirectCostsModelRequest req = new GetCreateDirectCostsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.DirectCosts.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="get-create-directCosts-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/directCosts" example="Zoho Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateDirectCostsModelRequest req = new GetCreateDirectCostsModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.DirectCosts.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetCreateDirectCostsModelRequest](../../Models/Requests/GetCreateDirectCostsModelRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[GetCreateDirectCostsModelResponse](../../Models/Requests/GetCreateDirectCostsModelResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                  | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Create

The *Create direct cost* endpoint creates a new [direct cost](https://docs.codat.io/lending-api#/schemas/DirectCost) for a given company's connection.

[Direct costs](https://docs.codat.io/lending-api#/schemas/DirectCost) are business expenses that don't impact Accounts Payable.

**Integration-specific behavior**

Required data may vary by integration. To see what data to post, first call [Get create direct cost model](https://docs.codat.io/lending-api#/operations/get-create-directCosts-model).

### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="create-direct-cost" method="post" path="/companies/{companyId}/connections/{connectionId}/push/directCosts" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateDirectCostRequest req = new CreateDirectCostRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectCostPrototype = new DirectCostPrototype() {
        IssueDate = "2023-02-12",
        Currency = "GBP",
        LineItems = new List<DirectCostLineItem>() {
            new DirectCostLineItem() {
                UnitAmount = 15M,
                Quantity = 1M,
                SubTotal = 15M,
                AccountRef = new AccountRef() {
                    Id = "288",
                },
            },
        },
        PaymentAllocations = new List<AccountingPaymentAllocation>() {
            new AccountingPaymentAllocation() {
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "750-1",
                    },
                },
                Allocation = new Allocation() {},
            },
        },
        SubTotal = 15M,
        TaxAmount = 0M,
        TotalAmount = 15M,
    },
};

var res = await sdk.LoanWriteback.DirectCosts.CreateAsync(req);

// handle response
```
### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-direct-cost" method="post" path="/companies/{companyId}/connections/{connectionId}/push/directCosts" example="Malformed query" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateDirectCostRequest req = new CreateDirectCostRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectCostPrototype = new DirectCostPrototype() {
        IssueDate = "2022-10-23T00:00:00Z",
        Currency = "GBP",
        LineItems = new List<DirectCostLineItem>() {},
        PaymentAllocations = new List<AccountingPaymentAllocation>() {
            new AccountingPaymentAllocation() {
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {},
                    Currency = "GBP",
                    PaidOnDate = "2022-10-23T00:00:00Z",
                },
                Allocation = new Allocation() {
                    Currency = "GBP",
                    AllocatedOnDate = "2022-10-23T00:00:00Z",
                },
            },
        },
        SubTotal = 3566.34M,
        TaxAmount = 7664.68M,
        TotalAmount = 208.93M,
    },
};

var res = await sdk.LoanWriteback.DirectCosts.CreateAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="create-direct-cost" method="post" path="/companies/{companyId}/connections/{connectionId}/push/directCosts" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateDirectCostRequest req = new CreateDirectCostRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectCostPrototype = new DirectCostPrototype() {
        Reference = "test ref",
        Note = "directCost 21/03 09.20",
        ContactRef = new ContactRef() {
            Id = "80000001-1671793885",
            DataType = ContactRefDataType.Suppliers,
        },
        IssueDate = "2023-03-21T10:19:52.223Z",
        Currency = "USD",
        LineItems = new List<DirectCostLineItem>() {
            new DirectCostLineItem() {
                Description = "test description line 1",
                UnitAmount = 7M,
                Quantity = 1M,
                DiscountAmount = 0M,
                DiscountPercentage = 0M,
                SubTotal = 99M,
                TaxAmount = 360M,
                TotalAmount = 70M,
                AccountRef = new AccountRef() {
                    Id = "8000000D-1671793811",
                    Name = "Purchases - Hardware for Resale",
                },
                ItemRef = new PropertieItemRef() {
                    Id = "80000001-1674566705",
                    Name = "item test",
                },
                TrackingCategoryRefs = new List<TrackingCategoryRef>() {
                    new TrackingCategoryRef() {
                        Id = "80000001-1674553252",
                        Name = "Class 1",
                    },
                },
            },
        },
        PaymentAllocations = new List<AccountingPaymentAllocation>() {
            new AccountingPaymentAllocation() {
                Payment = new PaymentAllocationPayment() {
                    Note = "payment allocations note",
                    Reference = "payment allocations reference",
                    AccountRef = new AccountRef() {
                        Id = "80000028-1671794219",
                        Name = "Bank Account 1",
                    },
                    PaidOnDate = "2023-01-28T10:19:52.223Z",
                    TotalAmount = 54M,
                },
                Allocation = new Allocation() {
                    CurrencyRate = 0M,
                    AllocatedOnDate = "2023-01-29T10:19:52.223Z",
                    TotalAmount = 88M,
                },
            },
        },
        SubTotal = 362M,
        TaxAmount = 4M,
        TotalAmount = 366M,
    },
};

var res = await sdk.LoanWriteback.DirectCosts.CreateAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="create-direct-cost" method="post" path="/companies/{companyId}/connections/{connectionId}/push/directCosts" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateDirectCostRequest req = new CreateDirectCostRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectCostPrototype = new DirectCostPrototype() {
        Reference = "test ref",
        Note = "Test 1",
        IssueDate = "2023-03-31T00:00:00",
        Currency = "USD",
        CurrencyRate = 0.5M,
        LineItems = new List<DirectCostLineItem>() {
            new DirectCostLineItem() {
                UnitAmount = 9.99M,
                Quantity = 1M,
                SubTotal = 9.99M,
                TaxAmount = 2M,
                TotalAmount = 11.99M,
                AccountRef = new AccountRef() {
                    Id = "195",
                },
            },
        },
        PaymentAllocations = new List<AccountingPaymentAllocation>() {
            new AccountingPaymentAllocation() {
                Payment = new PaymentAllocationPayment() {
                    Id = "4355",
                    Note = "test note",
                    Reference = "test reference",
                    AccountRef = new AccountRef() {
                        Id = "348",
                        Name = "CMRR Renewal",
                    },
                    Currency = "USD",
                    PaidOnDate = "2023-03-31T00:00:00",
                    TotalAmount = 11.99M,
                },
                Allocation = new Allocation() {
                    Currency = "USD",
                    AllocatedOnDate = "2023-03-31T00:00:00",
                    TotalAmount = 11.99M,
                },
            },
        },
        SubTotal = 9.99M,
        TaxAmount = 2M,
        TotalAmount = 11.99M,
    },
};

var res = await sdk.LoanWriteback.DirectCosts.CreateAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="create-direct-cost" method="post" path="/companies/{companyId}/connections/{connectionId}/push/directCosts" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateDirectCostRequest req = new CreateDirectCostRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectCostPrototype = new DirectCostPrototype() {
        Reference = "Scenario One neg DC",
        ContactRef = new ContactRef() {
            Id = "699f0091-b127-4796-9f15-41a2f42abeb2",
            DataType = ContactRefDataType.Suppliers,
        },
        IssueDate = "2023-02-25",
        Currency = "GBP",
        LineItems = new List<DirectCostLineItem>() {
            new DirectCostLineItem() {
                Description = "negative direct cost",
                UnitAmount = 35M,
                Quantity = -1M,
                SubTotal = -35M,
                TaxAmount = -7M,
                TotalAmount = -42M,
                TaxRateRef = new TaxRateRef() {
                    Id = "INPUT2",
                },
                ItemRef = new PropertieItemRef() {
                    Id = "965cfc0e-4d80-4059-9641-4a392f9ad549",
                },
            },
        },
        PaymentAllocations = new List<AccountingPaymentAllocation>() {
            new AccountingPaymentAllocation() {
                Payment = new PaymentAllocationPayment() {
                    AccountRef = new AccountRef() {
                        Id = "bd9e85e0-0478-433d-ae9f-0b3c4f04bfe4",
                    },
                    Currency = "GBP",
                },
                Allocation = new Allocation() {
                    TotalAmount = -42M,
                },
            },
        },
        SubTotal = -35M,
        TaxAmount = -7M,
        TotalAmount = -42M,
    },
};

var res = await sdk.LoanWriteback.DirectCosts.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [CreateDirectCostRequest](../../Models/Requests/CreateDirectCostRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[CreateDirectCostResponse](../../Models/Requests/CreateDirectCostResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |