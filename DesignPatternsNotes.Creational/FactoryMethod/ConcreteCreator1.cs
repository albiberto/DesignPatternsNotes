namespace DesignPatternsNotes.Creational.FactoryMethod;

public class ConcreteCreator1 : CreatorBase
{
    protected override IProduct FactoryMethod() => new ConcreteProduct1();
}