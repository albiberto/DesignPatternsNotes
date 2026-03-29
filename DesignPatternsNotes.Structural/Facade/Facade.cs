namespace DesignPatternsNotes.Structural.Facade;

public class Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
{
    public string Operation() => $"""
                                  Facade initializes subsystems:
                                  {subsystem1.Operation1()}
                                  {subsystem2.Operation1()}
                                  Facade orders subsystems to perform the action:
                                  {subsystem1.OperationN()}
                                  {subsystem2.OperationZ()}
                                  """;
}