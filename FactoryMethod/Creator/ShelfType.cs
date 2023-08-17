using FactoryMethod.Product;
using System.Collections.Generic;

namespace FactoryMethod.Creator
{
    public abstract class ShelfType
    {
        public List<ISection> Sections { get; set; }

        public ShelfType()
        {
            Sections = new List<ISection>();

            Create();
        }

        // The Factory Method
        public abstract void Create();
    }
}
