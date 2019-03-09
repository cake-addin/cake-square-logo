#! "netcoreapp2.1"
#r "nuget:wk.SquareLogo"

// brew install mono-libgdiplus
// Unable to revert mtime: /Library/Fonts

using SquareLogo;

var logo = new Logo();

var settings = new LogoSettings {
    FontFamily = "Fira Code",
    FontSize = 50,
    NoSquare = true,
    Padding = 30,
    Foreground = "White",
    Background = "Green"
};

logo.CreateLogo("Hello", "example/Hello.png");

logo.CreateLogo("> screen", "example/Colorful.png", settings);
