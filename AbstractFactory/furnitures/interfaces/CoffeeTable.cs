using System;

namespace AbstractFactory.furnitures
{
    public class CoffeeTable : ITable
    {
        public ITable TableColor(string color)
        {
            Console.WriteLine($"Coffee Table is {color}");
            return this;
        }

        public ITable TableLegs(int legs)
        {
            Console.WriteLine($"Coffee Table Has {legs} Leg(s)");
            return this;
        }

        public ITable TableModel(string model)
        {
            Console.WriteLine($"Coffee Table Model : {model}");
            return this;
        }
    }
}