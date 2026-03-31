namespace DesignPatternsNotes.Behavioral.Command;

public class SimpleCommand(string payload) : ICommand
{
    public string Execute() => $"SimpleCommand: See, I can do simple things like printing ({payload})";
}