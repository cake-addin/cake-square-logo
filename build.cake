#tool "nuget:?package=Mono.TextTransform"

var target = Argument("target", "default");
RunTarget(target);

