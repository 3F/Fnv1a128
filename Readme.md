Non-cryptographic hash function. *FNV-1a*. High-speed 「 128-bit 」 implementations;

```r
Copyright (c) 2021  Denis Kuzmin <x-3F@outlook.com> github/3F
```

[ [ <sub>@</sub> ☕ ] ](https://3F.github.io/Donation/) &nbsp;&nbsp; [![License](https://img.shields.io/badge/License-MIT-74A5C2.svg)](https://github.com/3F/Fnv1a128/blob/master/License.txt)


## Where is this used?

* [Huid](https://github.com/3F/Huid) - A high-speed *FNV-1a-128* hash-based *UUID* implementation.
    * https://twitter.com/github3F/status/1419045735807467520


## .NET implementations

✔ Free and Open. MIT License. *Fork! Star! Contribute! Share! Enjoy!*

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

*(1 ns == 0.000000001 sec)*

# Sample. Hash Values

[🕹](src/tests/csharp/UnitTest/HashValues.cs)

| Input string (without quotes)     |  Fnv-1a 128-bit hash value
|-----------------------------------|------------------------------------
| "Hello World!"                    |  d2d42892ede872031d2593366229c2d2
| "Hello world!"                    |  3c94fff9ede872031d95566a45770eb2
| "Hello world"                     |  3e2069a3a2839515f3e747cab303a0d7
| "Hello world "                    |  3c94fff9eee872031d95566a45770fed
| "Fnv1a128"                        |  c13dd8c55a659aa11f912cfd85b8ed7c
| "github/3F"                       |  506f2e1fb3060b4c8d3110e8b4e77e16
| "LX4Cnh"                          |  27348aa3e13c64bf6e7a25d900f385aa
| ""                                |  6c62272e07bb014262b821756295c58d
| " "                               |  d228cb69301a8caf78912b704e4a3bdf
| "Password123"                     |  8d9e9ae9fd9b0356dfe55ca4bb8cb938
| "7"                               |  d228cb693d1a8caf78912b704e4a4bde
| "'"                               |  d228cb692d1a8caf78912b704e4a382e
| "1234"                            |  680bc8ef6e757277b806e9090df65bc5
| "123456"                          |  48295155463c64bf6e69f684c538dd82
| "root"                            |  69fe44a65b757277b806e9a25079adf5
| "Root"                            |  690eaab55b757277b806e9587de03515
| "https://github.com/3F/Fnv1a128"  | 43d00056982fd53c44f663dd27c6742a
| "✔"                              |  d228cb861c1a8caf78912b704e6dd243