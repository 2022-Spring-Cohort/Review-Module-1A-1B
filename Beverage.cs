using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewModule1
{
    class Beverage
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }

        public string Brand { get; set; }

        public Beverage()
        {
            Ingredients = new List<string>();
        }

        public override string ToString()
        {
            string listOfIngredients = "";
            for(int i = 0; i < Ingredients.Count; i++)
            {
                if(i == Ingredients.Count - 1)
                {
                    listOfIngredients += Ingredients[i];
                }
                else
                {
                    listOfIngredients += Ingredients[i] + ", ";
                }
                
            }

            return Name + " was made by " + Brand + ". \nThis beverage includes: " + listOfIngredients;
        }
    }
}
