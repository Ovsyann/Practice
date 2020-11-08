using System;

namespace AbstractFactory.Products
{
    public class WardrobeOffice : IWardrobe
    {
        public WardrobeOffice()
        {
            Console.WriteLine("WardrobeOffice created");
        }
    }
}