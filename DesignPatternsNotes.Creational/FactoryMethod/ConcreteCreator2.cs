namespace DesignPatternsNotes.Creational.FactoryMethod;

public class ConcreteCreator2 : CreatorBase
{
    protected override IProduct FactoryMethod() => new ConcreteProduct2();
}