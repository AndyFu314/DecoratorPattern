using DecoratorPattern.MainCourse;
using DecoratorPattern.Side;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Breakfast meal1 = new Toast();
            Log(meal1);

            Breakfast meal2 = new Toast();
            meal2 = new Ham(meal2);
            meal2 = new Ham(meal2);
            Log(meal2);

            Breakfast meal3 = new Burger();
            meal3 = new Cheese(meal3);
            meal3 = new Ham(meal3);
            meal3 = new Cheese(meal3);
            Log(meal3);

            Console.ReadKey();
        }

        private static void Log(Breakfast meal)
        {
            Console.WriteLine($"餐點: {meal.GetDescription()} 價格: {meal.cost()}");
        }
    }
}
