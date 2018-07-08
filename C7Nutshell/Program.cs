using System;
using static System.Console;

namespace C7Nutshell
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomTypeExample();
            //InstanceStaticExample();
            //StructExample();
            ClassExample();
            Read();
        }

        public struct Point { public int X, Y; }

        private static void StructExample()
        {
            Point p1 = new Point();
            p1.X = 7;

            Point p2 = p1;      //assignment causes company
            WriteLine(p1.X);     //7
            WriteLine(p2.X);     //7

            p1.X = 9;           //Change p1.X

            WriteLine(p1.X);     //9
            WriteLine(p2.X);     //7
        }

        public class PointClass { public int X, Y; }

        private static void ClassExample()
        {
            Point p1 = new Point();
            p1.X = 7;

            Point p2 = p1;  //Copies p1 reference
            WriteLine(p1.X);    //7
            WriteLine(p2.X);    //7

            p1.X = 9;           //Change p1.X

            WriteLine(p1.X);   //9
            WriteLine(p2.X);    //9

            PointClass pNull = null;
            WriteLine(pNull == null);   //True

            //Following line generates a runtime error
            //(a NullReferenceException is thrown for reference type)
            WriteLine(pNull.X);

            //Point p = null; //Compile-time error for value type
            //int x = null;   //Complile-time eror for value type
        }

        private static void InstanceStaticExample()
        {
            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");
            WriteLine(p1.name);
            WriteLine(p2.name);
            Write(Panda.population);
        }

        private static void CustomTypeExample()
        {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);

            WriteLine(feetToInchesConverter.Convert(30));   //360
            WriteLine(feetToInchesConverter.Convert(100));   //1200
            WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));   //63360
        }
    }
}
