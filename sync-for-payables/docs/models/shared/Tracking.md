# Tracking

Categories, and a project and customer, against which the item is tracked.


## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `CategoryRefs`                                                                     | List<[TrackingCategoryRef](../../models/shared/TrackingCategoryRef.md)>            | :heavy_check_mark:                                                                 | N/A                                                                                |
| `CustomerRef`                                                                      | [TrackingCustomerRef](../../models/shared/TrackingCustomerRef.md)                  | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `IsBilledTo`                                                                       | [BilledToType](../../models/shared/BilledToType.md)                                | :heavy_check_mark:                                                                 | Defines if the invoice or credit note is billed/rebilled to a project or customer. |
| `IsRebilledTo`                                                                     | [BilledToType](../../models/shared/BilledToType.md)                                | :heavy_check_mark:                                                                 | Defines if the invoice or credit note is billed/rebilled to a project or customer. |
| `ProjectRef`                                                                       | [TrackingProjectReference](../../models/shared/TrackingProjectReference.md)        | :heavy_minus_sign:                                                                 | N/A                                                                                |