using DecoratorPattern.Ingredients;
using DecoratorPattern.Types;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new MushroomPizza();
            pizza1 = new Tomato(pizza1);
            Log(pizza1);

            Pizza pizza2 = new HawaiiPizza();
            pizza2 = new Cheese(pizza2);
            pizza2 = new Tomato(pizza2);
            Log(pizza2);

            Pizza pizza3 = new MushroomPizza();
            pizza3 = new Cheese(pizza3);
            pizza3 = new Cheese(pizza3);
            pizza3 = new Beef(pizza3);
            Log(pizza3);

            Pizza pizza4 = new HawaiiPizza();
            pizza4 = new Cheese(pizza4);
            pizza4 = new Beef(pizza4);
            pizza4 = new Tomato(pizza4);
            pizza4 = new Shrimp(pizza4);
            Log(pizza4);

            Console.ReadKey();
        }

        private static void Log(Pizza pizza)
        {
            Console.WriteLine($"披薩: {pizza.GetName()}, 價格: {pizza.Cost()}");
            Console.WriteLine();
        }
    }
}
