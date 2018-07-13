using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace C7Nutshell
{
    public class Asset
    {
        public string Name;
        public virtual decimal Liability => 0;
    }

    public class Stock : Asset //inherits from Asset
    {
        public long SharesOwned;
    }

    public class House : Asset // inherits from Asset
    {
        public decimal Mortgage;
        public override decimal Liability => Mortgage;
    }
}
