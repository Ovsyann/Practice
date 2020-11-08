using System;

namespace AbstractFactory.Products
{
    public class ChairWicker : IChair
    {
        public ChairWicker()
        {
            Console.WriteLine("ChairWicker created");
        }
    }
}