# CompanyInformation

Information about the company from the underlying accounting software.


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `CompanyName`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Name of the linked company.                                         |
| `BaseCurrency`                                                      | *string*                                                            | :heavy_minus_sign:                                                  | Currency set in the accounting software of the linked company.      |
| `PlanType`                                                          | *string*                                                            | :heavy_minus_sign:                                                  | Accounting software subscription type such as Trial, Demo, Standard |
| `MulticurrencyEnabled`                                              | *bool*                                                              | :heavy_minus_sign:                                                  | Boolean showing if the organisation has multicurrency enabled       |