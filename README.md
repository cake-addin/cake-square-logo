
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
        Foreground = "White",
        Background = "Green"
    };
    CreateLogo("Hey!", "Colorful.png", settings);
});
```

![](Screen/alfresco.png)
![](Screen/angular.png)
![](Screen/asp.png)
![](Screen/cake.png)
![](Screen/csharp.png)
![](Screen/css.png)
![](Screen/elm.png)
![](Screen/fody.png)
![](Screen/fsharp.png)
![](Screen/jannine.png)
![](Screen/javascript.png)
![](Screen/kotlin.png)
![](Screen/lisp.png)
![](Screen/msbuild.png)
![](Screen/react.png)
![](Screen/roslyn.png)
![](Screen/scala.png)
![](Screen/typescript.png)
![](Screen/uncategorize.png)
![](Screen/vertx.png)
![](Screen/visual-studio.png)
![](Screen/webpack.png)
![](Screen/xamarin.png)
