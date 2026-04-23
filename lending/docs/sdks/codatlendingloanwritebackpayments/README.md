# LoanWriteback.Payments

## Overview

### Available Operations

* [GetCreateModel](#getcreatemodel) - Get create payment model
* [Create](#create) - Create payment

## GetCreateModel

The *Get create payment model* endpoint returns the expected data for the request payload when creating a [payment](https://docs.codat.io/lending-api#/schemas/Payment) for a given company and integration.

[Payments](https://docs.codat.io/lending-api#/schemas/Payment) represent an allocation of money within any customer accounts receivable account.

**Integration-specific behavior**

See the *response examples* for integration-specific indicative models.

### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```
### Example Usage: MYOB AccountRight and Essentials

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" example="MYOB AccountRight and Essentials" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Sandbox

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" example="Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="get-create-payment-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/payments" example="Zoho Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreatePaymentModelRequest req = new GetCreatePaymentModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Payments.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetCreatePaymentModelRequest](../../Models/Requests/GetCreatePaymentModelRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetCreatePaymentModelResponse](../../Models/Requests/GetCreatePaymentModelResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                  | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Create

The *Create payment* endpoint creates a new [payment](https://docs.codat.io/lending-api#/schemas/Payment) for a given company's connection.

[Payments](https://docs.codat.io/lending-api#/schemas/Payment) represent an allocation of money within any customer accounts receivable account.

**Integration-specific behavior**

Required data may vary by integration. To see what data to post, first call [Get create payment model](https://docs.codat.io/lending-api#/operations/get-create-payments-model).

### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-payment" method="post" path="/companies/{companyId}/connections/{connectionId}/push/payments" example="Malformed query" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreatePaymentRequest req = new CreatePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountingPayment = new AccountingPayment() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        AccountRef = new AccountRef() {},
        PaymentMethodRef = new PaymentMethodRef() {
            Id = "EILBDVJVNUAGVKRQ",
            Name = "AliPay",
        },
        Currency = "GBP",
        Date = "2022-10-23T00:00:00Z",
        Lines = new List<PaymentLine>() {
            new PaymentLine() {
                Amount = 9098.82M,
                AllocatedOnDate = "2022-10-23T00:00:00Z",
            },
        },
    },
};

var res = await sdk.LoanWriteback.Payments.CreateAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="create-payment" method="post" path="/companies/{companyId}/connections/{connectionId}/push/payments" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreatePaymentRequest req = new CreatePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountingPayment = new AccountingPayment() {
        CustomerRef = new AccountingCustomerRef() {
            Id = "80000002-1674552702",
            CompanyName = "string",
        },
        AccountRef = new AccountRef() {
            Id = "8000002E-1675267199",
            Name = "Undeposited Funds",
        },
        PaymentMethodRef = new PaymentMethodRef() {
            Id = "string",
            Name = "string",
        },
        TotalAmount = 28M,
        Currency = "USD",
        CurrencyRate = 1M,
        Date = "2023-02-10T11:47:04.792Z",
        Note = "note 14/02 1147",
        Lines = new List<PaymentLine>() {
            new PaymentLine() {
                Amount = 28M,
                Links = new List<PaymentLineLink>() {
                    new PaymentLineLink() {
                        Type = PaymentLinkType.Invoice,
                        Id = "181-1676374586",
                        Amount = -28M,
                        CurrencyRate = 1M,
                    },
                },
                AllocatedOnDate = "2023-02-11T11:47:04.792Z",
            },
        },
        Reference = "ref 14/02 1147",
    },
};

var res = await sdk.LoanWriteback.Payments.CreateAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="create-payment" method="post" path="/companies/{companyId}/connections/{connectionId}/push/payments" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreatePaymentRequest req = new CreatePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountingPayment = new AccountingPayment() {
        CustomerRef = new AccountingCustomerRef() {
            Id = "CUST1",
        },
        AccountRef = new AccountRef() {
            Id = "1200",
            Name = "Bank Current Account",
        },
        PaymentMethodRef = new PaymentMethodRef() {
            Id = "4405",
        },
        TotalAmount = 4M,
        Currency = "GBP",
        CurrencyRate = 1M,
        Date = "2023-03-17T11:47:04.792Z",
        Note = "note 07/03 14.31",
        Lines = new List<PaymentLine>() {
            new PaymentLine() {
                Amount = 4M,
                Links = new List<PaymentLineLink>() {
                    new PaymentLineLink() {
                        Type = PaymentLinkType.Invoice,
                        Id = "INV-31",
                        Amount = -4M,
                        CurrencyRate = 1M,
                    },
                },
                AllocatedOnDate = "2023-02-11T11:47:04.792Z",
            },
        },
        Reference = "ref",
    },
};

var res = await sdk.LoanWriteback.Payments.CreateAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="create-payment" method="post" path="/companies/{companyId}/connections/{connectionId}/push/payments" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreatePaymentRequest req = new CreatePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountingPayment = new AccountingPayment() {
        CustomerRef = new AccountingCustomerRef() {
            Id = "30444c5bd4964fd787c7f8e2e5301ce1",
            CompanyName = "Stanley test customer",
        },
        AccountRef = new AccountRef() {
            Id = "9a25937b267a11e797950a57719b2edb",
            Name = "Current",
        },
        TotalAmount = 0.17M,
        Currency = "GBP",
        CurrencyRate = 1M,
        Date = "2023-03-20T11:47:04.792Z",
        Note = "Need to send products asap.",
        Lines = new List<PaymentLine>() {
            new PaymentLine() {
                Amount = 0.17M,
                Links = new List<PaymentLineLink>() {
                    new PaymentLineLink() {
                        Type = PaymentLinkType.Invoice,
                        Id = "bb85db9226d7450fb99eb83e7fb37505",
                        Amount = -0.17M,
                        CurrencyRate = 1M,
                    },
                },
                AllocatedOnDate = "2023-02-11T11:47:04.792Z",
            },
        },
        Reference = "normal payment 20/03 17.05",
    },
};

var res = await sdk.LoanWriteback.Payments.CreateAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="create-payment" method="post" path="/companies/{companyId}/connections/{connectionId}/push/payments" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreatePaymentRequest req = new CreatePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountingPayment = new AccountingPayment() {
        CustomerRef = new AccountingCustomerRef() {
            Id = "19",
        },
        AccountRef = new AccountRef() {
            Id = "81",
        },
        TotalAmount = 0M,
        Date = "2022-03-12T00:00:00",
        Lines = new List<PaymentLine>() {
            new PaymentLine() {
                Amount = 0M,
                Links = new List<PaymentLineLink>() {
                    new PaymentLineLink() {
                        Type = PaymentLinkType.Invoice,
                        Id = "246",
                        Amount = -1.1M,
                    },
                    new PaymentLineLink() {
                        Type = PaymentLinkType.CreditNote,
                        Id = "280",
                        Amount = 1.1M,
                    },
                },
            },
        },
    },
};

var res = await sdk.LoanWriteback.Payments.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [CreatePaymentRequest](../../Models/Requests/CreatePaymentRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[CreatePaymentResponse](../../Models/Requests/CreatePaymentResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |