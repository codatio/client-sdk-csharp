# ReportLine


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `AccountId`                                                                    | *string*                                                                       | :heavy_minus_sign:                                                             | Identifier for the account, unique for the company in the accounting platform. |
| `Items`                                                                        | List<[ReportLine](../../Models/Shared/ReportLine.md)>                          | :heavy_minus_sign:                                                             | An array of ReportLine items.                                                  |
| `Name`                                                                         | *string*                                                                       | :heavy_minus_sign:                                                             | Name of the report line item.                                                  |
| `Value`                                                                        | *decimal*                                                                      | :heavy_check_mark:                                                             | Numerical value of the line item.                                              |