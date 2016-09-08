using Cake.Core;
using Cake.SquareLogo.LogoAlias;

namespace Cake.SquareLogo.CSharp
{
    public class LoadFromCSharp
    {
        public LoadFromCSharp()
        {
        }

        public void Ext(ICakeContext context)
        {
            context.CreateLogo("Hello", "Hello.png");
        }
    }
}
