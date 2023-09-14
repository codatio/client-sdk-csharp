# configuration

## Overview

Manage mapping options and sync configuration.

### Available Operations

* [Get](#get) - Get company configuration
* [GetMappingOptions](#getmappingoptions) - Mapping options
* [Set](#set) - Set company configuration

## Get

Gets a companies expense sync configuration

### Example Usage

```csharp
using CodatSyncExpenses;
using CodatSyncExpenses.Models.Shared;
using CodatSyncExpenses.Models.Operations;

var sdk = new CodatSyncExpensesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Configuration.GetAsync(new GetCompanyConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetCompanyConfigurationRequest](../../models/operations/GetCompanyConfigurationRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[GetCompanyConfigurationResponse](../../models/operations/GetCompanyConfigurationResponse.md)**


## GetMappingOptions

Gets the expense mapping options for a companies accounting software

### Example Usage

```csharp
using CodatSyncExpenses;
using CodatSyncExpenses.Models.Shared;
using CodatSyncExpenses.Models.Operations;

var sdk = new CodatSyncExpensesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Configuration.GetMappingOptionsAsync(new GetMappingOptionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetMappingOptionsRequest](../../models/operations/GetMappingOptionsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetMappingOptionsResponse](../../models/operations/GetMappingOptionsResponse.md)**


## Set

Sets a companies expense sync configuration

### Example Usage

```csharp
using CodatSyncExpenses;
using CodatSyncExpenses.Models.Shared;
using CodatSyncExpenses.Models.Operations;

var sdk = new CodatSyncExpensesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Configuration.SetAsync(new SetCompanyConfigurationRequest() {
    CompanyConfiguration = new CompanyConfiguration() {
        BankAccount = new BankAccount() {
            Id = "32",
        },
        Customer = new Customer() {
            Addresses = new List<Items>() {
                new Items() {
                    City = "Fort Donnybury",
                    Country = "Kyrgyz Republic",
                    Line1 = "minus",
                    Line2 = "placeat",
                    PostalCode = "45398-0306",
                    Region = "perferendis",
                    Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Billing,
                },
            },
            ContactName = "repellendus",
            Contacts = new List<Contact>() {
                new Contact() {
                    Address = new Items() {
                        City = "San Antonio",
                        Country = "Burundi",
                        Line1 = "at",
                        Line2 = "at",
                        PostalCode = "47845-7617",
                        Region = "officia",
                        Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Billing,
                    },
                    Email = "Kale_Welch10@gmail.com",
                    ModifiedDate = "2022-10-23T00:00:00.000Z",
                    Name = "Pauline Dibbert",
                    Phone = new List<ContactPhone>() {
                        new ContactPhone() {
                            Number = "(877) 492-8687",
                            Type = CodatSyncExpenses.Models.Shared.PhoneNumberType.Landline,
                        },
                    },
                    Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Active,
                },
            },
            CustomerName = "aspernatur",
            DefaultCurrency = "GBP",
            EmailAddress = "ad",
            Id = "929396fe-a759-46eb-90fa-aa2352c59559",
            Metadata = new Metadata() {
                IsDeleted = false,
            },
            ModifiedDate = "2022-10-23T00:00:00.000Z",
            Phone = "799.262.6196 x524",
            RegistrationNumber = "quam",
            SourceModifiedDate = "2022-10-23T00:00:00.000Z",
            Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Unknown,
            SupplementalData = new SupplementalData() {
                Content = new Dictionary<string, Dictionary<string, object>>() {
                    { "error", new Dictionary<string, object>() {
                        { "quia", "quis" },
                    } },
                },
            },
            TaxNumber = "vitae",
        },
        Supplier = new Supplier() {
            Addresses = new List<SupplierAccountingAddress>() {
                new SupplierAccountingAddress() {
                    City = "O'Konborough",
                    Country = "Burkina Faso",
                    Line1 = "quo",
                    Line2 = "sequi",
                    PostalCode = "36800-6860",
                    Region = "reiciendis",
                    Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Delivery,
                },
            },
            ContactName = "vero",
            DefaultCurrency = "nihil",
            EmailAddress = "praesentium",
            Id = "f097b007-4f15-4471-b5e6-e13b99d488e1",
            Metadata = new Metadata() {
                IsDeleted = false,
            },
            ModifiedDate = "2022-10-23T00:00:00.000Z",
            Phone = "(877) 492-8687",
            RegistrationNumber = "veritatis",
            SourceModifiedDate = "2022-10-23T00:00:00.000Z",
            Status = CodatSyncExpenses.Models.Shared.SupplierStatus.Unknown,
            SupplementalData = new SupplierSupplementalData() {
                Content = new Dictionary<string, Dictionary<string, object>>() {
                    { "enim", new Dictionary<string, object>() {
                        { "consequatur", "est" },
                    } },
                },
            },
            SupplierName = "quibusdam",
            TaxNumber = "explicabo",
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [SetCompanyConfigurationRequest](../../models/operations/SetCompanyConfigurationRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[SetCompanyConfigurationResponse](../../models/operations/SetCompanyConfigurationResponse.md)**

