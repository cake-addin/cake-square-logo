#addin nuget:?package=Cake.SquareLogo&Version=0.9.1

Task("Create-Logo").Does(() => {
    CreateLogo("Hello", "Hello.png");
});

Task("Create-Colorful-Logo").Does(() => {
    var settings = new LogoSettings {
        FontFamily = "Papyrus",
        FontSize = 50,
        Padding = 30,
        Foreground = "White",
        Background = "Green"
    };
    CreateLogo("Hey!", "Colorful.png", settings);
});

var target = Argument("target", "Create-Logo");
RunTarget(target);