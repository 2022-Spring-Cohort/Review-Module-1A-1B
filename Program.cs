using System;

namespace ReviewModule1
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXAMPLE 1
            //Example1();

            // EXAMPLE 2
            //Example2();

            //Example3();

            int myNumber = Utility.GetNumber();

            Console.ReadKey();
        }

        static void Example1()
        {
            Console.WriteLine("Please your enter your name: ");
            string name = Console.ReadLine();

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
            Console.WriteLine();
        }

        static void Example2()
        {
            string[] favoriteFoods = new string[3];
            Console.WriteLine("Enter 3 of your favorite foods: ");

            int j = 0;
            while (j < 3)
            {
                Console.WriteLine("Food Number " + (j + 1) + ": ");
                favoriteFoods[j] = Console.ReadLine();
                j++;
            }

            Console.WriteLine(favoriteFoods.ToString());


        }

        static void Example3()
        {
            Beverage myBeverage = new Beverage();

            Console.WriteLine("Please enter a beverage name: ");
            myBeverage.Name = Console.ReadLine();

            Console.WriteLine("What are 2 ingredients in this beverage?");

            myBeverage.Ingredients.Add(Console.ReadLine());
            myBeverage.Ingredients.Add(Console.ReadLine());

            Console.WriteLine("Please enter the brand name:");
            myBeverage.Brand = Console.ReadLine();

            Console.WriteLine(myBeverage.ToString());
        }
    }
}
