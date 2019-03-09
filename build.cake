#addin "wk.StartProcess"
#addin "wk.ProjectParser"

using PS = StartProcess.Processor;
using ProjectParser;

var publishDir = ".publish";
var version = DateTime.Now.ToString("yy.MM.dd.HHmm");

var settings = new DotNetCoreMSBuildSettings();
settings.Properties["Version"] = new string[] { version };

Task("Pack").Does(() => {
    CleanDirectory(publishDir);

    DotNetCorePack($"src/Cake.SquareLogo", new DotNetCorePackSettings {
        OutputDirectory = publishDir,
        MSBuildSettings = settings
    });

    DotNetCorePack($"src/SquareLogo", new DotNetCorePackSettings {
        OutputDirectory = publishDir,
        MSBuildSettings = settings
    });
});

var target = Argument("target", "Pack");
RunTarget(target);