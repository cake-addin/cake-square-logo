
#reference "../Cake.SquareLogo/bin/Debug/Cake.SquareLogo.dll"
using Cake.SquareLogo;

Task("Create-Logo").Does(() => {
        CreateLogo("Hello", "Hello.png");
});

var target = Argument("target", "default");
RunTarget(target);