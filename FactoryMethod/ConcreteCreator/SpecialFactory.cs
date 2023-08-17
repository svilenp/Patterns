using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;

namespace FactoryMethod.ConcreteCreator
{
    public class SpecialFactory : ShelfType
    {
        public override void Create()
        {
            Sections.Add(new AlcoholSection());
            Sections.Add(new WaterSection());
            Sections.Add(new SnackSection());
            Sections.Add(new TeaSection());
        }
    }
}
