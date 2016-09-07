#tool "nuget:?package=NUnit.ConsoleRunner"

Task("Test") .Does(() => {
    CleanDirectory("Screen");
    DotNetBuild(solution);
    NUnit3(testDll);
});
