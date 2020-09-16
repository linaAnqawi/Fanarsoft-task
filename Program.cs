using System;

namespace Fanarsot_Task
{
    class Program
    {
        //main class
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            double totalprice = 0;
            string size =" ";
            int payoption = 0;
            int custoMermoney = 0;
            Console.Clear();
            Console.WriteLine("which type of pizza would like to eat ?");
            Console.WriteLine("1) cheese pizza (20 NIC)");
            Console.WriteLine("2) pepperoni pizza (25 NIC)");
            Console.WriteLine("3) veggie pizza (20 NIC)");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    DisplayResult("cheese ");
                    if(Cheese.countOfCheese>0){
                        Pizza cheesePizza=new Cheese();
                        size = SizeMenu();
                        cheesePizza.size = size;
                      
                        totalprice = cheesePizza.GetPrice(cheesePizza) + Cheese.price;
                        Console.Clear();
                        DisplaytotalPrice(totalprice + "");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney=TakeCoin();

                        }
                        else
                        {
                            //Notes
                            notesmnue();
                            custoMermoney=TakeNotes();

                        }
                        
                        RestOfMoney(totalprice, custoMermoney);
                        Cheese.countOfCheese--;
                        cheesePizza.pizzaIsBaked();
                        cheesePizza.pizzaIsReady();
                    }
                    else
                    {
                        Console.WriteLine("This type of pizza is unavailable");
                    }
                    Console.ReadLine();
                    return true;
                case "2":
                    DisplayResult("pepperoni");
                    if (Pepperoni.countOfPepperoni > 0)
                    {
                        Pizza pepperoniPizza = new Pepperoni();
                        size = SizeMenu();
                        pepperoniPizza.size = size;
                        totalprice = pepperoniPizza.GetPrice(pepperoniPizza) + Pepperoni.price;
                        DisplaytotalPrice(totalprice+"");
                        payoption=paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney=TakeCoin();
                        }
                        else
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();

                        }
                        RestOfMoney(totalprice, custoMermoney);
                        pepperoniPizza.pizzaIsBaked();
                        pepperoniPizza.pizzaIsReady();
                        Pepperoni.countOfPepperoni--;
                        
                    }
                    else
                    {
                        Console.WriteLine("This type of pizza is unavailable");
                    }

                    return true;
                case "3":
                    DisplayResult("veggie");
                    if (veggie.countOfVeggie > 0)
                    {
                        Pizza veggiePizza = new veggie();
                        size = SizeMenu();
                        veggiePizza.size = size;
                        totalprice = veggiePizza.GetPrice(veggiePizza) + Pepperoni.price;
                        DisplaytotalPrice(totalprice+"");
                        payoption = paymnue();
                        if (payoption == 1)
                        {
                            //coins
                            coinmnue();
                            custoMermoney = TakeCoin();
                        }
                        else
                        {
                            //Notes
                            notesmnue();
                            custoMermoney = TakeNotes();

                        }
                        RestOfMoney(totalprice, custoMermoney);
                        veggiePizza.pizzaIsBaked();
                        veggiePizza.pizzaIsReady();
                        veggie.countOfVeggie--;
                    }

                    return false;
                default:
                    return true;
            }
        }


        private static void DisplayResult(string message)
        {
            Console.Clear();
            Console.WriteLine($"\r\nyour option is: {message}");
            Console.Write("\r\nPress Enter");
       
        }
        private static string SizeMenu()
        {
            Console.Clear();
            Console.WriteLine("which size of pizza would like to eat ?");
            Console.WriteLine("1) small(10 Nis)");
            Console.WriteLine("2) large (15 Nis)");
            Console.WriteLine("3) extra large (20 Nis)");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                   
                    DisplayResult("your option was Small pizza ");
                    return "small";
                case "2":
                    DisplayResult("your option was Large pizza");
                    return "large";
                case "3":
                    DisplayResult("your option was Extra Large pizza");
                    return "extra large";
                default:
                    return " ";
            }
        }
        private static void DisplaytotalPrice(string message)
        {
            Console.Clear();
            Console.WriteLine($"\r\n the total price of your order is: {message}");
            Console.Write("\r\n would you like to conform this order ");
            Console.WriteLine("enter yes if you want");
            string x=Console.ReadLine();

        }

        private static int paymnue()
        {
            Console.Clear();
            Console.WriteLine(" would you like to pay by Coins or by notes");
            Console.WriteLine("1) Coin");
            Console.WriteLine("2) Notes");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    DisplayResult("your option was coin");
                    return 1;
                case "2":
                    DisplayResult("your option was notes");
                    return 2;
                
                default:
                    return 0;
            }
        }
        private static void coinmnue()
        {
            Console.Clear();
            Console.WriteLine(" the machine just accept these value of coin");
            Console.WriteLine("1) 1 nis");
            Console.WriteLine("2) 5 nis");
            Console.WriteLine("3) 10 nis");
            Console.WriteLine("are you sure tou want to payed by coins");
            string x = Console.ReadLine();
        }
        private static void notesmnue()
        {
            Console.Clear();
            Console.WriteLine(" the machine just accept these value of notes");
            Console.WriteLine("1) 20 nis");
            Console.WriteLine("2) 50 nis");
            Console.WriteLine("3) 100 nis");
            Console.WriteLine("are you sure tou want to payed by coins");
            string x = Console.ReadLine();

        }

        private static int TakeCoin()
        {
            string input = "";
            int coin1 = 0;
            int coin5 = 0;
            int coin10 = 0;
            int totalprice = 0;
             Console.Clear();
             Console.WriteLine($"\r\n please insert the (1 NIS) coins :");
             Console.Write("\r\n: ");
             input = Console.ReadLine();
             coin1=int.Parse(input);
             Console.WriteLine($"\r\n please insert the (5 NIS) coins :");
             Console.Write("\r\n: ");
             input = Console.ReadLine();
             coin5 = int.Parse(input)*5;
             Console.WriteLine($"\r\n please insert the (10 NIS) coins :");
             Console.Write("\r\n : ");
             input = Console.ReadLine();
             coin10 = int.Parse(input)*10;
             totalprice = coin1 + coin5 + coin10;
             Console.Clear();
             Console.WriteLine($"\r\n the total number of coins that you are payed is  :");
             Console.WriteLine(totalprice);
             return totalprice;
        }
        private static int TakeNotes()
        {
            string input = "";
            int coin1 = 0;
            int coin5 = 0;
            int coin10 = 0;
            int totalprice = 0;
            Console.Clear();
            Console.WriteLine($"\r\n please insert the (20 NIS) coins :");
            Console.Write("\r\n: ");
            input = Console.ReadLine();
            coin1 = int.Parse(input)*20;
            Console.WriteLine($"\r\n please insert the (50 NIS) coins :");
            Console.Write("\r\n: ");
            input = Console.ReadLine();
            coin5 = int.Parse(input)*50;
            Console.WriteLine($"\r\n please insert the (100 NIS) coins :");
            Console.Write("\r\n : ");
            input = Console.ReadLine();
            coin10 = int.Parse(input)*100;
            totalprice = coin1 + coin5 + coin10;
            Console.Clear();
            Console.WriteLine($"\r\n the total number of Notes that you are payed is  :");
            Console.WriteLine(totalprice);
            return totalprice;
        }

        public static double  RestOfMoney(  double priceOfOrder,int CustomerMoney)
        {
          double rest = 0;
            if (priceOfOrder > CustomerMoney)
            {
                Console.WriteLine("Sorry you didn't pay enough money");
                Console.ReadLine();

            }
            else
            {
                rest=  (CustomerMoney - priceOfOrder);
               
            }
            return rest;
        }
    }
}
