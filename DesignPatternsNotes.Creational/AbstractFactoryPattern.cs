using DesignPatternsNotes.Core;
using DesignPatternsNotes.Creational.Abstract;
using DesignPatternsNotes.Creational.AbstractFactory;

namespace DesignPatternsNotes.Creational;

public class AbstractFactoryPattern(IDisplay display) : ICreational
{
    public string Name { get; } = "Abstract Factory";

    public string Description { get; } = "Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.";
    public string Problem { get; } = """
                                     Imagine that you're creating a forniture shop simulator.
                                     Your code consists of classes that represent:
                                        - A family of related products, say: Chair, Sofa, CoffeeTable.
                                        - Multiple variants of these products, say: Victorian, Modern, ArtDeco.
                                     You need a way to create individual forniture objects so that they match other objects of the same family.
                                     Customers get quite mad when they receive non-matching forniture.
                                     Also, you don't want to change existing code when adding new products or families of products to the program.
                                     """;

    public string Solution { get; } = """
                                      The first thing the Abstract Factory pattern suggests is to explicitly declare interfaces for each distinct product of the product family.
                                      Then you can make all variations of products follow those interfaces.
                                      The next move is to declare the Abstract Factory, an interface with a list of creation methods for all products that are part od the product family.
                                      These methods must return abstract product types represented by the interfaces we extracted previously.
                                      For each variant of a product family, we create a separate factory class that implements the Abstract Factory interface and creates only products of a single variant.
                                      """;
    public string Applicability { get; } = """
                                           Use the Abstract Factory when your code needs to work with various families of related products, but you don't want it to depend on the concrete classes of those products.
                                           They might be unknown beforehand or you simply want to allow for future extensibility.
                                           """;
    public void Run()
    {
        display.WriteSpacedLine("Client: Testing client code with the first factory type...");
        display.WriteSpacedLine("factory = new ConcreteFactory1();");
        ClientMethod(new ConcreteFactory1());

        display.WriteSpacedLine("Client: Testing the same client code with the second factory type...");
        display.WriteSpacedLine("factory = new ConcreteFactory2();");
        ClientMethod(new ConcreteFactory2());
    }
    
    private void ClientMethod(IAbstractFactory factory)
    {
        var productA = factory.CreateProductA();
        var productB = factory.CreateProductB();
        
        display.WriteSpacedLine("""
                                var productA = factory.CreateProductA();
                                var productB = factory.CreateProductB();
                                """);

        display.WriteLine(productB.UsefulFunctionB());
        display.WriteSpacedLine(productB.AnotherUsefulFunctionB(productA));
    }
}