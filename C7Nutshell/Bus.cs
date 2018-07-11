using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C7Nutshell
{
    public class Bus
    {
        //static variables used by all Bus instances.
        //Represents the time the first bus of the day starts its route
        protected static readonly DateTime globalStartTime;

        //Property for the number of each bus.
        protected int RouteNumber { get; set; }

        //Static constructor to initialize the static variable.
        //it's invoked before the first instance constructor is run.
        static Bus()
        {
            globalStartTime = DateTime.Now;

            //the following statement produces the first line of output,
            //and the line occurs only once.
            WriteLine($"Static constructor sets global start time to {globalStartTime.ToLongTimeString()}");
        }

        //Instance constructor
        public Bus (int routeNum)
        {
            RouteNumber = routeNum;
            WriteLine($"Bus #{RouteNumber} is created.");
        }

        //Instance method
        public void Drive()
        {
            TimeSpan elapsedTime = DateTime.Now - globalStartTime;
            //For demonstration purposes we treat milliseconds as minutes to simulate
            //actual bus times.
            WriteLine($"{this.RouteNumber} is starting its route {elapsedTime.TotalMilliseconds} minutes after global start time {globalStartTime.ToShortTimeString()}");
        }
    }
}
