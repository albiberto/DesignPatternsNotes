namespace DesignPatternsNotes.Structural.Bridge;

public class ConcreateImplementationA : IImplementation
{
    public string OperationImplementation() => "ConcreteImplementationB: The result in platform A.";
}