using DesignPatternsNotes.Core;
using DesignPatternsNotes.Creational.Abstract;
using DesignPatternsNotes.Creational.Builder;

namespace DesignPatternsNotes.Creational;

public class BuilderPattern(IDisplay display) : ICreational
{
    public string Name { get; } = "Builder";

    public string Description { get; } = """
                                             Builder is a creational design pattern that lets you construct complex objects step by step. 
                                             The pattern allows you to produce different types and representations of an object using the same construction code. 
                                         """;

    public string Problem { get; } = """
                                     Imagine a complex object that requires laborious, step-by-step initialization of many fields and nested objects.
                                     Such initialization code is usually buried inside a monstrous constructor with lots of parameters.
                                     """;

    public string Solution { get; } = "The Builder pattern suggests that you abstract the objects construction code out of its own class and move it to separate objects called builders.";

    public string Applicability { get; } = """
                                           Say you have a constructor with ten optional parameters.
                                           Calling such a beast is a nightmare; therefore you overload the constructor and create several shorter versions with few parameters.
                                           These constructor still refer to the main one, passing some default values into any omitted parameters.
                                           """;

    public void Run()
    {
        var builder = new ConcreteBuilder();
        var director = new Director(builder);

        display.WriteSpacedLine("""
                                var builder = new ConcreteBuilder();
                                var director = new Director(builder);
                                """);

        display.WriteSpacedLine("Build minimal product:");

        director.BuildMinimalProduct();

        display.WriteSpacedLine("""
                                director.BuildMinimalViableProduct();
                                builder.GetProducts().ListParts();
                                """);

        display.WriteSpacedLine(builder.GetProduct().ListParts());

        display.WriteSpacedLine("Build full product:");

        director.BuildFullFeatureProduct();

        display.WriteSpacedLine("""
                                director.BuildFullFeatureProduct();
                                builder.GetProduct().ListParts();
                                """);
        
        display.WriteSpacedLine(builder.GetProduct().ListParts());
        
        display.WriteSpacedLine("Build Custom product:");
        
        builder.BuildPartA();
        builder.BuildPartB();
        
        display.WriteSpacedLine("""
                                builder.BuildPartA();
                                builder.BuildPartB();
                                builder.GetProduct().ListParts();
                                """);
        
        display.WriteSpacedLine(builder.GetProduct().ListParts());
    }
}