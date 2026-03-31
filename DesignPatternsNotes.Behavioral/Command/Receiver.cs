namespace DesignPatternsNotes.Behavioral.Command;

public class Receiver
{
    public string DoSomething(string payload) => $"Receiver: Working on {payload}";
    public string DoSomethingElse(string payload) => $"Receiver: Also working on {payload}";
}