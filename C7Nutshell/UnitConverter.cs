using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7Nutshell
{
    public class UnitConverter
    {
        int ratio;  //Field
        public UnitConverter(int unitRatio) { ratio = unitRatio; }  //Constructor
        public int Convert (int unit) { return unit * ratio; } //Method
    }
}
