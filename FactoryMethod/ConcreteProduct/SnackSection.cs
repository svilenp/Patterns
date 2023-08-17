using FactoryMethod.Product;
using System; 

namespace FactoryMethod.ConcreteProduct
{
    public class SnackSection : ISection
    {
        public void Include()
        {
            Console.WriteLine("Here is some snack.");
        }
    }
}
