# ErrorStatus

The current status of a transient error. Null statuses indicate that the error is not transient.

## Example Usage

```csharp
using Codat.Lending.Models.Components;

var value = ErrorStatus.Active;
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Active`   | Active     |
| `Resolved` | Resolved   |