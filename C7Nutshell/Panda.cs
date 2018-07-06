using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7Nutshell
{
    public class Panda
    {
        public string name; //instance field
        public static int population; //static field

        public Panda(string n)
        {
            name = n; //assigng instance field
            population += 1; //incrememnt static population field
        }
    }
}
