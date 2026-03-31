namespace DesignPatternsNotes.Behavioral.Command;

public class ComplexCommand(Receiver receiver, string left, string right) : ICommand
{
    public string Execute() => $"Complex Command: Working on {receiver.DoSomething(left)} {receiver.DoSomethingElse(right)}";
}