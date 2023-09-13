# LoanTransactions

OK


## Fields

| Field                                                                                                                      | Type                                                                                                                       | Required                                                                                                                   | Description                                                                                                                |
| -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- |
| `errors`                                                                                                                   | List<*object*>                                                                                                             | :heavy_minus_sign:                                                                                                         | If there are no errors, an empty array is returned.                                                                        |
| `reportInfo`                                                                                                               | [LoanTransactionsReportInfo](../../models/shared/LoanTransactionsReportInfo.md)                                            | :heavy_minus_sign:                                                                                                         | N/A                                                                                                                        |
| `reportItems`                                                                                                              | List<[ReportItems](../../models/shared/ReportItems.md)>                                                                    | :heavy_minus_sign:                                                                                                         | Contains object of reporting properties. The loan ref will reference a different object depending on the integration type. |