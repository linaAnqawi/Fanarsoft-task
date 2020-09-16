using System;
using System.Collections.Generic;
using System.Text;

namespace Fanarsot_Task
{
    //inheritance
    class Pepperoni : Pizza
    {
        public static int countOfPepperoni = 20;
        public static double price = 25;
        public Pepperoni()
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
            Console.WriteLine("pizza is preparing ");
            Console.WriteLine("making Dough....");
            Console.WriteLine("Adding pepperoni...");
            Console.WriteLine("Adding cheese...");
        
        }
    }

}
