#tool "nuget:?package=Fixie"
#addin "nuget:?package=Cake.Watch"
#tool "nuget:?package=NUnit.ConsoleRunner"
#tool "nuget:?package=Mono.TextTransform"

var solution = "Cake.SquareLogo.sln";
var testDll = "Cake.SquareLogo.Tests/bin/Debug/Cake.SquareLogo.Tests.dll";

Task("Transform").Does(() => {
    TransformTemplate("Template/README.tt", new TextTransformSettings {
            OutputFile = "Template/README.md"
    });
});

Task("Test")
    .Does(() => {
    		CleanDirectory("Screen");
            DotNetBuild(solution);
            NUnit3(testDll);
    });

Task("Watch")
    .Does(() => {
        var settings = new WatchSettings {
            Recursive = true,
            Path = "./",
            Pattern = "*.fs"
        };
        Watch(settings, (changed) => {
            Diff(1000, () => {
                RunTarget("test");
            });
        });
    });

var target = Argument("target", "default");
RunTarget(target);