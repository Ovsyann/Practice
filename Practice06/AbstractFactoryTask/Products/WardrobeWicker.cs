using System;

namespace AbstractFactory.Products
{
    public class WardrobeWicker : IWardrobe
    {
        public WardrobeWicker()
        {
            Console.WriteLine("WardrobeWicker created");
        }
    }
}