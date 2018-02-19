## Cake.SquareLogo

Create square text-logo for Github organization.

## Install

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