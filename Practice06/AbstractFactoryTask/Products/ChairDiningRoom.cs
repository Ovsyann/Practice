using System;

namespace AbstractFactory.Products
{
    public class ChairDiningRoom : IChair
    {
        public ChairDiningRoom()
        {
            Console.WriteLine("ChairDiningRoom created");
        }
    }
}