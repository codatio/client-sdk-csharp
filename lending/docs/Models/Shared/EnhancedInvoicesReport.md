# EnhancedInvoicesReport

The enhanced invoices report takes the key elements of the Invoices report verifying those marked as paid in the accounting platform have actually been paid by matching with the bank statement.


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `ReportInfo`                                                                        | [ReportInfo](../../Models/Shared/ReportInfo.md)                                     | :heavy_minus_sign:                                                                  | Report additional information, which is specific to Lending API reports.            |
| `ReportItems`                                                                       | List<[EnhancedInvoiceReportItem](../../Models/Shared/EnhancedInvoiceReportItem.md)> | :heavy_minus_sign:                                                                  | N/A                                                                                 |