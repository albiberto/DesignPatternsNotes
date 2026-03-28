using DesignPatternsNotes.Core;
using DesignPatternsNotes.Creational.Abstract;
using DesignPatternsNotes.Creational.FactoryMethod;

namespace DesignPatternsNotes.Creational;

public class FactoryMethodPattern(IDisplay display) : ICreational
{
    public string Name { get; } = "Factory";
    public string Description { get; } = "Factory Method is a creational design patter that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of object that will be created.";

    public string Problem { get; } = """
                                     Imagine that you're creating a logistics management application.
                                     The first version of your app can only handle transportation by trucks, so the bulk of your code lives inside the `Truck` class.

                                     After a while, your app becomes pretty popular.
                                     Each day you receive dozens of requests from sea transportation companies to incorporate sea logistic into the app. 
                                     """;

    public string Solution { get; } = """
                                      The Factory Method pattern suggest that you replace direct object construction calls (using the `new` operator) with calls to a special factory method.
                                      Don't worry: the objects are still created via the `new` operator, but it's being called from within the factory method.
                                      """;

    public string Applicability { get; } = "Use the Factory Method when you don't know beforehand the exact type and dependencies of the objects your code should work with.";

    public void Run()
    {
        display.WriteSpacedLine("Launched with the ConcreteCreator1.");

        display.WriteSpacedLine("var c1 = new ConcreteCreator1();");

        var c1 = new ConcreteCreator1();
        ClientCode(c1);
        
        display.WriteSpacedLine("Launched with the ConcreteCreator2.");
        
        var c2 = new ConcreteCreator2();
        ClientCode(c2);

        display.WriteSpacedLine("var c2 = new ConcreteCreator2();");
    }

    private void ClientCode(CreatorBase creator) =>
        display.WriteSpacedLine($"""
                                 I'm not aware of the creator's class. but it still works.
                                 {creator.SomeOperation()}
                                 """);
}