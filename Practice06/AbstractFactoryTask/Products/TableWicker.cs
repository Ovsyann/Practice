using System;

namespace AbstractFactory.Products
{
    public class TableWicker : ITable
    {
        public TableWicker()
        {
            Console.WriteLine("TableWicker created");
        }
    }
}