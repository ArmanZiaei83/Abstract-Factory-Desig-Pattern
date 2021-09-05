using System;

namespace AbstractFactory.furnitures
{
    public class Table : ITable
    {
        public ITable TableColor(string color)
        {
            Console.WriteLine($"Table Color : {color}");
            return this;
        }

        public ITable TableLegs(int legs)
        {
            Console.WriteLine($"Table Has {legs} Leg(s)");
            return this;
        }

        public ITable TableModel(string model)
        {
            Console.WriteLine($"Table Model : {model}");
            return this;
        }
    }
}