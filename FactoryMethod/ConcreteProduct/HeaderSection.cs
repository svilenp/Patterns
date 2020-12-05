using FactoryMethod.Product;
using System; 

namespace FactoryMethod.ConcreteProduct
{
    public class HeaderSection : ISection
    {
        public void Include()
        {
            Console.WriteLine("Headers applied");
        }
    }
}
