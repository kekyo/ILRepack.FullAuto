# ILRepack.FullAuto

![ILRepack.FullAuto](Images/ILRepack.FullAuto.100.png)

[![Project Status: WIP – Initial development is in progress, but there has not yet been a stable, usable release suitable for the public.](https://www.repostatus.org/badges/latest/wip.svg)](https://www.repostatus.org/#wip)
[![NuGet ILRepack.FullAuto](https://img.shields.io/nuget/v/ILRepack.FullAuto.svg?style=flat)](https://www.nuget.org/packages/ILRepack.FullAuto)

----

## What is this?

`ILRepack.FullAuto` is an alternative package for [ILRepack](https://github.com/gluck/il-repack) related.
This allows for fully automatic assembly integration simply by installing [only the package ILRepack.FullAuto](https://www.nuget.org/packages/ILRepack.FullAuto).

Nowadays, alternative packages for ILRepack are quite wildly available.
The significance of adding yet another package to the mix is that:

* Completely automatic. There is no need to manually insert additional properties or scripts.
  Of course, you can manually configure optional parameters for `ILRepack` if you need.
* Windows and Linux are supported as operating environments.
  (Linux environment requires mono installation.)
  * It runs on Linux and contributes to build automation in CI environments, ex: GitHub Actions Linux VM image.
* Independed any MSBuild assemblies.
  Avoid strange assembly loader error related MSBuild versions.
* Use genuine ILRepack official binary comes from NuGet package.

----

## How to use

1. Install [ILRepack.FullAuto NuGet package](https://www.nuget.org/packages/ILRepack.FullAuto).
   * If you are using on Linux environment, you need to install mono runtime.
     (ex: Debian, Ubuntu and related: `sudo apt install mono-devel` and like.) 
2. Done :)

Default behavior is merged assemblies only on `Release` configuration.
If you need to merge assemblies other configuration, use `ILRepackTargetConfigurations` like:

```xml
<PropertyGroup>
  <ILRepackTargetConfigurations>Debug;Release</ILRepackTargetConfigurations>
</PropertyGroup>
```

If you need to more customize, see Options section below.

----

## Options

These options are `PropertyGroup` variables:

|Property|Detail|Default|
|:----|:----|:----|
|`ILRepackBuildEnable`|Enable ILRepack processing.|`True`|
|`ILRepackTargetConfigurations`|Will merge on these configuration. Need to semicolon-separated values.|`Release`|
|`ILRepackParallelProcessing`|Enable parallel processing.|`True`|
|`ILRepackUnionTypes`|Union type declarations.|`True`|
|`ILRepackCopyAttributes`|Copy assembly-wide attributes.|(`True` if `OutputType` property is `Exe` or `WinExe`)|
|`ILRepackPerformInternalize`|Perform internalize between merged assembly declarations.|`True`|
|`ILRepackAllowDuplicateResources`|Allow duplicate any resources.|`True`|
|`ILRepackAllowDuplicateNamespaces`|Semicolon-separated namespace names (`Foo.Internal;Bar.Collection.Generic`)|(Empty)|
|`ILRepackExcludeAssemblies`|Semicolon-separated assembly file names (`Foo.dll;Bar.dll`)|(Empty)|
|`ILRepackPerformVerboseOutput`|Perform verbose log output.|`False`|
|`ILRepackInsertRepackList`|Insert repacking list into resource named `ILRepack.List`.|`False`|
|`ILRepackMergeDebugSymbols`|Merge debug symbols.|(Refer `DebugSymbols` property)|
|`ILRepackMergeXmlDocuments`|Merge xml documents.|(Refer `GenerateDocumentationFile` property)|

----

## License

Copyright (c) Kouji Matsui (@kozy_kekyo, @kekyo@mastodon.cloud)

License under MIT.

----

## History

* 1.0.0
  * Supported additional option properties.
* 0.1.0
  * Initial release
