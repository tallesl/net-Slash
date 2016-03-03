# Slash

[![][build-img]][build]
[![][nuget-img]][nuget]

Utility methods for dealing with slashes in strings.
I use this instead of dealing with [.NET url combining nonsense].

[build]:                       https://ci.appveyor.com/project/TallesL/net-slash
[build-img]:                   https://ci.appveyor.com/api/projects/status/github/tallesl/net-slash?svg=true
[nuget]:                       https://www.nuget.org/packages/Slash
[nuget-img]:                   https://badge.fury.io/nu/Slash.svg
[.NET url combining nonsense]: http://stackoverflow.com/q/18004446

## Usage

There's two static classes (`Slash` and `Backslash`), with methods for checking leading and trailing slash
(`StartsWith` and `EndsWith`), trimming (`Trim`, `TrimStart` and `TrimEnd`), joining (`Join` and `JoinTrimming`) and
splitting (`Split`).

```cs
using SlashLibrary;

Slash.StartsWith("/Yes, it does.");    // True
Backslash.EndsWith("Yes, it does.\\"); // True
Slash.Trim("/Where're my slashes?/");  // "Where're my slashes?"
Slash.Join("One", "Two", "Three");     // "One/Two/Three"
Slash.Split("One/Two/Three");          // string[] { "One", "Two", "Three" }
```