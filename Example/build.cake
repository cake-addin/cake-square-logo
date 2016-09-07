// #addin "nuget:?package=Cake.SquareLogo"
#r "../Cake.SquareLogo/bin/Debug/Cake.SquareLogo.dll"

using Cake.SquareLogo.LogoAlias;

Task("Create-Logo").Does(() => {
    CreateLogo("Hello", "Hello.png");
});

var target = Argument("target", "default");
RunTarget(target);