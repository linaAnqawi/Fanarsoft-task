using System;
using System.Collections.Generic;
using System.Text;

namespace Fanarsot_Task
{
    abstract class Pizza
    {
       
        public string size { get; set; }
        public Pizza()
        {
        }
        public Pizza(string size)
        {
            this.size = size;
        
        }
        //this method to check if pizza is ready to deliver 
        public abstract void pizzaIsReady();
        public abstract void pizzaIsBaked();
        //abstraction 
        //polymorphism
        //this method take a pizza object to calculate price, and i will override it in sub class
        public double GetPrice(Pizza pizza)
        {
            double price = 0;
            if (this.size == "small")
            {
                price = 10;

            }
            else if (this.size == "large")
            {
                price = 15;
            }
            else
            {
                price = 20;
            }
            return price;
        }
    }
}

  
