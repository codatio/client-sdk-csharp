# ConfigurationSchedule


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `FrequencyOptions`                                        | List<*string*>                                            | :heavy_minus_sign:                                        | The available sync frequencies.                           |
| `SelectedFrequency`                                       | *string*                                                  | :heavy_minus_sign:                                        | The sync frequency.                                       |
| `StartDate`                                               | *string*                                                  | :heavy_minus_sign:                                        | The datetime in UTC you want to start syncing from.       |
| `SyncHourUtc`                                             | *long*                                                    | :heavy_minus_sign:                                        | The hour in which the sync is initiated.                  |
| `TimeZoneIanaId`                                          | *string*                                                  | :heavy_minus_sign:                                        | The [IANA](https://www.iana.org/time-zones) time zone ID. |