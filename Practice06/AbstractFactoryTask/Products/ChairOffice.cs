using System;

namespace AbstractFactory.Products
{
    public class ChairOffice : IChair
    {
        public ChairOffice()
        {
            Console.WriteLine("ChairOffice created");
        }
    }
}