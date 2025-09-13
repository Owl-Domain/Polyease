Polyease
===

A polyfill-like package that is focused on making it easier to work around missing features,
rather than provide hacky attempts at implementing them. The main purpose of this is to
make it easier to write multi-targeting libraries.

An example of the spirit of this library is the
[CallerArgumentExpressionAttribute](https://learn.microsoft.com/dotnet/api/system.runtime.compilerservices.callerargumentexpressionattribute),
under normal usage, the compiler provides the expression that was passed in for a different parameter as a string,
some polyfill libraries try to imitate that behaviour, however this library will only provide a replica of
the attribute class in order to make multi-targeting easier.


## Installation

For the best results, use [multi-targeting](https://learn.microsoft.com/dotnet/standard/frameworks)
in your project, and then use
[conditional expressions](https://learn.microsoft.com/visualstudio/msbuild/msbuild-conditions)
to ensure that the package is only referenced when necessary.

In C#, that would look like this:

```csproj
<PropertyGroup>
  <TargetFrameworks>net7.0;netstandard2.1</TargetFrameworks>
</PropertyGroup>

<ItemGroup Condition="'$(TargetFramework)' == 'netstandard2.1'">
  <PackageReference Include="OwlDomain.Polyease" Version="1.3.6" />
</ItemGroup>
```

The reason for this is that if you wanted to use the `UnreachableException` in your library code,
and you were multi-targeting .NET Standard 2.1 and .NET 7, then when your library was being used under
.NET Standard 2.1  the `OwlDomain.Polyease` package would become a dependency and
would be required by your package, however if your library was being used under .NET 7 then the
`OwlDomain.Polyease` package would not be referenced, and therefore it would never be a dependency.

The conditional expressions are not strictly necessary for the package to work, as the `OwlDomain.Polyease` package
uses conditional compilation to ensure that the poly-eased features are only present when they are missing.
However using the conditional expressions helps to keep your dependencies clean.


## Usage

To use this package in your code, simply reference it, nothing else specific has to be done in order to use it,
as the poly-eased features are placed in the same namespaces as the official versions.


## License

This project (the source, and the release files, e.t.c) is released under the [OwlDomain License](/license.md).

Parts of this project are copied / derived under the MIT license from the *.NET Foundation and
Contributors*, you can read their full license [here](/license-dotnet.md).
