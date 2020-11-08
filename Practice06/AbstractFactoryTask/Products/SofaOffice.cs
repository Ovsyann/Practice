using System;

namespace AbstractFactory.Products
{
    public class SofaOffice : ISofa
    {
        public SofaOffice()
        {
            Console.WriteLine("SofaOffice created");
        }
    }
}