Task("Build-Release").Does(() => {
    DotNetBuild(solution, settings =>
        settings.SetConfiguration("Release")
        //.SetVerbosity(Core.Diagnostics.Verbosity.Minimal)
        .WithTarget("Build")
        .WithProperty("TreatWarningsAsErrors","false"));
});



