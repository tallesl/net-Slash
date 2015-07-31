# Slash

[![][build-img]][build]
[![][nuget-img]][nuget]

Utility methods for dealing with slashes in strings.

There's two static classes (`Slash` and `Backslash`), with methods for checking leading and trailing slash (`StartsWith` and `EndsWith`), trimming (`Trim`, `TrimStart` and `TrimEnd`), joining (`Join` and `JoinTrimming`) and splitting (`Split`).

[build]:     https://ci.appveyor.com/project/TallesL/Slash
[build-img]: https://ci.appveyor.com/api/projects/status/github/tallesl/Slash

[nuget]:     http://badge.fury.io/nu/Slash
[nuget-img]: https://badge.fury.io/nu/Slash.png

```cs
using Slashes;

Slash.StartsWith("/Yes, it does."); // True
Backslash.EndsWith("Yes, it does.\\"); // True

Slash.Trim("/Where're my slashes?/"); // "Where're my slashes?"

Slash.Join("One", "Two", "Three"); // "One/Two/Three"

Slash.Split("One/Two/Three"); // string[] { "One", "Two", "Three" }
```
