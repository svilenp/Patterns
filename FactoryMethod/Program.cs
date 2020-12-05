using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;
using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OrderType> orders = new List<OrderType>
            {
                new FullFactory(),
                new LimitedFactory(),
                new SummaryFactory()
            };

            foreach (var order in orders)
            {
                Console.WriteLine($"{order.GetType().Name} :");
                foreach (var section in order.Sections)
                {
                    section.Include();
                }

                Console.WriteLine();
            }
        }
    }
}
