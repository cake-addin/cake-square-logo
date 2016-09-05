#tool "nuget:?package=Fixie"
#addin "nuget:?package=Cake.Watch"
#tool "nuget:?package=NUnit.ConsoleRunner"

var solution = "Cake.SquareLogo.sln";
var testDll = "Cake.SquareLogo.Tests/bin/Debug/Cake.SquareLogo.Tests.dll";

Task("Test")
    .Does(() => {
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
            RunTarget("test");
        });
    });

var target = Argument("target", "default");
RunTarget(target);