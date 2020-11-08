using System;

namespace AbstractFactory.Products
{
    public class SofaDiningRoom : ISofa
    {
        public SofaDiningRoom()
        {
            Console.WriteLine("SofaDiningRoom created");
        }
    }
}