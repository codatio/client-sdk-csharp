# categories

## Overview

Categorisation

### Available Operations

* [~~GetAccountCategory~~](#getaccountcategory) - Get suggested and/or confirmed category for a specific account :warning: **Deprecated**
* [~~ListAccountsCategories~~](#listaccountscategories) - List suggested and confirmed account categories :warning: **Deprecated**
* [~~ListAvailableAccountCategories~~](#listavailableaccountcategories) - List account categories :warning: **Deprecated**
* [~~UpdateAccountCategory~~](#updateaccountcategory) - Update account categories :warning: **Deprecated**
* [~~UpdateAccountsCategories~~](#updateaccountscategories) - Confirm categories for accounts :warning: **Deprecated**

## ~~GetAccountCategory~~

Get category for specific nominal account.

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Categories;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Categories.GetAccountCategory(request);
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetAccountCategoryRequest](../../Models/Categories/GetAccountCategoryRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetAccountCategoryResponse](../../Models/Categories/GetAccountCategoryResponse.md)**


## ~~ListAccountsCategories~~

Lists suggested and confirmed chart of account categories for the given company and data connection.

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Categories;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Categories.ListAccountsCategories(request);
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListAccountsCategoriesRequest](../../Models/Categories/ListAccountsCategoriesRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListAccountsCategoriesResponse](../../Models/Categories/ListAccountsCategoriesResponse.md)**


## ~~ListAvailableAccountCategories~~

Lists available account categories Codat's categorisation engine can provide. 

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Categories;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Categories.ListAvailableAccountCategories();
```


### Response

**[ListAvailableAccountCategoriesResponse](../../Models/Categories/ListAvailableAccountCategoriesResponse.md)**


## ~~UpdateAccountCategory~~

Update category for a specific nominal account

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Categories;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Categories.UpdateAccountCategory(request);
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateAccountCategoryRequest](../../Models/Categories/UpdateAccountCategoryRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[UpdateAccountCategoryResponse](../../Models/Categories/UpdateAccountCategoryResponse.md)**


## ~~UpdateAccountsCategories~~

Comfirms the categories for all or a batch of accounts for a specific connection.

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Categories;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Categories.UpdateAccountsCategories(request);
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [UpdateAccountsCategoriesRequest](../../Models/Categories/UpdateAccountsCategoriesRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[UpdateAccountsCategoriesResponse](../../Models/Categories/UpdateAccountsCategoriesResponse.md)**

