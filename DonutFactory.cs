using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class DonutFactory
    {
        public static Donut GetDonut(DonutType donutType)
        {
            switch (donutType)
            {
                case DonutType.Regular:
                    return new RegularDonut();
                case DonutType.Chocolate:
                    return new ChocolateDonut();
                case DonutType.Strawberry:
                    return new StrawberryDonut();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
