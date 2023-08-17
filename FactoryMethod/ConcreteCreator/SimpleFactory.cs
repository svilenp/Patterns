using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;

namespace FactoryMethod.ConcreteCreator
{
    public class SimpleFactory : ShelfType
    {
        public override void Create()
        {
            Sections.Add(new UselessSection());
        }
    }
}
