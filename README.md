# Blazor Dev Server with CSS Live Reloader [![NuGet Package](https://img.shields.io/nuget/v/Toolbelt.Blazor.DevServer.WithCssLiveReloader.svg)](https://www.nuget.org/packages/Toolbelt.Blazor.DevServer.WithCssLiveReloader/)

## Summary

Alternative Blazor Dev Server to be available CSS live reloading.

![fig.1](https://raw.githubusercontent.com/jsakamoto/Toolbelt.Blazor.DevServer.WithCssLiveReloader/master/.assets/fig1.gif)

This is an alternative development server for use when building Blazor WebAssembly standalone (not ASP.NET Core hosted) applications, include CSS live reloader.a

There are already many live reloading solutions.  
However, instead of this middleware works for only CSS files, it reload styles **more smoothly** rather than other solutions. 

## How to use

What you have to do is, just rewrite your project file (.csproj) to replace the Blazor Dev Server package from ASP.NET Core edition to this one.

```xml
<!-- This is your project file (.csproj) -->
<Project Sdk="Microsoft.NET.Sdk.BlazorWebAssembly">
  ...
  <ItemGroup>
    ...
    <!-- Remove this 👇 package reference, and ... -->
    <!--
    <PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly.DevServer" Version="5.0.4" PrivateAssets="all" />
    -->

    <!-- Add this 👇 package reference, instead. -->
    <PackageReference Include="Toolbelt.Blazor.DevServer.WithCssLiveReloader" Version="5.0.4" PrivateAssets="all" />
    ...
```

That's all!

## Supported Blazor Versions

- Blazor WebAssembly v.3.2.1 👉 Use v.3.2.1.200 of this package.
- Blazor WebAssembly v.5.0.0 👉 Use v.5.0.0 of this package.
- Blazor WebAssembly v.5.0.1 👉 Use v.5.0.1 of this package.
- Blazor WebAssembly v.5.0.2 👉 Use v.5.0.2 of this package.
- Blazor WebAssembly v.5.0.3 👉 Use v.5.0.3 of this package.
- Blazor WebAssembly v.5.0.4 👉 Use v.5.0.4 of this package.

## For Blazor WebAssembly ASP.NET Core hosted...

If you building a Blazor WebAssembly app which is ASP.NET Core hosted, please use `Toolbelt.AspNetCore.CssLiveReloader` NuGet package, instead of this.

**See also:** [`Toolbelt.AspNetCore.CssLiveReloader` NuGet package](https://www.nuget.org/packages/Toolbelt.AspNetCore.CssLiveReloader/)

## Release Notes

Release Notes is [here.](https://github.com/jsakamoto/Toolbelt.Blazor.DevServer.WithCssLiveReloader/blob/master/RELEASE-NOTES.txt)

## License

[Apache License Version 2.0](https://github.com/jsakamoto/Toolbelt.Blazor.DevServer.WithCssLiveReloader/blob/master/LICENSE.txt)

