using System;
using System.Collections.Generic;
using System.Text;

namespace C7Nutshell.Abstract
{
    public abstract class Asset
    {
        //Note empty implementation
        public abstract decimal NetValue { get; }
    }

    public class Stock : Asset
    {
        public long SharesOwned;
        public decimal CurrentPrice;

        //Override like a virtual method.
        public override decimal NetValue => CurrentPrice * SharesOwned;
    }
}
