using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Fanarsot_Task
{
    //inheritance
    class Cheese : Pizza
    {
        public static int countOfCheese = 20;
        public static double price = 20;

        public Cheese()
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
            Console.WriteLine("pizza is preparing");
            Console.WriteLine("making Dough....");
            Console.WriteLine("Adding cheese...");
        }
    }
}
