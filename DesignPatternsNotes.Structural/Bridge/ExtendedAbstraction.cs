namespace DesignPatternsNotes.Structural.Bridge;

public class ExtendedAbstraction(IImplementation implementation) : Abstraction(implementation)
{
    public override string Operation() =>
        $"""
         ExtendedAbstraction: Extended operation with:
         {Implementation.OperationImplementation()}
         """;
}