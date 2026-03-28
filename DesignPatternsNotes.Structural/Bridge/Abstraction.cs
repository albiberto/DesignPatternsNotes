namespace DesignPatternsNotes.Structural.Bridge;

public class Abstraction(IImplementation implementation)
{
    protected readonly IImplementation Implementation = implementation;

    public virtual string Operation() => $"""
                                          Abstract: Base operation with: 
                                          {Implementation.OperationImplementation()}
                                          """;
}