using DesignPatternsNotes.Core;
using DesignPatternsNotes.Structural.Bridge;

namespace DesignPatternsNotes.Structural;

public class BridgePattern(IDisplay display) : IStructural
{
    public string Name { get; } = "Bridge";
    
    public string Description { get; } = "Bridge is a structural design pattern that divides business logic or huge class into separate class hierarchies that can be developed independently.";
    
    public string Problem { get; } = """
                                     The problem arises when a class has multiple orthogonal dimensions of variation (e.g., Shape and Color). 
                                     Attempting to extend the class using inheritance for every possible combination leads to an exponential explosion 
                                     of subclasses (often called the Cartesian product problem).
                                     """;
                                     
    public string Solution { get; } = """
                                      The Bridge pattern solves this by switching from inheritance to composition. It extracts one of the 
                                      dimensions into a separate class hierarchy (referred to as Abstraction and Implementation). 
                                      The original class then maintains a reference to an object of the new hierarchy, bridging the two parts.
                                      """;
                                      
    public string Applicability { get; } = """
                                           Use the Bridge pattern when you want to divide and organize a monolithic class that has several 
                                           variants of some functionality (e.g., if the class can work with various database servers). 
                                           It is also useful when you need to be able to switch implementations at runtime.
                                           """;

    public void Run()
    {
        var abstraction = new Abstraction(new ConcreateImplementationA());
        
        display.WriteSpacedLine("var abstraction = new Abstraction(new ConcreateImplementationA());");
        display.WriteSpacedLine(abstraction.Operation());
        
        abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
        
        display.WriteSpacedLine("abstraction = new Abstraction(new ConcreteImplementationB());");
        display.WriteSpacedLine(abstraction.Operation());
    }
}