# AccountsPayableTracking

Categories, and a project and customer, against which the item is tracked.


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `categoryRefs`                                                          | List<[TrackingCategoryRef](../../models/shared/TrackingCategoryRef.md)> | :heavy_check_mark:                                                      | N/A                                                                     |
| `customerRef`                                                           | [AccountingCustomerRef](../../models/shared/AccountingCustomerRef.md)   | :heavy_minus_sign:                                                      | N/A                                                                     |
| `isBilledTo`                                                            | [BilledToType](../../models/shared/BilledToType.md)                     | :heavy_check_mark:                                                      | N/A                                                                     |
| `isRebilledTo`                                                          | [BilledToType](../../models/shared/BilledToType.md)                     | :heavy_check_mark:                                                      | N/A                                                                     |
| `projectRef`                                                            | [ProjectRef](../../models/shared/ProjectRef.md)                         | :heavy_minus_sign:                                                      | N/A                                                                     |