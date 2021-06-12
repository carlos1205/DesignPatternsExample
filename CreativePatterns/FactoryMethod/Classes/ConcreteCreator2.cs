using FactoryMethod.Abstracts;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Classes
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
