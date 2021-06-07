namespace AbstractFactory.Interfaces
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
