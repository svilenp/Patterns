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
            List<ExportType> exporters = new List<ExportType>
            {
                new FullFactory(),
                new LimitedFactory(),
                new SummaryFactory()
            };

            foreach (var exporter in exporters)
            {
                Console.WriteLine($"{exporter.GetType().Name} :");
                foreach (var section in exporter.Sections)
                {
                    section.Include();
                }

                Console.WriteLine();
            }
        }
    }
}
