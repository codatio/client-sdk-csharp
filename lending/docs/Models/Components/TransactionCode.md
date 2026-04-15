# TransactionCode

Code to identify the underlying transaction.

## Example Usage

```csharp
using Codat.Lending.Models.Components;

var value = TransactionCode.Unknown;
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Unknown`       | Unknown         |
| `Fee`           | Fee             |
| `Payment`       | Payment         |
| `Cash`          | Cash            |
| `Transfer`      | Transfer        |
| `Interest`      | Interest        |
| `Cashback`      | Cashback        |
| `Cheque`        | Cheque          |
| `DirectDebit`   | DirectDebit     |
| `Purchase`      | Purchase        |
| `StandingOrder` | StandingOrder   |
| `Adjustment`    | Adjustment      |
| `Credit`        | Credit          |
| `Other`         | Other           |
| `NotSupported`  | NotSupported    |