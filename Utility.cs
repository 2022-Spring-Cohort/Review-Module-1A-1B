using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewModule1
{
    static class Utility
    {
        public static int GetNumber()
        {
            

            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();

            int num;
            while(!int.TryParse(userInput, out num))
            {
                Console.WriteLine("That's not a number. Try again.");
                userInput = Console.ReadLine();
            }

            return num;

        }
    }
}
