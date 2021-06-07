namespace AbstractFactory.Interfaces
{
    public interface IAbstractProductB
    {
        string UsefulFunctionB();

        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
