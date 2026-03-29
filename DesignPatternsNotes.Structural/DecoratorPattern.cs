using DesignPatternsNotes.Core;
using DesignPatternsNotes.Structural.Decorator;

namespace DesignPatternsNotes.Structural;

public class DecoratorPattern(IDisplay display) : IStructural
{
    public string Name { get; } = "Decorator";

    public string Description { get; } = """
                                         Decorator is a structural design patter that lets you attach new behaviors to objects by placing these objects inside special wrapper object that contain the behaviors.
                                         Wrapper is the alternative nickname for the Decorator pattern that clearly express the main idea of the pattern.
                                         """;

    public string Problem { get; } = """
                                     Imagine that you're working on a notification library witch lets other programs notify their users about important events.
                                     The initial version of the library was based on the Notifier class that had only a few fields, a constructor a single send method.
                                     The method could accept a message argument from a client and send the message to a list of emails that were passed to the notifier via its constructor.
                                     A third-party  app which acted as a client was supposed to create and configure the notifier object once, and then use it each time something important happened.
                                     At some point, you realize that users of the library expect more than just email notifications.
                                     """;

    public string Solution { get; } = """
                                      Extending a class is the first thing that comes to mind when you need to alter an object's behavior.
                                      However, inheritance has several serious caveats that you need to be aware of.
                                      - Inheritance is static. You can't change the behavior of an object at runtime. You can only replace the whole  object with another one that's created from a different subclass.
                                      - Subclasses can have just one parent class. In most languages, inheritance doesn't let a class inherit behaviors of multiple class ate the same time.

                                      One of the way to overcome these caveats is by using Aggregation or Composition instead of inheritance. 
                                      Both of the alternatives work almost the same way: one object has a reference to another and delegates it some work, whereas with inheritance, the object itself is able to do that work, inheriting the behaviors from its superclass .
                                      """;

    public string Applicability { get; } = "Use the Decorator pattern when you need to be able to assign extra behaviors to object at runtime without breaking the code that uses thees objects.";

    public void Run()
    {
        display.WriteSpacedLine("""
                                I've got a simple component:
                                var simple = new ConcreteComponent();
                                """);
        var simple = new ConcreteComponent();

        display.WriteSpacedLine($"{simple.Operation()}");

        display.WriteSpacedLine("""
                                Let's decorate it with the first decorator:
                                var decorator1 = new ConcreteDecoratorA(simple);
                                """);
        
        var decorator1 = new ConcreteDecoratorA(simple);
        
        display.WriteSpacedLine($"""
                                Now the component has got new behavior:
                                {decorator1.Operation()}
                                """);
        
        display.WriteSpacedLine("""
                                Let's decorate the first decorator again:
                                var decorator2 = new ConcreteDecoratorB(decorator1);
                                """);
        
        var decorator2 = new ConcreteDecoratorB(decorator1);
        
        display.WriteSpacedLine($"""
                                 Now the component has got new behavior:
                                 {decorator2.Operation()}
                                 """);
    }
}