namespace DesignPatternsNotes.Structural.Decorator;

public class ConcreteDecoratorA(IComponent component) : IComponent
{
    public string Operation() => $"ConcreateDecoratorA({component.Operation()})";
}