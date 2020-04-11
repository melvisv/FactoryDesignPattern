using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public abstract class Donut
    {
        public abstract string Name { get; }

        public abstract int Calories { get; }

        public void Print()
        {
            Console.WriteLine("This Donut is {0} . It has {1} calories ", Name , Calories);
        }
    }

    public class RegularDonut : Donut
    {
        public override string Name
        {
            get { return "Regular"; }
        }

        public override int Calories
        {
            get { return 50; }
        }

    }

    public class ChocolateDonut  : Donut
    {
        public override string Name
        {
            get { return "Chocolate"; }
        }

        public override int Calories
        {
            get { return 125; }
        }

    }

    public class StrawberryDonut : Donut
    {
        public override string Name
        {
            get { return "Strawberry"; }
        }

        public override int Calories
        {
            get { return 110; }
        }

    }
}
