# ReportLine


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `AccountId`                                                                    | *string*                                                                       | :heavy_minus_sign:                                                             | Identifier for the account, unique for the company in the accounting software. |
| `Name`                                                                         | *string*                                                                       | :heavy_minus_sign:                                                             | Name of the report line item.                                                  |
| `Value`                                                                        | *decimal*                                                                      | :heavy_check_mark:                                                             | Numerical value of the line item.                                              |
| `Items`                                                                        | List<[ReportLine](../../Models/Components/ReportLine.md)>                      | :heavy_minus_sign:                                                             | An array of ReportLine items.                                                  |