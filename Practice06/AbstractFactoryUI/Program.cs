using System;
using AbstractFactory;
using AbstractFactory.Factories;

namespace AbstractFactoryUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Client clientFactory1 = new Client(new FactoryWicker());
            clientFactory1.Create();
            Console.WriteLine();
            Client clientFactory2 = new Client(new FactoryOffice());
            clientFactory2.Create();
            Console.WriteLine();
            Client clientFactory3 = new Client(new FactoryOffice());
            clientFactory3.Create();
        }
    }
}
