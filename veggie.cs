using System;
using System.Collections.Generic;
using System.Text;

namespace Fanarsot_Task
{
    //inheritance
    class veggie :Pizza
    {
        public static int countOfVeggie = 20;
        public static double price = 15;
        public veggie()
        { 
        }
        public override void pizzaIsReady()
        {
            Console.WriteLine("pizza is baking ...");
            Console.WriteLine("pizza is Cutting ...");
            Console.WriteLine("pizza is Boxing ...");
            Console.WriteLine("Done!");

        }
        public override void pizzaIsBaked()
        {
            Console.WriteLine("pizza in a preparing");
            Console.WriteLine("making Dough....");
            Console.WriteLine("Adding vegetables...");
            Console.WriteLine("Adding cheese...");
        }

      
    }
}
