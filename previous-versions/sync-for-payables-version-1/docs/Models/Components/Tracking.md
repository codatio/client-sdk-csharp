# Tracking

Categories, and a project and customer, against which the item is tracked.


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `CategoryRefs`                                                                      | List<[TrackingCategoryRef](../../Models/Components/TrackingCategoryRef.md)>         | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `CustomerRef`                                                                       | [CustomerRef](../../Models/Components/CustomerRef.md)                               | :heavy_minus_sign:                                                                  | N/A                                                                                 |
| `ProjectRef`                                                                        | [AccountingProjectReference](../../Models/Components/AccountingProjectReference.md) | :heavy_minus_sign:                                                                  | N/A                                                                                 |
| `IsBilledTo`                                                                        | [BilledToType](../../Models/Components/BilledToType.md)                             | :heavy_check_mark:                                                                  | Defines if the invoice or credit note is billed/rebilled to a project or customer.  |
| `IsRebilledTo`                                                                      | [BilledToType](../../Models/Components/BilledToType.md)                             | :heavy_check_mark:                                                                  | Defines if the invoice or credit note is billed/rebilled to a project or customer.  |