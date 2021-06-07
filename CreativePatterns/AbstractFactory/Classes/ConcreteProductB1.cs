using AbstractFactory.Interfaces;
namespace AbstractFactory.Classes
{
    class ConcreteProductB1 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            string result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of the Product B1!";
        }
    }
}
