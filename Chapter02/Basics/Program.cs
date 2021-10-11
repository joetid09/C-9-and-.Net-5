using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
// #error version
// Console.WriteLine("Hello World");
namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool onOffSwitch = true;
            string response;
            string[] foodItems = { "pizza", "pudding", "parmigiano" };
            List<string> foods = new List<string>();

            foods.AddRange(foodItems);





            while (onOffSwitch == true)
            {
                Console.WriteLine("Welcome to McGoob's. What can I getcha?");
                Console.ReadLine();
                Console.WriteLine("Please make a numbered selection");
                Console.WriteLine("1.) Chicken");
                Console.WriteLine("2.) Pasta");
                Console.WriteLine("3.) Burger");
                Console.WriteLine("4.) Wings");
                Console.WriteLine("5.) Ice Cream");
                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        Console.WriteLine("MMMM, how can you go wrong with chicken?");
                        break;

                    case "2":
                        Console.WriteLine("Carbo looooaaaaaading");
                        break;

                    case "3":
                        Console.WriteLine("Yeah, slap this between those buns!");
                        break;

                    case "4":
                        Console.WriteLine("*insert chicken noise* yep");
                        break;

                    case "5":
                        Console.WriteLine("Ice cream.... for dinner??!");
                        break;

                    default:
                        Console.WriteLine("I'm sorry, I can't let you do that");
                        Console.ReadLine();
                        Console.WriteLine("Now, get the FUCK OUTTA HHHEEEEERRRRRRREEEEEEEEE");
                        Console.Read();
                        onOffSwitch = false;
                        break;
                }
            }



            // List<string>foods = new List<string>();
            // string[] foodItems = {"pizza", "pudding", "parmigiano"};
            // foods.AddRange(foodItems);

            // string serving = "brussel sprouts";

            // foreach(string a in foods)
            // {
            //     serving = a;
            //     Console.WriteLine($"OH, I didn't order the {serving}");
            // }



        }
    }
}
