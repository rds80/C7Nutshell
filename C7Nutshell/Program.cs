using System;
using static System.Console;

namespace C7Nutshell
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomTypeExample();


        }

        private static void CustomTypeExample()
        {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);

            WriteLine(feetToInchesConverter.Convert(30));   //360
            WriteLine(feetToInchesConverter.Convert(100));   //1200
            WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));   //63360
            Read();
        }
    }
}
