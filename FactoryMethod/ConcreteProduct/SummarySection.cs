using FactoryMethod.Product;
using System;

namespace FactoryMethod.ConcreteProduct
{
    public class SummarySection : ISection
    {
        public void Include()
        {
            Console.WriteLine("Just a summary!");
        }
    }
}
