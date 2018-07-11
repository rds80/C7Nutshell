using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C7Nutshell
{
    public class Person
    {
        string name;

        public string Name
        {
            get => name;
            set => name = value ?? "";
        }

        static Person()
        {
            WriteLine("test");
        }

        public Person(string name) => Name = name;

        ~Person() => WriteLine("finalize");

        public void Deconstruct(out string firstName, out string lastName)
        {
            int spacePos = name.IndexOf(' ');
            firstName = name.Substring(0, spacePos);
            lastName = name.Substring(spacePos + 1);
        }

    }
}
