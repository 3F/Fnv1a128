*FNV-1a* high-speed 「 128-bit 」 implementations;

```r
Copyright (c) 2021  Denis Kuzmin <x-3F@outlook.com> github/3F
```

[ [ ☕ ] ](https://3F.github.io/Donation/) [![License](https://img.shields.io/badge/License-MIT-74A5C2.svg)](https://github.com/3F/Fnv1a128/blob/master/License.txt)

✔ Free and Open. MIT License. *Fork! Star! Contribute! Share! Enjoy!*


## Where is this used?

* [Huid](https://github.com/3F/Huid) - A high-speed *FNV-1a-128* hash-based *UUID* implementation.
    * https://twitter.com/github3F/status/1419045735807467520


## .NET implementation

[![Build status](https://ci.appveyor.com/api/projects/status/b4xe42qq5vm0ga47/branch/master?svg=true)](https://ci.appveyor.com/project/3Fs/fnv1a128/branch/master)
[![NuGet package](https://img.shields.io/nuget/v/Fnv1a128.svg)](https://www.nuget.org/packages/Fnv1a128/) 
[![Tests](https://img.shields.io/appveyor/tests/3Fs/fnv1a128/master.svg)](https://ci.appveyor.com/project/3Fs/fnv1a128/build/tests)

[![Build history](https://buildstats.info/appveyor/chart/3Fs/fnv1a128?buildCount=15&includeBuildsFromPullRequest=true&showStats=true)](https://ci.appveyor.com/project/3Fs/fnv1a128/history)

```csharp
ulong high = Fnv1a.GetHash128LX4Cnh
(
    " 🚴  キノの旅 ",
    out ulong low
);
//          high            low
//     ________________|_______________
// = 0x1fbfef4e7acd3a3325ce8d3a718c1484
```

## ⏱

### FNV-1a-128 using [LX4Cnh](https://github.com/3F/LX4Cnh)

For example, 120 Unicode (UTF-16) characters:

`*LodgeX4CorrNoHigh* (LX4Cnh) algorithm of the high-speed multiplications of **128-bit** numbers (full range, 128 × 128).`

[![](/img/benchmark.120Utf16.table.png)](https://twitter.com/github3F/status/1416518052770992132)

> 128-bit hash value = 0x8e719ac9080952dec9c90a46279bfcc9

[![](/img/benchmark.120Utf16.png)](https://twitter.com/github3F/status/1416518052770992132)

