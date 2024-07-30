namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<Pizza> pizzas = new List<Pizza>
        {
            new Pizza("small", 2, 2, 1),
            new Pizza("medium", 3, 1, 2),
            new Pizza("large", 2, 1, 1)
        };

            foreach (Pizza pizza in pizzas)
            {
                Console.WriteLine(pizza.getDescription());
                Console.WriteLine($"Cost: ${pizza.calcCost()}");
                Console.WriteLine();
            }
        }
    }
}
