using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Pizza
    {

        private String PizzaSize { get; set; }
        private int CheeseToppings {  get; set; }

        private int PepperoniToppings {  get; set; }
        private int HamToppings {  get; set; }


        public Pizza(string pizzaSize, int cheeseToppings, int pepperoniToppings, int hamToppings)
        {
            this.PizzaSize = pizzaSize;
            this.CheeseToppings = cheeseToppings;
            this.PepperoniToppings = pepperoniToppings;
            this.HamToppings = hamToppings;
        }

        public double calcCost()
        {
            double cost = 0;
            switch (PizzaSize.ToLower())
            {
                case "small":
                    {
                        cost = 10;
                        break;
                    }
                case "medium":
                    {
                        cost = 12;
                        break;
                    }
                case "large":
                    {
                        cost = 14;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid pizza size");
                        break;
                    }
            }
                 return cost + 2 * (CheeseToppings + PepperoniToppings + HamToppings);
            
        }
        public string getDescription()
        {
            return $"Size: {PizzaSize}, Cheese Toppings: {CheeseToppings}, Pepperoni Toppings: {PepperoniToppings}, Ham Toppings: {HamToppings}";
        }




    }
}
