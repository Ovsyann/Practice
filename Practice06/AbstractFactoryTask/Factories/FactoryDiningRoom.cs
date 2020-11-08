using AbstractFactory.Products;
using System;

namespace AbstractFactory.Factories
{
    public class FactoryDiningRoom : IFactory
    {
        public ITable CreateTable()
        {
            return new TableDiningRoom();
        }

        public IChair CreateChair()
        {
            return new ChairDiningRoom();
        }

        public ISofa CreateSofa()
        {
            return new SofaDiningRoom();
        }

        public IWardrobe CreateWardrobe()
        {
            return new WardrobeDiningRoom();
        }
    }
}