#addin "nuget:?package=Cake.Watch"
#tool "nuget:?package=Mono.TextTransform"

var solution = "Cake.SquareLogo.sln";
var testDll = "Cake.SquareLogo.Tests/bin/Debug/Cake.SquareLogo.Tests.dll";
var debugDll = "Cake.SquareLogo/bin/Debug/Cake.SquareLogo.dll";
var releaseDll = "Cake.SquareLogo/bin/Release/Cake.SquareLogo.dll";
var npi = EnvironmentVariable("npi");

var id = "Cake.SquareLogo";
var title = "Cake.SquareLogo";
var description = "Create square logo for Github organization";
var projectUrl = "https://github.com/wk-j/cake-square-logo";
var releaseNotes = new[] { "New version" };
var tags = new [] { "Cake", "Logo" };

var files = new [] {
    releaseDll,
    releaseDll.Replace("Cake.SquareLogo.dll", "FSharp.Core.dll")
};

Task("Transform").Does(() => {
    TransformTemplate("Template/README.tt", new TextTransformSettings {
            OutputFile = "Template/README.md"
    });
});

#load "./Config/version.cake"
#load "./Config/compile.cake"
#load "./Config/test.cake"
#load "./Config/nuget.cake"

var target = Argument("target", "default");
RunTarget(target);

