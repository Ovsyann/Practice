using System;

namespace MonteCarloUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int experimantsAmount = int.Parse(Console.ReadLine());
            Factory.ControlQuality(experimantsAmount);
            Console.WriteLine(Factory.probabilityA);
            Console.WriteLine(Factory.probabilityB);
            Console.WriteLine(Factory.probabilityC);
        }
    }
}
