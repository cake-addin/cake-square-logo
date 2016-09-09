// #addin "nuget:?package=Cake.SquareLogo"
#r "../Cake.SquareLogo/bin/Debug/Cake.SquareLogo.dll"
#r "../Cake.SquareLogo.CSharp/bin/Debug/FSharp.Core.dll"
#r "../Cake.SquareLogo.CSharp/bin/Debug/FSharp.Core.Fluent-4.0.dll"

using Cake.SquareLogo.LogoAlias;
using FSharp.Core.Fluent;
using Microsoft.FSharp.Collections;

Task("List-Max").Does(() => {
    var list = new FSharpList<string>("Hello", FSharpList<string>.Empty);
    Console.WriteLine(list.max());
});

Task("Create-Logo").Does(() => {
    CreateLogo("Hello", "Hello.png");
});

var target = Argument("target", "default");
RunTarget(target);