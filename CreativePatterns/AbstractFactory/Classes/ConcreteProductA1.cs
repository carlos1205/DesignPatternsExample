using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The return of the Product A1!";
        }
    }
}
