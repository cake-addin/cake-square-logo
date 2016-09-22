// #addin "nuget:?package=Cake.SquareLogo"
// #r "../Cake.SquareLogo/bin/Debug/Cake.SquareLogo.dll"
#r "../Cake.SquareLogo/bin/Debug/Cake.SquareLogo.dll"
//#r "../Cake.SquareLogo.CSharp/bin/Debug/FSharp.Core.dll"
//#r "../Cake.SquareLogo.CSharp/bin/Debug/FSharp.Core.Fluent-4.0.dll"

using Cake.SquareLogo.LogoAlias;
// using FSharp.Core.Fluent;
// using Microsoft.FSharp.Collections;

/*
Task("List-Max").Does(() => {
    var list = new FSharpList<string>("Hello", FSharpList<string>.Empty);
    Console.WriteLine(list.max());
});
*/

Task("NoSquare").Does(() => {
    var settings = new LogoSettings {
        FontFamily = "Optima",
        FontSize = 20,
        Padding = 20,
        Foreground = "White",
        Background = "SlateBlue",
        NoSquare = true
    };
    CreateLogo("Hello, world", "Colorful.png", settings);
});

Task("Create-Logo").Does(() => {
    CreateLogo("Logo", "Logo.png");
});

Task("Create-Colorful-Logo").Does(() => {
    var settings = new LogoSettings {
        FontFamily = "Optima",
        FontSize = 150,
        Padding = 150,
        Foreground = "White",
        Background = "SlateBlue",
        //Background = "SeaGreen"
    };
    CreateLogo("w", "Colorful.png", settings);
});

var target = Argument("target", "default");
RunTarget(target);