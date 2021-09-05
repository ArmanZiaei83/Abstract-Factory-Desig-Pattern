using System;

namespace AbstractFactory.furnitures
{
    public class Chair : IChair
    {
        public IChair ChairName(string name)
        {
            Console.WriteLine($"Chair Name : {name}");
            return this;
        }

        public IChair ChairLegs(int legs)
        {
            Console.WriteLine($"Chair Has {legs} Legs");
            return this;
        }

        public IChair ChairModel(string model)
        {
            Console.WriteLine($"Chair Model : {model}");
            return this;
        }
    }
}