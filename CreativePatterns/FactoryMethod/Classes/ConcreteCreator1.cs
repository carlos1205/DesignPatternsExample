using FactoryMethod.Abstracts;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Classes
{
    class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
