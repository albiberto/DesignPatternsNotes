using DesignPatternsNotes.Core;
using DesignPatternsNotes.Structural.Facade;
using FacadeClass = DesignPatternsNotes.Structural.Facade.Facade;

namespace DesignPatternsNotes.Structural;

public class FacadePattern(IDisplay display) : IStructural
{
    public string Name { get; } = "Facade";
    public string Description { get; } = "Facade is a structural desgin pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.";

    public string Problem { get; } = """
                                     Image that you must make your code work with a board set of objects that belong to a sophisticated library of framework.";
                                     Ordinarily, you would need to initialize all of those objects, keep track of dependencies, execute methods in the correct order, and so on.
                                     
                                     As a result, the business logic of your classes would become tightly coupled to the implementation details of 3rd-party classes, making it hard to comprehend and maintain.
                                     """;
    public string Solution { get; } = """
                                      A facade is a class that provides a simple interface to a complex subsystem which contains lots of moving parts.
                                      A facade might provide limited functionality in comparison to working with the subsystem directly.
                                      However, it includes only those features that clients really care about.
                                      """;

    public string Applicability { get; } = "Use tha Facade pattern when you need to have a limited but straightforward interface to a complex subsystem.";
    
    public void Run()
    {
        display.WriteSpacedLine("""
                                var subsystem1 = new Subsystem1();
                                var subsystem2 = new Subsystem2();
                                
                                var facade = new FacadeClass(subsystem1, subsystem2);
                                """);
        
        var subsystem1 = new Subsystem1();
        var subsystem2 = new Subsystem2();

        var facade = new FacadeClass(subsystem1, subsystem2);
        
        display.WriteLine(facade.Operation());
    }
}