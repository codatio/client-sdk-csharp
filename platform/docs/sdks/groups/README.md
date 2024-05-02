# Groups
(*Groups*)

## Overview

Define and manage sets of companies based on a chosen characteristic.

### Available Operations

* [AddCompany](#addcompany) - Add company
* [Create](#create) - Create group
* [List](#list) - List groups
* [RemoveCompany](#removecompany) - Remove company

## AddCompany

﻿Use the *Add company* endpoint to assign a company to a group. A company can belong to multiple groups, but can only be added to one group at a time.

[Groups](https://docs.codat.io/platform-api#/schemas/Group) define a set of companies that are organized based on a chosen characteristic and can be managed in the same way.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

AddCompanyToGroupRequest req = new AddCompanyToGroupRequest() {
    CompanyGroupAssignment = new CompanyGroupAssignment() {
        GroupId = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Groups.AddCompanyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [AddCompanyToGroupRequest](../../Models/Operations/AddCompanyToGroupRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[AddCompanyToGroupResponse](../../Models/Operations/AddCompanyToGroupResponse.md)**
### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |

## Create

﻿Use the *Create group* endpoint to generate a new group that you can assign your companies to.

[Groups](https://docs.codat.io/platform-api#/schemas/Group) define a set of companies that are organized based on a chosen characteristic and can be managed in the same way.

### Tips and traps

* The maximum length for the group name is 50 characters.
* It's possible to create up to 20 groups per client.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GroupPrototype req = new GroupPrototype() {
    Name = "Invoice finance team",
};

var res = await sdk.Groups.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `request`                                               | [GroupPrototype](../../Models/Shared/GroupPrototype.md) | :heavy_check_mark:                                      | The request object to use for the request.              |


### Response

**[CreateGroupResponse](../../Models/Operations/CreateGroupResponse.md)**
### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,409,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |

## List

Use the *List group* endpoint to return a list of all groups that currently exist for your client.

[Groups](https://docs.codat.io/platform-api#/schemas/Group) define a set of companies that are organized based on a chosen characteristic and can be managed in the same way.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

var res = await sdk.Groups.ListAsync();

// handle response
```


### Response

**[ListGroupsResponse](../../Models/Operations/ListGroupsResponse.md)**
### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,429,500,503                   | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |

## RemoveCompany

﻿Use the *Remove company* endpoint to remove a company from a group.

[Groups](https://docs.codat.io/platform-api#/schemas/Group) define a set of companies that are organized based on a chosen characteristic and can be managed in the same way.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

RemoveCompanyFromGroupRequest req = new RemoveCompanyFromGroupRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    GroupId = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
};

var res = await sdk.Groups.RemoveCompanyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [RemoveCompanyFromGroupRequest](../../Models/Operations/RemoveCompanyFromGroupRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[RemoveCompanyFromGroupResponse](../../Models/Operations/RemoveCompanyFromGroupResponse.md)**
### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |
