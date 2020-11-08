using AbstractFactory.Products;
using System;

namespace AbstractFactory.Factories
{
    public class FactoryOffice : IFactory
    {
        public ITable CreateTable()
        {
            return new TableOffice();
        }

        public IChair CreateChair()
        {
            return new ChairOffice();
        }

        public ISofa CreateSofa()
        {
            return new SofaOffice();
        }

        public IWardrobe CreateWardrobe()
        {
            return new WardrobeOffice();
        }
    }
}