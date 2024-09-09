# Tracking

Categories, and a project and customer, against which the item is tracked.


## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `CategoryRefs`                                                                     | List<[TrackingCategoryRef](../../Models/Shared/TrackingCategoryRef.md)>            | :heavy_check_mark:                                                                 | N/A                                                                                |
| `CustomerRef`                                                                      | [CustomerRef](../../Models/Shared/CustomerRef.md)                                  | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `IsBilledTo`                                                                       | [BilledToType](../../Models/Shared/BilledToType.md)                                | :heavy_check_mark:                                                                 | Defines if the invoice or credit note is billed/rebilled to a project or customer. |
| `IsRebilledTo`                                                                     | [BilledToType](../../Models/Shared/BilledToType.md)                                | :heavy_check_mark:                                                                 | Defines if the invoice or credit note is billed/rebilled to a project or customer. |
| `ProjectRef`                                                                       | [AccountingProjectReference](../../Models/Shared/AccountingProjectReference.md)    | :heavy_minus_sign:                                                                 | N/A                                                                                |