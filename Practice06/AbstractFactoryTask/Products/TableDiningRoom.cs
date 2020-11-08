using System;

namespace AbstractFactory.Products
{
    public class TableDiningRoom : ITable
    {
        public TableDiningRoom()
        {
            Console.WriteLine("TableDiningRoom created");
        }
    }
}