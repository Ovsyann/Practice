using AbstractFactory.Products;
using System;

namespace AbstractFactory.Factories
{
    public class FactoryWicker : IFactory
    {
        public ITable CreateTable()
        {
            return new TableWicker();
        }

        public IChair CreateChair()
        {
            return new ChairWicker();
        }

        public ISofa CreateSofa()
        {
            return new SofaWicker();
        }

        public IWardrobe CreateWardrobe()
        {
            return new WardrobeWicker();
        }
    }
}