using FactoryMethod.Interfaces;

namespace FactoryMethod.Classes
{
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
