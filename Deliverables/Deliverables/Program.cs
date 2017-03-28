using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverables
{
    class Program
    {
        static void Main(string[] args)
        {
            var firsthuman = new Human();
            firsthuman.Eat("a cheeseburger");

            var firstpanda = new Panda();
            firstpanda.Eat("bamboo");

            var Terminator = new Robot();
            if (Terminator is Robot)
            {
                
            }

            if (firsthuman is Human)
            {

            }
            if (firstpanda is Panda)
            {

            }
        }

    }
}
