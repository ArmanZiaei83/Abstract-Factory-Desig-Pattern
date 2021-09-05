using System;
using AbstractFactory.furnitures;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHome = new Home();
            myHome.CreateChair()
                .ChairLegs(4)
                .ChairModel("xama123")
                .ChairName("my chair");

            myHome.CreateTable()
                .TableColor("Red")
                .TableLegs(4)
                .TableModel("tb123");
            
        }
    }
}