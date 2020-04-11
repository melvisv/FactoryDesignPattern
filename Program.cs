using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Donut number: 0 - Regular,1- Chocolate , 2 - Strawberry ");
            int coffeeNumber = int.Parse(Console.ReadLine());
            DonutType donutType = (DonutType)coffeeNumber;

            Donut donut = DonutFactory.GetDonut(donutType);
            donut.Print();

            Console.ReadKey(true);
        }
    }
}
