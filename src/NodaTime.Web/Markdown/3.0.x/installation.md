@Title="Installation"

Our primary distribution channel is [NuGet](https://www.nuget.org/) with
three packages:

- [NodaTime](https://www.nuget.org/packages/NodaTime)
- [NodaTime.Testing](https://www.nuget.org/packages/NodaTime.Testing)
- [NodaTime.Serialization.JsonNet](https://www.nuget.org/packages/NodaTime.Serialization.JsonNet)

See the ["Building and testing"][building] section in the developer guide for
instructions on building Noda Time from source.

[building]: /developer/building

System requirements
-------------------

Noda Time 3.0 (and onwards) supports the Target Framework Moniker of `netstandard2.0`.

This means it should work for any desktop framework application targeting .NET 4.7.2 or later, as well as .NET Core 2.0 and
related frameworks.  It does *not* support Windows 8 store apps, or Windows Phone (Silverlight or not) 8 apps. It *does* support
UWP for (recent versions of) Windows 10. See the [.NET Standard
Versions](https://github.com/dotnet/standard/blob/main/docs/versions.md) documentation for more details.

We have not tested Noda Time 3.0 against Xamarin or Unity; recent versions of Xamarin support .NET Standard so should be fine;
Unity targeting .NET 2.0 won't work, but the 2017-onwards support for Mono 4.8 *may* just work. (Please report any problems you
have and we can try to look into them.)

Package contents and getting started
------------------------------------

Everything you need to *use* Noda Time is contained in the `NodaTime` package. The `NodaTime.Testing` package is designed
for testing code which uses Noda Time. See the [testing guide](testing) for more information. It is expected
that production code will only refer to the `NodaTime.dll` assembly, and that's all that's required at execution time.
This assembly includes the [TZDB database](tzdb) as an embedded resource.

For Json.NET serialization, the NodaTime.Serialization.JsonNet package (containing a single assembly of the same name) is
required, as well as an appropriate version of Json.NET itself. There is a NuGet dependency from NodaTime.Serialization.JsonNet
to the Newtonsoft.Json package, so if you're using NuGet you just need to refer to NodaTime.Serialization.JsonNet and an
appropriate version of Json.NET will be installed automatically. See the [serialization guide](serialization) for more
information on using Noda Time with Json.NET.

Everything within the NodaTime assembly is in the NodaTime namespace or a "child" namespace. After adding a reference to
the main assembly (either directly via the file system or with NuGet) and including an appropriate `using` directive, you should
be able to start using Noda Time immediately, with no further effort.
