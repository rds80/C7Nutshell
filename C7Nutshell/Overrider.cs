using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using C7Nutshell.Base2;

namespace C7Nutshell
{
    class Overrider : BaseClass
    {
        public override void Foo() { WriteLine("Overrider.Foo"); }
    }
}
