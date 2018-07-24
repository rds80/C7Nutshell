using static System.Console;

namespace C7Nutshell
{
    internal class Widget : I1, I2
    {
        public void Foo()
        {
            WriteLine("Widget's implementation of I1.Foo");
        }

        int I2.Foo()
        {
            WriteLine("Widget's implementation of I2.Foo");
            return 42;
        }
    }
}