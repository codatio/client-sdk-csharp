# ValidationItem


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `RuleId`                                                      | *string*                                                      | :heavy_minus_sign:                                            | The unique identifier of the rule that wasn't met.            |
| `ItemId`                                                      | *string*                                                      | :heavy_minus_sign:                                            | The unique identifier of the item that was validated.         |
| `Message`                                                     | *string*                                                      | :heavy_minus_sign:                                            | The message that describes the validation warning or error.   |
| `ValidatorName`                                               | *string*                                                      | :heavy_minus_sign:                                            | The name of the validator that was used to validate the item. |