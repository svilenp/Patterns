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
            List<ShelfType> shelves = new List<ShelfType>
            {
                new SpecialFactory(),
                new StandardFactory(),
                new SimpleFactory()
            };

            foreach (var shelf in shelves)
            {
                Console.WriteLine($"{shelf.GetType().Name} :");
                foreach (var section in shelf.Sections)
                {
                    section.Include();
                }

                Console.WriteLine();
            }
        }
    }
}
