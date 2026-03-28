namespace DesignPatternsNotes.Creational.AbstractFactory;

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}