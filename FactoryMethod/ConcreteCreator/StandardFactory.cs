using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;

namespace FactoryMethod.ConcreteCreator
{
    public class StandardFactory : ShelfType
    {
        public override void Create()
        {
            Sections.Add(new AlcoholSection());
        }
    }
}
