using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C7Nutshell.Base;
using static System.Console;

namespace C7Nutshell
{
    public class DerivedClass :BaseClass
    {
        public void Method2()
        {
            WriteLine("Derived - Method2");
        }
    }
}
