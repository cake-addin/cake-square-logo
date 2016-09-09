using Cake.Core;
using Cake.SquareLogo.LogoAlias;
using FSharp.Core.Fluent;
using Microsoft.FSharp.Collections;
using FluentAssertions;
using NUnit.Framework;

namespace Cake.SquareLogo.CSharp
{
    public class LoadFromCSharp
    {
        [Test]
        public void IsVisible(ICakeContext context)
        {
            context.CreateLogo("Hello", "Hello.png");
        }

        [Test]
        public void ShouldVisibleFromCSharp()
        {
            var list = new FSharpList<string>("Hello", FSharpList<string>.Empty);
            var max = list.max();
            max.Should().Be("Hello");
        }
    }
}
