using System;
using System.Text;
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
            //ClassExample();
            //NumericalLiteralExamples();
            //FactorialIterationExample(6);
            //int factorial = FactorialRecursionExample(6);
            //CheckedOperatorExample();
            //DivideNonZeroExample();
            //NaNExample();
            //BoolReferenceExample();
            //Point[] a = new Point[1000];
            //int x = a[500].X;
            //HeapGCExample();
            DefiniteAssignmentExample();
            Read();
        }

        public struct Point
        {
            public int X; //4 bytes
            public int Y; //4 bytes
        }

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

        private static void NumericalLiteralExamples()
        {
            WriteLine(1.0.GetType());   //Double (double)
            WriteLine(1E06.GetType());   //Double (double)
            WriteLine(1.GetType());   //Int32 (int)
            WriteLine(0xF0000000.GetType());   //uint32 (uint)
            WriteLine(0x100000000.GetType());   //int64 (long)
        }

        private static int FactorialIterationExample(int number)
        {
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static int FactorialRecursionExample(int number)
        {

            if (number == 0)
            {
                return 1;
            }
            return number * FactorialRecursionExample(number - 1);

        }

        private static void CheckedOperatorExample()
        {
            int a = 1000000;
            int b = 1000000;

            int c = checked(a * b);
        }

        private static void DivideNonZeroExample()
        {
            WriteLine(1.0 / 0.0);   //Infinity
            WriteLine(-1.0 / 0.0);   // -Infinity
            WriteLine(1.0 / -0.0);   // -Infinity
            WriteLine(-1.0 / -0.0);   // -Infinity
        }

        private static void NaNExample()
        {
            WriteLine(0.0 / 0.0);   //NaN
            WriteLine((1.0 / 0.0) - (1.0 / 0.0)); //NaN
        }

        private static void BoolReferenceExample()
        {
            Dude d1 = new Dude("John");
            Dude d2 = new Dude("John");
            WriteLine(d1 == d2); //False
            Dude d3 = d1;
            WriteLine(d1 == d3);  //True
        }

        public class Dude
        {
            public string Name;
            public Dude(string n)
            {
                Name = n;
            }
        }

        private static void DefiniteAssignmentExample()
        {
            int[] ints = new int[2];
            WriteLine(ints[0]);
        }

        private static void HeapGCExample()
        {
            StringBuilder ref1 = new StringBuilder("object1");
            WriteLine(ref1);

            //SB referenced by ref is now eligible for GC.

            StringBuilder ref2 = new StringBuilder("object2");
            StringBuilder ref3 = ref2;

            //StringBuilder referenced by ref2 is not yet eligible for GC.
            WriteLine(ref3);    //object2
        }

        public class Test
        {
            public static int x;
        }

    }
}
