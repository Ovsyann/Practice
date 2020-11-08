using System;

namespace AbstractFactory.Products
{
    public class SofaWicker : ISofa
    {
        public SofaWicker()
        {
            Console.WriteLine("SofaWicker created");
        }
    }
}