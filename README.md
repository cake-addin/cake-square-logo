## Cake.SquareLogo

[![Build Status](https://dev.azure.com/wk-j/square-logo/_apis/build/status/wk-j.square-logo?branchName=master)](https://dev.azure.com/wk-j/square-logo/_build/latest?definitionId=26&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Cake.SquareLogo.svg)](https://www.nuget.org/packages/Cake.SquareLogo)
[![NuGet](https://img.shields.io/nuget/v/wk.SquareLogo.svg)](https://www.nuget.org/packages/wk.SquareLogo)

Create square text logo with Cake

## Installation

`#addin "nuget:?package=Cake.SquareLogo"`

## Example

```csharp
Task("Create-Logo").Does(() => {
    CreateLogo("Hello", "Hello.png");
});

Task("Create-Colorful-Logo").Does(() => {
    var settings = new LogoSettings {
        FontFamily = "Papyrus",
        FontSize = 50,
        Padding = 30,
        Foreground = "White",
        Background = "Green"
    };
    CreateLogo("Hey!", "Colorful.png", settings);
});
```