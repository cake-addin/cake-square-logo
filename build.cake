#addin nuget:?package=ProjectParser&version=0.3.0

using ProjectParser;

var name = "Cake.SquareLogo";
var npi = EnvironmentVariable("npi");

var repo = 
        System.Environment.OSVersion.Platform == System.PlatformID.Unix 
        ? "/Users/wk/NuGet"
        // ? @"/Volumes/B Circle Software/NugetPackages"
        : @"\\192.168.0.115\B Circle Software\NugetPackages";

Task("Pack").Does(() => {
    var project = $"src/{name}/{name}.fsproj";
    var settings = new DotNetCorePackSettings {
        OutputDirectory = repo
    };
    DotNetCorePack(project, settings);
});


Task("Create-NuGet-Package").Does(() => {
    var project = $"src/{name}/{name}.fsproj";
    CleanDirectory("publish");
    DotNetCorePack(project, new DotNetCorePackSettings {
        OutputDirectory = "publish"
    });
});

Task("Publish-Nuget")
    .IsDependentOn("Create-Nuget-Package")
    .Does(() => {
        var nupkg = new DirectoryInfo("publish").GetFiles("*.nupkg").LastOrDefault();
        var package = nupkg.FullName;
        NuGetPush(package, new NuGetPushSettings {
            Source = "https://www.nuget.org/api/v2/package",
            ApiKey = npi
        });
});

var target = Argument("target", "default");
RunTarget(target);

