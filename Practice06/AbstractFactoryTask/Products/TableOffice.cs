using System;

namespace AbstractFactory.Products
{
    public class TableOffice : ITable
    {
        public TableOffice()
        {
            Console.WriteLine("TableOffice created");
        }
    }
}