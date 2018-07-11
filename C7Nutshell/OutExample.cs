using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C7Nutshell
{
    public class OutExample
    {
        public static void Split(string name, out string firstNames, out string lastName)
        {
            int i = name.LastIndexOf(' ');
            firstNames = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }

        public static void Foo(int x = 0, int y = 0)
        {
            WriteLine(x + "," + y);
        }
    }
}
