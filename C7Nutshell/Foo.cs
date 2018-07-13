using static System.Console;

namespace C7Nutshell
{
    internal class Foo
    {
        public static Foo Instance = new Foo();
        public static int X = 3;
        Foo() { WriteLine(X); }
    }
}