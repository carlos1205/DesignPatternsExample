using FactoryMethod.Interfaces;

namespace FactoryMethod.Classes
{
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
