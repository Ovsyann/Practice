using System;

namespace AbstractFactory.Products
{
    public class WardrobeDiningRoom : IWardrobe
    {
        public WardrobeDiningRoom()
        {
            Console.WriteLine("WardorbeDiningRoom created");
        }
    }
}