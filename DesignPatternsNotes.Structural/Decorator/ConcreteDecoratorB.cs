namespace DesignPatternsNotes.Structural.Decorator;

public class ConcreteDecoratorB(IComponent component) : IComponent
{
    public string Operation() => $"ConcreateDecoratorB({component.Operation()})";
}