# OwlDomain.Polyease

<!-- Do not put the link/image nested tags on new lines as that will count the links as having whitespace which changes the rendering -->

<p align="center"> <!-- Project -->
  <a title="A link to the latest version of the main NuGet package for the project." href="https://www.nuget.org/packages/OwlDomain.Polyease"><img alt="A status badge of the main Nuget package for the project." src="https://img.shields.io/nuget/v/OwlDomain.Polyease?logo=nuget"></a>
  <a title="A link to the Github action workflow for building the project." href="https://github.com/Owl-Domain/Polyease/actions/workflows/build.yml"><img alt="A status badge of the Github action workflow for building the project." src="https://github.com/Owl-Domain/Polyease/actions/workflows/build.yml/badge.svg"></a>
  <a title="A link to the Github action workflow for testing the project." href="https://github.com/Owl-Domain/Polyease/actions/workflows/test.yml"><img alt="A status badge of the Github action workflow for testing the project." src="https://github.com/Owl-Domain/Polyease/actions/workflows/test.yml/badge.svg"></a>
  <a title="A link to the Github action workflow for linting the project." href="https://github.com/Owl-Domain/Polyease/actions/workflows/lint.yml"><img alt="A status badge of the Github action workflow for linting the project." src="https://github.com/Owl-Domain/Polyease/actions/workflows/lint.yml/badge.svg"></a>
  <a title="A link to the Github action workflow for publishing the project." href="https://github.com/Owl-Domain/Polyease/actions/workflows/publish.yml"><img alt="A status badge of the Github action workflow for publishing the project." src="https://github.com/Owl-Domain/Polyease/actions/workflows/publish.yml/badge.svg"></a>
</p>

<p align="center"> <!-- Organisation -->
  <a title="A link to the OwlDomain Discord server." href="https://discord.gg/JtXMeqVGQc"><img alt="Status badge for the OwlDomain discord server." src="https://img.shields.io/discord/1411024983550853162?style=social&logo=discord&label=discord&link=https%3A%2F%2Fdiscord.gg%2FJtXMeqVGQc"></a>
</p>

---

A polyfill-like package that is focused on making it easier to work around missing features,
rather than provide hacky attempts at implementing them. The main purpose of this is to
make it easier to write multi-targeting libraries.

An example of the spirit of this library is the
[CallerArgumentExpressionAttribute](https://learn.microsoft.com/dotnet/api/system.runtime.compilerservices.callerargumentexpressionattribute),
under normal usage, the compiler provides the expression that was passed in for a different parameter as a string,
some polyfill libraries try to imitate that behaviour, however this library will only provide a replica of
the attribute class in order to make multi-targeting easier.


## Installation

To use this package simply reference it from your .NET project, which will download the specified
version from the [nuget.org](https://www.nuget.org/packages/OwlDomain.Polyease) source.

In a C# project (a .csproj file) that would look like this:

```csproj
<ItemGroup>
  <PackageReference Include="OwlDomain.Polyease" Version="1.3.7" />
</ItemGroup>
```

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
  <PackageReference Include="OwlDomain.Polyease" Version="1.3.7" />
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


## Currently poly-eased

- [UnreachableException](https://learn.microsoft.com/dotnet/api/system.diagnostics.unreachableexception) -
  officially available in [.NET 7.0/later](https://apisof.net/catalog/614f9e38-2ac6-c5f5-386e-b2174c657505).
- [CallerArgumentExpressionAttribute](https://learn.microsoft.com/dotnet/api/system.runtime.compilerservices.callerargumentexpressionattribute) -
  officially available in [.NET Core 3.0/later and .NET 5.0/later](https://apisof.net/catalog/9ca9576d-3b89-a8a5-b1d0-95c096bb5378).
- [StringSyntaxAttribute](https://learn.microsoft.com/dotnet/api/system.diagnostics.codeanalysis.stringsyntaxattribute) -
  officially available in [.NET 7.0/later](https://apisof.net/catalog/c0079be5-561c-a967-1ae8-385348a32fb9).
- [MemberNotNullAttribute](https://learn.microsoft.com/dotnet/api/system.diagnostics.codeanalysis.membernotnullattribute) -
  officially available in [.NET 5.0/later](https://apisof.net/catalog/200dc3dadc94a608b8305ad2f5498281).
- [MemberNotNullWhenAttribute](https://learn.microsoft.com/dotnet/api/system.diagnostics.codeanalysis.membernotnullwhenattribute) -
  officially available in [.NET 5.0/later](https://apisof.net/catalog/8b00bdca113a146a7a5a79f2ef1c7fc9).
- [StackTraceHiddenAttribute](https://learn.microsoft.com/dotnet/api/system.diagnostics.stacktracehiddenattribute) -
  officially available in [.NET 6.0/later](https://apisof.net/catalog/5cc02aab35e14fcf5d358e958a777443).


## Contributions

Code contributions will not be accepted, however feel free to provide feedback / suggestions
by creating a [new issue](https://github.com/Owl-Domain/Polyease/issues/new), or look at
the [existing issues](https://github.com/Owl-Domain/Polyease/issues?q=) to see if your
concern / suggestion has already been raised.


## License

This project (the source, and the release files, e.t.c) is released under the [OwlDomain License](/license.md).

Parts of this project are copied / derived under the MIT license from the *.NET Foundation and
Contributors*, you can read their full license [here](/license-dotnet.md).
