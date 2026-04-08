# DataConnectionStatus

The current authorization status of the data connection.

## Example Usage

```csharp
using Codat.BankFeeds.Models.Shared;

var value = DataConnectionStatus.PendingAuth;
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `PendingAuth`  | PendingAuth    |
| `Linked`       | Linked         |
| `Unlinked`     | Unlinked       |
| `Deauthorized` | Deauthorized   |