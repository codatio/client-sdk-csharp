# AccountsPayableTracking

Categories, and a project and customer, against which the item is tracked.


## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `CategoryRefs`                                                                     | List<[TrackingCategoryRef](../../Models/Components/TrackingCategoryRef.md)>        | :heavy_check_mark:                                                                 | N/A                                                                                |
| `CustomerRef`                                                                      | [AccountingCustomerRef](../../Models/Components/AccountingCustomerRef.md)          | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `ProjectRef`                                                                       | [ProjectRef](../../Models/Components/ProjectRef.md)                                | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `IsBilledTo`                                                                       | [BilledToType](../../Models/Components/BilledToType.md)                            | :heavy_check_mark:                                                                 | Defines if the invoice or credit note is billed/rebilled to a project or customer. |
| `IsRebilledTo`                                                                     | [BilledToType](../../Models/Components/BilledToType.md)                            | :heavy_check_mark:                                                                 | Defines if the invoice or credit note is billed/rebilled to a project or customer. |