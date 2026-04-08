# ErrorStatus

The current status of a transient error. Null statuses indicate that the error is not transient.

## Example Usage

```csharp
using Codat.BankFeeds.Models.Shared;

var value = ErrorStatus.Active;
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | Active     |
| `Resolved` | Resolved   |