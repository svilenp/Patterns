using FactoryMethod.Product;
using System;
using System.Collections.Generic;

namespace FactoryMethod.ConcreteProduct
{
    public class AlcoholSection : ISection
    {
        public void Include()
        {
            var alcohols = new List<string> 
            { 
                "Beers",
                "Vodkas",
                "Jins",
                "Wines",
                "Siders",
            };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Section {i + 1} - {alcohols[i]}");
            }
        }
    }
}
