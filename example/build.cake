#addin "wk.SquareLogo"

using SquareLogo;

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
    new Logo().CreateLogo("Hey!", "Colorful.png", settings);
});

var target = Argument("target", "Create-Logo");
RunTarget(target);