using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The return of the Product A2!";
        }
    }
}
